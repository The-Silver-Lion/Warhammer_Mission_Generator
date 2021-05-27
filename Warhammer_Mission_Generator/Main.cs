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
        public frm_Main()
        {
            InitializeComponent();
        }

        void Error_Message()
        {

            MessageBox.Show("An error has occured! Please Try agin...");

        }

        string[] Download_Names()
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
                lbl_Result.Visible = false; 

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
    }
}
