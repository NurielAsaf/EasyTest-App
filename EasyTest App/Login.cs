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
using System.Text.RegularExpressions;

namespace EasyTest_App
{
    public partial class Login : Form
    {
        // bool changed = false
        public static string admin_id;


        public Login()
        {
            InitializeComponent();
        }
        public static Boolean startProgram = false;
        public static Boolean ClickTextBox1 = false; 
        public static Boolean ClickTextBox2 = false;
        public static AdminForm adminF = new AdminForm();

        public static DataTable exam_table = new DataTable();
        public static Main_Screen main_screen = new Main_Screen();
        public static DataTable proctor_table = new DataTable();


        private void LoginBTN_Click(object sender, EventArgs e)
        {
            

            Regex IdReg = new Regex("[0-9]{9}");
            Regex PassReg = new Regex("[0-9]{5}");
            if (!startProgram) 
            {

                if (!IdReg.IsMatch(UserID_textbox.Text))
                {
                    MessageBox.Show("יש להזין ת.ז כולל ספרת ביקורת", "הודעה");
                    if (!PassReg.IsMatch(Pass_textbox.Text)) { MessageBox.Show("יש להזין סיסמה עם 5 ספרות", "הודעה"); }
                }
                else if(!PassReg.IsMatch(Pass_textbox.Text))
                {
                    MessageBox.Show("יש להזין סיסמה עם 5 ספרות", "הודעה");
                   
                }
                else
                {

                    string Query = "SELECT * FROM proctor WHERE proctor_id = @UserID_textbox AND " +
                        "proctor_pass = @Pass_textbox";
                    MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(Query, conn);
                    cmd.Parameters.AddWithValue("@UserID_textbox", UserID_textbox.Text);
                    cmd.Parameters.AddWithValue("@Pass_textbox", Pass_textbox.Text);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    //DataTable proctor_table = new DataTable();
                    da.Fill(proctor_table);

                    //MessageBox.Show(dt.Rows[0].ItemArray[1].ToString());

                    //MySqlDataReader rdr = cmd.ExecuteReader();
                    //rdr.Read();


                    if (proctor_table.Rows.Count > 0)
                    {
                        startProgram = true;
                        if (proctor_table.Rows[0][5].ToString() == "0")
                        {
                            //create an copy table of exam (local table)

                            MySqlCommand cmdExam = new MySqlCommand("SELECT * FROM exam WHERE proctor_id = @UserID_textbox", conn);
                            cmdExam.Parameters.AddWithValue("@UserID_textbox", UserID_textbox.Text);
                            MySqlDataAdapter dataAD = new MySqlDataAdapter(cmdExam);
                            dataAD.Fill(exam_table);
                            

                            //Main_Screen main_screen = new Main_Screen();
                            main_screen.Show();
                            Hide();
                          
                        }
                        if (proctor_table.Rows[0][5].ToString() == "1")
                        {
                            admin_id = proctor_table.Rows[0][0].ToString();
                            adminF.Show();
                            Hide();
                          
                        }

                        //create an copy table of exam (local table)

                       

                        conn.Close();

                    }
                    else
                    {
                        MessageBox.Show("שם משתמש או סיסמה שגויים", "הודעה");
                    }
                }

            }
            else if(startProgram)
            {
                string Query = "SELECT * FROM lecturer WHERE lecturer_id = @UserID_textbox AND " +
                       "lecturer_pass = @Pass_textbox";
                MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(Query, conn);
                cmd.Parameters.AddWithValue("@UserID_textbox", UserID_textbox.Text);
                cmd.Parameters.AddWithValue("@Pass_textbox", Pass_textbox.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //MySqlDataReader rdr = cmd.ExecuteReader();
                //rdr.Read();

                if (dt.Rows.Count > 0)
                {

                    conn.Close();
                    ExtraTimeForm ex = new ExtraTimeForm();
                    ex.Show();
                    Hide();

                }
                else
                {
                    MessageBox.Show("שם משתמש או סיסמה שגויים", "הודעה");

                }
            }
            else MessageBox.Show("שם משתמש או סיסמה שגויים", "הודעה");
            
            ClickTextBox1 = false; 
            ClickTextBox2 = false;
            UserID_textbox.Text = "הכנס ת.ז";
            Pass_textbox.Text = "הכנס סיסמה";
        }

        private void LoginBTN_MouseHover(object sender, EventArgs e)
        {
            LoginBTN.BackColor = Color.CornflowerBlue; 
        }

        private void UserID_textbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Pass_textbox_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (startProgram) { login_backBTN.Visible = true; }
            panel3.BackColor = Color.FromArgb(150, 0, 0, 0);
           
        }

        private void login_backBTN_Click(object sender, EventArgs e)
        {
            
            main_screen.Show();
            Hide();
        }

        private void UserID_textbox_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (!ClickTextBox1)
            {
                UserID_textbox.Text = "";
                ClickTextBox1 = true;
              
            }
            
        }

        private void Pass_textbox_MouseClick(object sender, MouseEventArgs e)
        {
            if (!ClickTextBox2)
            {
                Pass_textbox.Text = "";
                ClickTextBox2 = true;
            }
        }

        private void LoginBTN_MouseLeave(object sender, EventArgs e)
        {
            LoginBTN.BackColor = Color.RoyalBlue;
        }
    }
}
