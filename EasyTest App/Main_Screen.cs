﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace EasyTest_App
{
    public partial class Main_Screen : Form
    {
        int minutes = 0;
        int seconds = 0;
      
        //private static readonly int collumn = 5;
        //private static readonly int row = 3;
        private static readonly int CARD_SIZE = 45;
        private static readonly int GAP = 1;
        private readonly Color FORGROUND_COLOR = Color.Black;
        public static Color BACKGROUND_COLOR_main = Color.LightGray;
        public static Button[,] mainMap = new Button[0, 0];
        public static Boolean firstTime = true;
        public static string send2profile;
        public static DataTable maping_table = new DataTable();
        public static string map_row = "";
        public static string map_collumn = "";
        public static Boolean StudentInToilet = false;
        public static Boolean TestBegin =false;
        public static Boolean EmptyClass = true;
        public static Boolean BeginBTN = false;
        public static bool first = true;
        //  public static Button beginBTN;
        public static string class_start_time;
        //public static Boolean fristOne = false;
        // private Map_Screen map_screen;
       



        // לסדר את זה שכאשר אני מוסיף את הסטודנט הראשון הכפתור של התחל בחינה יהיה זמין וכו


        public Main_Screen()
        {
            InitializeComponent();
          
            
          
            //map_screen = new Map_Screen();
            //map_screen.ButtonWasClicked += new Map_Screen.ClickButton(map_screen_ButtonWasClicked);

        }
        /* void map_screen_ButtonWasClicked()
         {
             BeginExamBTN.Enabled = true;
         }*/
       
       
        private void BeginExamBTN_Click(object sender, EventArgs e)
        {
            TestBegin = true;
           
            var startMessaage = MessageBox.Show("?האם להתחיל את המבחן","הודעה",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(startMessaage == DialogResult.Yes)
            {
                string query = "UPDATE `examination_log` SET `start_time` = @startTime, `class_start_time` = @startTime WHERE exam_id = @exam_id";

                MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                class_start_time = getTime();
                cmd.Parameters.AddWithValue("@startTime", getTime());
                cmd.Parameters.AddWithValue("@exam_id", Login.exam_table.Rows[0].ItemArray[0].ToString());
                int flg = cmd.ExecuteNonQuery();
                //MySqlDataReader dr = cmd.ExecuteReader();

                if (flg>0)
                {
                    timer1.Enabled = true;
                    timer1.Start();
                    BeginExamBTN.Enabled = false;
                }
                else { MessageBox.Show("שגיאה", "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

                conn.Close();
            }

           


        }

        private void AddStudentBTN_Click(object sender, EventArgs e)
        {
            Add_Student add_student_screen = new Add_Student();
            add_student_screen.Show();
            Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(seconds == 60)
            {
                minutes++;
                seconds = 0;
            }
            if (minutes < 10 && seconds < 10)
            {
                label1.Text = "0" + minutes + ":0" + seconds;
            }
            else if (minutes < 10 && seconds > 10)
                label1.Text = "0" + minutes + ":" + seconds;
            else
                label1.Text = minutes + ":" + seconds;
            seconds++;

        }

        private void Main_Screen_Load(object sender, EventArgs e)
        {
            

           
            ////////////////////////////////////////////////////////////////////
            string Query = "SELECT * FROM mapping WHERE class_num = @class_num";
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@class_num", Login.exam_table.Rows[0].ItemArray[4].ToString());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(maping_table);

            map_row = maping_table.Rows[0].ItemArray[1].ToString();
            map_collumn = maping_table.Rows[0].ItemArray[2].ToString();

            mainMap = new Button[Int32.Parse(map_collumn), Int32.Parse(map_row)];
            conn.Close();





            if (firstTime)
            {
                int id = 0;
                
                for (int i = 0; i < Int32.Parse(map_row); i++)
                {
                    for (int j = 0; j < Int32.Parse(map_collumn); j++)
                    {

                        id++;

                        mainMap[j, i] = new Button
                        {
                            Name = "card" + j + i,
                            Size = new Size(CARD_SIZE, CARD_SIZE),
                            Location = new Point(GAP + j * (CARD_SIZE + GAP),GAP + i * (CARD_SIZE + GAP)),
                            TextAlign = ContentAlignment.MiddleCenter,
                            Font = new Font("david", 20),
                            ForeColor = FORGROUND_COLOR,
                            BackColor = BACKGROUND_COLOR_main,
                            Text = id.ToString(),

                        };
                        //mainMap[j, i].Location = new Point(1, 1);
                        panel1.Controls.Add(mainMap[j, i]);
                        panel1.AutoSize = true;
                        panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                        //panel1.Location = new Point(12, 17);
                        //panel1.Size = new Size(400, 200);
                        //Controls.Add(mainMap[j, i]);
                        //Controls.Add(mainMap[j, i]);
                        mainMap[j, i].Click += Button_Click;
                        mainMap[j, i].Enabled = false;






                    }
                    // groupBox1.AutoSize = true;
                    //groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                    // Controls.AutoSize = true;
                    // Controls.AutoSizeMode = AutoSizeMode.GrowAndShrink;

                }
                string Query1 = "SELECT * FROM examination_log WHERE exam_id = @exam_id";
                MySqlConnection conn1 = new MySqlConnection("server=localhost;user id=root;database=easytest");
                conn1.Open();

                MySqlCommand cmd1 = new MySqlCommand(Query1, conn1);
                cmd1.Parameters.AddWithValue("@exam_id", Login.exam_table.Rows[0].ItemArray[0].ToString());
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                DataTable log_table = new DataTable();
                da1.Fill(log_table);
                conn1.Close();
                if (log_table.Rows.Count > 0)
                {

                    if (!(log_table.Rows[0][12].ToString().Equals("00:00:00")))
                    {
                        BeginExamBTN.Enabled = false;
                        TestBegin = true;
                        EmptyClass = false;
                        class_start_time = log_table.Rows[0][12].ToString();
                    }
                    else
                    {
                        BeginExamBTN.Enabled = true;
                        TestBegin = false;
                        EmptyClass = false;

                    }

                    //int count = 0;
                    for (int i = 0; i < Int32.Parse(Main_Screen.map_row); i++)
                    {
                        for (int j = 0; j < Int32.Parse(Main_Screen.map_collumn); j++)
                        {
                            for (int t = 0; t < log_table.Rows.Count; t++)
                            {
                                if (Main_Screen.mainMap[j, i].Text == log_table.Rows[t][8].ToString())
                                {
                                    Main_Screen.mainMap[j, i].BackColor = Color.Red;
                                    Main_Screen.mainMap[j, i].Enabled = true;
                                }

                            }

                            /*if (Main_Screen.mainMap[j, i].Text == log_table.Rows[count][8].ToString())
                            {
                                Main_Screen.mainMap[j, i].BackColor = Color.Red;
                                Main_Screen.mainMap[j, i].Enabled = true;
                            }*/

                        }
                    }
                }
                else 
                {
                    BeginExamBTN.Enabled = false;
                    EmptyClass = true;
                    TestBegin = false;
                }   


                firstTime = false;

            }
            ///////////////////////////////////////////////////////




            





            


        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            send2profile = btn.Text;
            StudentProfileForm st = new StudentProfileForm();
            st.Show();
            Hide();

            /*             
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    if (btn == cards[i, j])
                    {
                      
                    }
                }
            }*/
        }   


        private void EndExamBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReportBTN_Click(object sender, EventArgs e)
        {

        }
        public void setName(string name)
        {
            labelName.Text = "Hello" + name;
        }

        private void ExtraTimeBTN_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static string getTime()
        {
            string time = "";

            DateTime now = DateTime.Now;

            if (now.Minute < 10)
            {
                time = now.Hour.ToString() + ":0" + now.Minute.ToString();
            }
            else if (now.Hour < 10)
            {
                time = "0" + now.Hour.ToString() + ":" + now.Minute.ToString();
            }
            else if (now.Hour < 10 && now.Minute < 10)
            {
                time = "0" + now.Hour.ToString() + ":0" + now.Minute.ToString();
            }
            else if (now.Minute == 0)
            {
                time = now.Hour.ToString() + ":00";
            }
            else if (now.Minute == 0)
            {
                time = now.Hour.ToString() + ":00";
            }
            else if (now.Hour == 0)
            {
                time = "00" + now.Hour.ToString() + ":" + now.Minute.ToString();
            }
            else if (now.Hour == 0 && now.Minute == 0)
            {
                time = "00" + now.Hour.ToString() + ":00" + now.Minute.ToString();

            }
            else
            {
                time = now.Hour.ToString() + ":" + now.Minute.ToString();

            }
            return time;
            

        }

        private void Main_Screen_Activated(object sender, EventArgs e)
        {
            if (!first)
                BeginExamBTN.Enabled = true ;
        }
    }
}
