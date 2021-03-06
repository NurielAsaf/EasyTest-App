﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EasyTest_App
{
    public partial class SummaryForm : Form
    {
        public static string send ;
        public static Boolean collect = false;
        private Boolean signature = false;
        float pointX = 0, pointY = 0, LastX = 0, LastY = 0;
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=easytest");
        public SummaryForm()
        {
            InitializeComponent();
        }

        private void SummaryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            con.Open();

            string Query = "SELECT * FROM examination_log WHERE exam_id = @value";
            MySqlCommand cmd = new MySqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@value", Login.exam_table.Rows[0].ItemArray[0].ToString());
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBoxExamID.Text = dr["exam_id"].ToString();
                textBoxCourseName.Text = getCourse(dr["course_id"].ToString());
                textBoxLecturerName.Text = getLecturer(dr["lecturer_id"].ToString());
                textBoxProctorName.Text = getProctor(dr["proctor_id"].ToString());
                textBoxStartTime.Text = dr["start_time"].ToString().Substring(0, 5);
                textBoxEndTime.Text = dr["end_time"].ToString().Substring(0, 5);
                textBoxExtraTime.Text = dr["extra_time"].ToString().Substring(3) + " דקות";
                listBoxStudents.Items.Add(getStudent(dr["student_id"].ToString()));
            }
            
            con.Close();
           
        }
        private string getProctor(string s)
        {
            MySqlConnection con2 = new MySqlConnection("server=localhost;user id=root;database=easytest");
            con2.Open();
            string Query = "SELECT * FROM proctor WHERE proctor_id = @value";
            MySqlCommand cmd = new MySqlCommand(Query, con2);
            cmd.Parameters.AddWithValue("@value", s);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["proctor_id"].ToString() == s)
                    con.Close();
                return dr["first_name"].ToString() + " " + dr["last_name"].ToString();
            }
            con.Close();
            return "";
        }
        private string getCourse(string s)
        {
            MySqlConnection con2 = new MySqlConnection("server=localhost;user id=root;database=easytest");
            con2.Open();
            string Query = "SELECT * FROM course WHERE course_id = @value";
            MySqlCommand cmd = new MySqlCommand(Query, con2);
            cmd.Parameters.AddWithValue("@value", s);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["course_id"].ToString() == s)
                    con.Close();
                return dr["course_name"].ToString();
            }
            con.Close();
            return "";
        }
        private string getStudent(string s)
        {
            MySqlConnection con2 = new MySqlConnection("server=localhost;user id=root;database=easytest");
            con2.Open();
            string Query = "SELECT * FROM student WHERE student_id = @value";
            MySqlCommand cmd = new MySqlCommand(Query, con2);
            cmd.Parameters.AddWithValue("@value", s);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["student_id"].ToString() == s)
                    con.Close();
                return dr["first_name"].ToString()+ " " +dr["last_name"].ToString();
            }
            con.Close();
            return "";
        }

        private void panelSignature_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = panelSignature.CreateGraphics();
            graphics.DrawLine(Pens.Black, pointX, pointY, LastX, LastY);
            LastX = pointX;
            LastY = pointY;
            
        }

        private void panelSignature_MouseDown(object sender, MouseEventArgs e)
        {
            LastX = e.X;
            LastY = e.Y;
        }

        private void panelSignature_MouseMove(object sender, MouseEventArgs e)
        {

            if(e.Button==MouseButtons.Left)
            {
                pointX = e.X;
                pointY = e.Y;
                panelSignature_Paint(this, null);
            }
            
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            errorProviderSummary.Clear();
            if(textBox2ndProctor.Text!="")
            {
                if (pointX!=0 && pointY!=0 &&panelSignature.Visible)
                {
                    MessageBox.Show("מבחן הוזן בהצלחה,תודה רבה");
                    Close();
                }
                else
                    errorProviderSummary.SetError(panelSignature, "אנא הזן חתימה");
            }
            else
                errorProviderSummary.SetError(textBox2ndProctor, "אנא הזן שם משגיח בחינה ");

        }

        private string getLecturer(string s)
        {
            MySqlConnection con2 = new MySqlConnection("server=localhost;user id=root;database=easytest");
            con2.Open();
            string Query = "SELECT * FROM lecturer WHERE lecturer_id = @value";
            MySqlCommand cmd = new MySqlCommand(Query, con2);
            cmd.Parameters.AddWithValue("@value", s);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["lecturer_id"].ToString() == s)
                    con.Close();
                return dr["first_name"].ToString() + " " + dr["last_name"].ToString();
            }
            con.Close();
            return "";
        }
        private void buttonCollect_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            send = "summary";
            Hide();
            login.Show();
        }

        private void SummaryForm_Activated(object sender, EventArgs e)
        {
            errorProviderSummary.Clear();
            if (send == "lecturer")
            {
                buttonCollect.Visible = false;
                panelSignature.Visible = true;
            }
        }
    }
}
