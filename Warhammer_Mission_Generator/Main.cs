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

        private void frm_Main_Load(object sender, EventArgs e)
        {

            btn_Activation.Enabled = true;
            btn_Activation.Visible = true;
            btn_Activation.Text = "Begin";

            //btn_Settings.Visible = true;
            //btn_Settings.Enabled = true;

            btn_Close.Visible = true;
            btn_Close.Enabled = true;

            int iCount = 0;
            string[] sPlayers = new string[2];

            using (StreamReader sr = new StreamReader(@"..\Data\Players.txt"))
            {

                for (iCount = 0; iCount < 2; iCount++)
                {

                    sPlayers[iCount] = sr.ReadLine();

                }

            }

            lbl_Name1.Text = sPlayers[0];
            lbl_Name2.Text = sPlayers[1];

        }

        private void btn_Activation_Click(object sender, EventArgs e)
        {

            

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
