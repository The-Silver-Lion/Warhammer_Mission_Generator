using System;
using System.IO;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warhammer_Mission_Generator
{
    public partial class frm_Main : Form
    {
        public class Missions
        {

            public string m_sMission { get; set; }
            public string m_sReference { get; set; }

        }

        public static class MyMissions
        {

            public static List<Missions> m_MyMissions = new List<Missions>();
            public static int m_iSelected { get; set; }

        }

        public frm_Main()
        {
            InitializeComponent();
        }

        private void Error_Message()
        {

            MessageBox.Show("An error has occured! Please Try agin...");

        }

        private void Set_After_Second_Maneuver()
        {

            lbl_Tracker.Text = "4";

            btn_Selection_1.Visible = false;
            btn_Selection_1.Enabled = false;

            btn_Selection_2.Visible = false;
            btn_Selection_2.Enabled = false;

            btn_Selection_3.Visible = false;
            btn_Selection_3.Enabled = false;

            lbl_Selector.Visible = false;
            lbl_PlayerMessage.Visible = false;

            btn_Submit.Visible = true;
            btn_Submit.Enabled = true;
            btn_Submit.Location = new Point(215, 196);
            btn_Submit.Text = "Reveal";

        }

        private void Set_After_First_Maneuver()
        {

            lbl_Tracker.Text = "3";

            if (lbl_IsAttacker.Text == "0")
            {

                lbl_Selector.Text = lbl_Name2.Text + " select your tactical maneuver:";
                btn_Selection_1.Text = "Advance";
                btn_Selection_2.Text = "Flank";
                btn_Selection_3.Text = "Charge";
                lbl_PlayerMessage.Text = lbl_Name1.Text + " should look away";

            }
            else if (lbl_IsAttacker.Text == "1")
            {

                lbl_Selector.Text = lbl_Name2.Text + " select your tactical maneuver:";
                btn_Selection_1.Text = "Hold";
                btn_Selection_2.Text = "Ambush";
                btn_Selection_3.Text = "Counter";
                lbl_PlayerMessage.Text = lbl_Name1.Text + " should look away";

            }
            else
            {

                Error_Message();

            }

        }

        private void Set_After_Attack_Selection()
        {

            lbl_Tracker.Text = "2";

            btn_Selection_1.Visible = true;
            btn_Selection_1.Enabled = true;
            btn_Selection_1.Location = new Point(110, 247);

            btn_Selection_2.Visible = true;
            btn_Selection_2.Enabled = true;
            btn_Selection_2.Location = new Point(330, 247);


            btn_Selection_3.Visible = true;
            btn_Selection_3.Enabled = true;
            btn_Selection_3.Location = new Point(220, 247);
            lbl_PlayerMessage.Visible = true;

            if (lbl_IsAttacker.Text == "1")
            {

                lbl_Selector.Text = lbl_Name1.Text + " select your tactical maneuver:";
                btn_Selection_1.Text = "Advance";
                btn_Selection_2.Text = "Flank";
                btn_Selection_3.Text = "Charge";
                lbl_PlayerMessage.Text = lbl_Name2.Text + " should look away";

            }
            else if (lbl_IsAttacker.Text == "0")
            {

                lbl_Selector.Text = lbl_Name1.Text + " select your tactical maneuver:";
                btn_Selection_1.Text = "Hold";
                btn_Selection_2.Text = "Ambush";
                btn_Selection_3.Text = "Counter";
                lbl_PlayerMessage.Text = lbl_Name2.Text + " should look away";

            }
            else
            {

                Error_Message();

            }

        }

        private void Save_Complete_Missions()
        {

            int iCount = 0;
            List<Missions> Complete_Missions = Download_Complete_Missions();
            Complete_Missions.Add(new Missions { m_sMission = MyMissions.m_MyMissions[MyMissions.m_iSelected].m_sMission, m_sReference = MyMissions.m_MyMissions[MyMissions.m_iSelected].m_sReference });

            if (lbl_Attacker_Wins.Text == "0")
            {

                StreamWriter MainFile = new StreamWriter(@"..\Data\" + ddl_Size.Text + "/Played/Defender_Advantage.txt");

                for (iCount = 0; iCount < Complete_Missions.Count; iCount++)
                {

                    MainFile.Write(Complete_Missions[iCount].m_sMission + "\r\n");
                    MainFile.Write(Complete_Missions[iCount].m_sReference + "\r\n");

                }

                MainFile.Close();

            }
            else if (lbl_Attacker_Wins.Text == "1")
            {

                StreamWriter MainFile = new StreamWriter(@"..\Data\" + ddl_Size.Text + "/Played/Attacker_Advantage.txt");

                for (iCount = 0; iCount < Complete_Missions.Count; iCount++)
                {

                    MainFile.Write(Complete_Missions[iCount].m_sMission + "\r\n");
                    MainFile.Write(Complete_Missions[iCount].m_sReference + "\r\n");

                }

                MainFile.Close();

            }
            else if (lbl_Attacker_Wins.Text == "2")
            {

                StreamWriter MainFile = new StreamWriter(@"..\Data\" + ddl_Size.Text + "/Played/No_Advantage.txt");

                for (iCount = 0; iCount < Complete_Missions.Count; iCount++)
                {

                    MainFile.Write(Complete_Missions[iCount].m_sMission + "\r\n");
                    MainFile.Write(Complete_Missions[iCount].m_sReference + "\r\n");

                }

                MainFile.Close();

            }
            else
            {

                Error_Message();

            }

        }

        private void Save_Next_Missions()
        {

            int iCount = 0;
            MyMissions.m_MyMissions.RemoveAt(MyMissions.m_iSelected);

            if (lbl_Attacker_Wins.Text == "0")
            {

                StreamWriter MainFile = new StreamWriter(@"..\Data\" + ddl_Size.Text + "/Defender_Advantage.txt");

                for (iCount = 0; iCount < MyMissions.m_MyMissions.Count; iCount++)
                {

                    MainFile.Write(MyMissions.m_MyMissions[iCount].m_sMission + "\r\n");
                    MainFile.Write(MyMissions.m_MyMissions[iCount].m_sReference + "\r\n");

                }

                MainFile.Close();

            }
            else if (lbl_Attacker_Wins.Text == "1")
            {

                StreamWriter MainFile = new StreamWriter(@"..\Data\" + ddl_Size.Text + "/Attacker_Advantage.txt");

                for (iCount = 0; iCount < MyMissions.m_MyMissions.Count; iCount++)
                {

                    MainFile.Write(MyMissions.m_MyMissions[iCount].m_sMission + "\r\n");
                    MainFile.Write(MyMissions.m_MyMissions[iCount].m_sReference + "\r\n");

                }

                MainFile.Close();

            }
            else if (lbl_Attacker_Wins.Text == "2")
            {

                StreamWriter MainFile = new StreamWriter(@"..\Data\" + ddl_Size.Text + "/No_Advantage.txt");

                for (iCount = 0; iCount < MyMissions.m_MyMissions.Count; iCount++)
                {

                    MainFile.Write(MyMissions.m_MyMissions[iCount].m_sMission + "\r\n");
                    MainFile.Write(MyMissions.m_MyMissions[iCount].m_sReference + "\r\n");

                }

                MainFile.Close();

            }
            else
            {

                Error_Message();

            }

        }

        private List<Missions> Download_Complete_Missions()
        {

            List<Missions> MyMissions = new List<Missions>();

            if (lbl_Attacker_Wins.Text == "0")
            {

                using (StreamReader sr = new StreamReader(@"..\Data\" + ddl_Size.Text + "/Played/Defender_Advantage.txt"))
                {

                    string sline;
                    string[] NextMission = new string[2];

                    while ((sline = sr.ReadLine()) != null)
                    {

                        MyMissions.Add(new Missions { m_sMission = sline, m_sReference = sr.ReadLine() });

                    }

                }

            }
            else if (lbl_Attacker_Wins.Text == "1")
            {

                using (StreamReader sr = new StreamReader(@"..\Data\" + ddl_Size.Text + "/Played/Attacker_Advantage.txt"))
                {

                    string sline;
                    string[] NextMission = new string[2];

                    while ((sline = sr.ReadLine()) != null)
                    {

                        MyMissions.Add(new Missions { m_sMission = sline, m_sReference = sr.ReadLine() });

                    }

                }

            }
            else if (lbl_Attacker_Wins.Text == "2")
            {

                using (StreamReader sr = new StreamReader(@"..\Data\" + ddl_Size.Text + "/Played/No_Advantage.txt"))
                {

                    string sline;
                    string[] NextMission = new string[2];

                    while ((sline = sr.ReadLine()) != null)
                    {

                        MyMissions.Add(new Missions { m_sMission = sline, m_sReference = sr.ReadLine() });

                    }
                }

            }
            else
            {

                Error_Message();

            }

            return MyMissions;

        }

        private List<Missions> Download_Next_Missions()
        {

            List<Missions> MyMissions = new List<Missions>();

            if (lbl_Attacker_Wins.Text == "0")
            {

                using (StreamReader sr = new StreamReader(@"..\Data\" + ddl_Size.Text + "/Defender_Advantage.txt"))
                {

                    string sline;

                    while ((sline = sr.ReadLine()) != null)
                    {

                        MyMissions.Add(new Missions { m_sMission = sline, m_sReference = sr.ReadLine() });

                    }

                }

                if (MyMissions.Count == 0)
                {

                    string sline;

                    using (StreamReader sr2 = new StreamReader(@"..\Data\" + ddl_Size.Text + "/Played/Defender_Advantage.txt"))
                    {

                        while ((sline = sr2.ReadLine()) != null)
                        {

                            MyMissions.Add(new Missions { m_sMission = sline, m_sReference = sr2.ReadLine() });

                        }

                    }

                    File.WriteAllText(@"..\Data\" + ddl_Size.Text + "/Played/Defender_Advantage.txt", String.Empty);
                    File.WriteAllText(@"..\Data\" + ddl_Size.Text + "/Defender_Advantage.txt", String.Empty);

                    StreamWriter MainFile = new StreamWriter(@"..\Data\" + ddl_Size.Text + "/Defender_Advantage.txt");

                    for (int iCount = 0; iCount < MyMissions.Count; iCount++)
                    {

                        MainFile.Write(MyMissions[iCount].m_sMission + "\r\n");
                        MainFile.Write(MyMissions[iCount].m_sReference + "\r\n");

                    }

                    MainFile.Close();

                }

            }
            else if (lbl_Attacker_Wins.Text == "1")
            {

                using (StreamReader sr = new StreamReader(@"..\Data\" + ddl_Size.Text + "/Attacker_Advantage.txt"))
                {

                    string sline;

                    while ((sline = sr.ReadLine()) != null)
                    {

                        MyMissions.Add(new Missions { m_sMission = sline, m_sReference = sr.ReadLine() });

                    }

                }

                if (MyMissions.Count == 0)
                {

                    string sline;

                    using (StreamReader sr2 = new StreamReader(@"..\Data\" + ddl_Size.Text + "/Played/Attacker_Advantage.txt"))
                    {

                        while ((sline = sr2.ReadLine()) != null)
                        {

                            MyMissions.Add(new Missions { m_sMission = sline, m_sReference = sr2.ReadLine() });

                        }

                    }

                    File.WriteAllText(@"..\Data\" + ddl_Size.Text + "/Played/Attacker_Advantage.txt", String.Empty);
                    File.WriteAllText(@"..\Data\" + ddl_Size.Text + "/Attacker_Advantage.txt", String.Empty);

                    StreamWriter MainFile = new StreamWriter(@"..\Data\" + ddl_Size.Text + "/Attacker_Advantage.txt");

                    for (int iCount = 0; iCount < MyMissions.Count; iCount++)
                    {

                        MainFile.Write(MyMissions[iCount].m_sMission + "\r\n");
                        MainFile.Write(MyMissions[iCount].m_sReference + "\r\n");

                    }

                    MainFile.Close();

                }

            }
            else if (lbl_Attacker_Wins.Text == "2")
            {

                using (StreamReader sr = new StreamReader(@"..\Data\" + ddl_Size.Text + "/No_Advantage.txt"))
                {

                    string sline;

                    while ((sline = sr.ReadLine()) != null)
                    {

                        MyMissions.Add(new Missions { m_sMission = sline, m_sReference = sr.ReadLine() });

                    }

                }

                if (MyMissions.Count == 0)
                {

                    string sline;

                    using (StreamReader sr2 = new StreamReader(@"..\Data\" + ddl_Size.Text + "/Played/No_Advantage.txt"))
                    {

                        while ((sline = sr2.ReadLine()) != null)
                        {

                            MyMissions.Add(new Missions { m_sMission = sline, m_sReference = sr2.ReadLine() });

                        }

                    }

                    File.WriteAllText(@"..\Data\" + ddl_Size.Text + "/Played/No_Advantage.txt", String.Empty);
                    File.WriteAllText(@"..\Data\" + ddl_Size.Text + "/No_Advantage.txt", String.Empty);

                    StreamWriter MainFile = new StreamWriter(@"..\Data\" + ddl_Size.Text + "/No_Advantage.txt");

                    for (int iCount = 0; iCount < MyMissions.Count; iCount++)
                    {

                        MainFile.Write(MyMissions[iCount].m_sMission + "\r\n");
                        MainFile.Write(MyMissions[iCount].m_sReference + "\r\n");

                    }

                    MainFile.Close();

                }

            }
            else
            {

                Error_Message();

            }

            return MyMissions;

        }

        private string[] Download_Names()
        {

            int iCount = 0;
            string[] sPlayers = new string[2];

            using (StreamReader sr = new StreamReader(@"..\Data\Players.txt"))
            {

                for (iCount = 0; iCount < 2; iCount++)
                {

                    sPlayers[iCount] = sr.ReadLine();

                }

            }

            return sPlayers;

        }

        private void frm_Main_Load(object sender, EventArgs e)
        {

            btn_Activation.Enabled = true;
            btn_Activation.Visible = true;
            btn_Activation.Text = "Begin";

            //btn_Settings.Visible = true;
            //btn_Settings.Enabled = true;

            btn_Close.Visible = true;
            btn_Close.Enabled = true;

            string[] sPlayers = Download_Names();

            lbl_Name1.Text = sPlayers[0];
            lbl_Name2.Text = sPlayers[1];

            btn_Submit.Location = new Point(215, 301);

        }

        private void btn_Activation_Click(object sender, EventArgs e)
        {

            if (btn_Activation.Text == "Begin")
            {

                btn_Activation.Text = "Reset";

                lbl_Selector.Text = "What game size are you playing?";
                lbl_Selector.Visible = true;

                ddl_Size.Visible = true;
                ddl_Size.Enabled = true;
                ddl_Size.Location = new Point(171, 247);
                ddl_Size.SelectedIndex = 0;

                btn_Submit.Text = "Confirm";
                btn_Submit.Visible = true;
                btn_Submit.Enabled = true;

            }
            else if (btn_Activation.Text == "Reset")
            {

                btn_Activation.Text = "Begin";
                btn_Submit.Location = new Point(215, 301);
                btn_Submit.Size = new Size(109, 45);

                lbl_Selector.Visible = false;

                ddl_Size.Visible = false;
                ddl_Size.Enabled = false;

                btn_Selection_1.Visible = false;
                btn_Selection_1.Enabled = false;

                btn_Selection_2.Visible = false;
                btn_Selection_2.Enabled = false;

                btn_Selection_3.Visible = false;
                btn_Selection_3.Enabled = false;

                btn_Submit.Visible = false;
                btn_Submit.Enabled = false;

                lbl_Mission.Visible = false;
                lbl_Mission_Reference.Visible = false;
                lbl_Result.Visible = false;
                lbl_PlayerMessage.Visible = false;

                lbl_Tracker.Text = "0";

            }
            else
            {

                Error_Message();

            }

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {

            StreamWriter File = new StreamWriter(@"..\Data\Test.txt");

            File.Write("1");
            File.Write("2" + "\r\n");
            File.Write("3" + "\r\n");
            File.Write("4" + ".\r\n\r\n");
            File.Close();

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

            if (lbl_Tracker.Text == "0")
            {

                lbl_Tracker.Text = "1";

                ddl_Size.Visible = false;
                ddl_Size.Enabled = false;

                btn_Submit.Visible = false;
                btn_Submit.Enabled = false;

                lbl_Selector.Text = lbl_Name1.Text + " are you the...?";

                btn_Selection_1.Visible = true;
                btn_Selection_1.Enabled = true;
                btn_Selection_1.Location = new Point(145, 247);
                btn_Selection_1.Text = "Defender";

                btn_Selection_2.Visible = true;
                btn_Selection_2.Enabled = true;
                btn_Selection_2.Location = new Point(276, 247);
                btn_Selection_2.Text = "Attacker";

            }
            else if (lbl_Tracker.Text == "4")
            {

                lbl_Tracker.Text = "5";

                lbl_Result.Visible = true;
                lbl_Result.Location = new Point(55, 209);

                btn_Submit.Location = new Point(203, 247);
                btn_Submit.Size = new Size(136, 45);
                btn_Submit.Text = "Generate";

                if ((lbl_Player1_Selection.Text == "0" && lbl_Player2_Selection.Text == "1") || (lbl_Player1_Selection.Text == "1" && lbl_Player2_Selection.Text == "2") || (lbl_Player1_Selection.Text == "2" && lbl_Player2_Selection.Text == "0"))
                {

                    lbl_Result.Text = lbl_Name1.Text + " has out maneuvered " + lbl_Name2.Text + "...";

                    if (lbl_IsAttacker.Text == "1")
                    {

                        lbl_Attacker_Wins.Text = "1";

                    }
                    else if (lbl_IsAttacker.Text == "0")
                    {

                        lbl_Attacker_Wins.Text = "0";

                    }
                    else
                    {

                        Error_Message();

                    }
                    
                }
                else if ((lbl_Player1_Selection.Text == "0" && lbl_Player2_Selection.Text == "2") || (lbl_Player1_Selection.Text == "1" && lbl_Player2_Selection.Text == "0") || (lbl_Player1_Selection.Text == "2" && lbl_Player2_Selection.Text == "1"))
                {

                    lbl_Result.Text = lbl_Name2.Text + " has out maneuvered " + lbl_Name1.Text + "...";
                    if (lbl_IsAttacker.Text == "0")
                    {

                        lbl_Attacker_Wins.Text = "1";

                    }
                    else if (lbl_IsAttacker.Text == "1")
                    {

                        lbl_Attacker_Wins.Text = "1";

                    }
                    else 
                    {

                        Error_Message();
                    
                    }

                }
                else if ((lbl_Player1_Selection.Text == "0" && lbl_Player2_Selection.Text == "0") || (lbl_Player1_Selection.Text == "1" && lbl_Player2_Selection.Text == "1") || (lbl_Player1_Selection.Text == "2" && lbl_Player2_Selection.Text == "2"))
                {

                    lbl_Result.Location = new Point(25, 211);
                    lbl_Result.Text = "Neither forces are out maneuvered, a might clash will commence...";
                    lbl_Attacker_Wins.Text = "2";

                }
                else
                {

                    Error_Message();

                }

            }
            else if (lbl_Tracker.Text == "5")
            {

                Random rnd = new Random();

                btn_Submit.Location = new Point(215, 359);
                btn_Submit.Text =  "Played";

                lbl_Result.Visible = false;

                MyMissions.m_MyMissions = Download_Next_Missions();
                MyMissions.m_iSelected = rnd.Next(0, MyMissions.m_MyMissions.Count);

                lbl_Mission.Text = MyMissions.m_MyMissions[MyMissions.m_iSelected].m_sMission;
                lbl_Mission_Reference.Text = MyMissions.m_MyMissions[MyMissions.m_iSelected].m_sReference;

                lbl_Mission.Visible = true;
                lbl_Mission_Reference.Visible = true;
                lbl_Tracker.Text = "6";

            }
            else if (lbl_Tracker.Text == "6")
            {

                Save_Complete_Missions();
                Save_Next_Missions();

                btn_Submit.Visible = false;
                lbl_Mission_Reference.Visible = false;
                lbl_Mission.Text = "Missions have been rotated!";

            }
            else
            {

                Error_Message();

            }

        }

        private void btn_Selection_1_Click(object sender, EventArgs e)
        {

            if (lbl_Tracker.Text == "1")
            {


                lbl_IsAttacker.Text = "0";
                Set_After_Attack_Selection();

            }
            else if (lbl_Tracker.Text == "2")
            {

                lbl_Player1_Selection.Text = "0";
                Set_After_First_Maneuver();

            }
            else if (lbl_Tracker.Text == "3")
            {

                lbl_Player2_Selection.Text = "0";
                Set_After_Second_Maneuver();

            }
            else
            {

                Error_Message();

            }

        }

        private void btn_Selection_2_Click(object sender, EventArgs e)
        {

            if (lbl_Tracker.Text == "1")
            {


                lbl_IsAttacker.Text = "1";
                Set_After_Attack_Selection();

            }
            else if (lbl_Tracker.Text == "2")
            {

                lbl_Player1_Selection.Text = "2";
                Set_After_First_Maneuver();

            }
            else if (lbl_Tracker.Text == "3")
            {

                lbl_Player2_Selection.Text = "2";
                Set_After_Second_Maneuver();

            }
            else
            {

                Error_Message();

            }

        }

        private void btn_Selection_3_Click(object sender, EventArgs e)
        {

            if (lbl_Tracker.Text == "2")
            {

                lbl_Player1_Selection.Text = "1";
                Set_After_First_Maneuver();

            }
            else if (lbl_Tracker.Text == "3")
            {

                lbl_Player2_Selection.Text = "1";
                Set_After_Second_Maneuver();

            }
            else
            {

                Error_Message();

            }


        }
    }
}
