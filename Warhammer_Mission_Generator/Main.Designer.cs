
namespace Warhammer_Mission_Generator
{
    partial class frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Activation = new System.Windows.Forms.Button();
            this.lbl_Player1 = new System.Windows.Forms.Label();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.lbl_Name1 = new System.Windows.Forms.Label();
            this.lbl_Name2 = new System.Windows.Forms.Label();
            this.lbl_Player2 = new System.Windows.Forms.Label();
            this.lbl_IsAttacker = new System.Windows.Forms.Label();
            this.btn_Selection1 = new System.Windows.Forms.Button();
            this.btn_Selection_2 = new System.Windows.Forms.Button();
            this.lbl_Tracker = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_Mission = new System.Windows.Forms.Label();
            this.lbl_Steal = new System.Windows.Forms.Label();
            this.btn_Selection_3 = new System.Windows.Forms.Button();
            this.btn_Player1_Selection = new System.Windows.Forms.Label();
            this.lbl_Player_2_Selection = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.ddl_Size = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(66, 18);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(433, 38);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Warhammer Mission Generator";
            // 
            // btn_Activation
            // 
            this.btn_Activation.BackColor = System.Drawing.Color.Ivory;
            this.btn_Activation.Enabled = false;
            this.btn_Activation.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Activation.Location = new System.Drawing.Point(215, 71);
            this.btn_Activation.Name = "btn_Activation";
            this.btn_Activation.Size = new System.Drawing.Size(109, 45);
            this.btn_Activation.TabIndex = 1;
            this.btn_Activation.Text = "*TEXT*";
            this.btn_Activation.UseVisualStyleBackColor = false;
            this.btn_Activation.Visible = false;
            this.btn_Activation.Click += new System.EventHandler(this.btn_Activation_Click);
            // 
            // lbl_Player1
            // 
            this.lbl_Player1.AutoSize = true;
            this.lbl_Player1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Player1.Location = new System.Drawing.Point(55, 131);
            this.lbl_Player1.Name = "lbl_Player1";
            this.lbl_Player1.Size = new System.Drawing.Size(74, 19);
            this.lbl_Player1.TabIndex = 2;
            this.lbl_Player1.Text = "Player 1:";
            // 
            // btn_Settings
            // 
            this.btn_Settings.BackColor = System.Drawing.Color.Ivory;
            this.btn_Settings.Enabled = false;
            this.btn_Settings.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Settings.Location = new System.Drawing.Point(12, 481);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(94, 31);
            this.btn_Settings.TabIndex = 3;
            this.btn_Settings.Text = "Settings";
            this.btn_Settings.UseVisualStyleBackColor = false;
            // 
            // lbl_Name1
            // 
            this.lbl_Name1.AutoSize = true;
            this.lbl_Name1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name1.Location = new System.Drawing.Point(135, 131);
            this.lbl_Name1.Name = "lbl_Name1";
            this.lbl_Name1.Size = new System.Drawing.Size(81, 19);
            this.lbl_Name1.TabIndex = 4;
            this.lbl_Name1.Text = "*Player1*";
            // 
            // lbl_Name2
            // 
            this.lbl_Name2.AutoSize = true;
            this.lbl_Name2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name2.Location = new System.Drawing.Point(135, 165);
            this.lbl_Name2.Name = "lbl_Name2";
            this.lbl_Name2.Size = new System.Drawing.Size(81, 19);
            this.lbl_Name2.TabIndex = 6;
            this.lbl_Name2.Text = "*Player2*";
            // 
            // lbl_Player2
            // 
            this.lbl_Player2.AutoSize = true;
            this.lbl_Player2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Player2.Location = new System.Drawing.Point(55, 165);
            this.lbl_Player2.Name = "lbl_Player2";
            this.lbl_Player2.Size = new System.Drawing.Size(74, 19);
            this.lbl_Player2.TabIndex = 5;
            this.lbl_Player2.Text = "Player 2:";
            // 
            // lbl_IsAttacker
            // 
            this.lbl_IsAttacker.AutoSize = true;
            this.lbl_IsAttacker.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IsAttacker.Location = new System.Drawing.Point(55, 202);
            this.lbl_IsAttacker.Name = "lbl_IsAttacker";
            this.lbl_IsAttacker.Size = new System.Drawing.Size(139, 19);
            this.lbl_IsAttacker.TabIndex = 7;
            this.lbl_IsAttacker.Text = "*PLAYER1* is the:";
            this.lbl_IsAttacker.Visible = false;
            // 
            // btn_Selection1
            // 
            this.btn_Selection1.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_Selection1.Enabled = false;
            this.btn_Selection1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Selection1.Location = new System.Drawing.Point(167, 247);
            this.btn_Selection1.Name = "btn_Selection1";
            this.btn_Selection1.Size = new System.Drawing.Size(104, 36);
            this.btn_Selection1.TabIndex = 8;
            this.btn_Selection1.Text = "*TEXT*";
            this.btn_Selection1.UseVisualStyleBackColor = false;
            this.btn_Selection1.Visible = false;
            // 
            // btn_Selection_2
            // 
            this.btn_Selection_2.BackColor = System.Drawing.Color.Red;
            this.btn_Selection_2.Enabled = false;
            this.btn_Selection_2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Selection_2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Selection_2.Location = new System.Drawing.Point(277, 247);
            this.btn_Selection_2.Name = "btn_Selection_2";
            this.btn_Selection_2.Size = new System.Drawing.Size(104, 36);
            this.btn_Selection_2.TabIndex = 9;
            this.btn_Selection_2.Text = "*TEXT*";
            this.btn_Selection_2.UseVisualStyleBackColor = false;
            this.btn_Selection_2.Visible = false;
            // 
            // lbl_Tracker
            // 
            this.lbl_Tracker.AutoSize = true;
            this.lbl_Tracker.Location = new System.Drawing.Point(36, 260);
            this.lbl_Tracker.Name = "lbl_Tracker";
            this.lbl_Tracker.Size = new System.Drawing.Size(13, 13);
            this.lbl_Tracker.TabIndex = 10;
            this.lbl_Tracker.Text = "2";
            this.lbl_Tracker.Visible = false;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.Ivory;
            this.btn_Submit.Enabled = false;
            this.btn_Submit.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(215, 301);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(119, 45);
            this.btn_Submit.TabIndex = 11;
            this.btn_Submit.Text = "*TEXT*";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Visible = false;
            // 
            // lbl_Mission
            // 
            this.lbl_Mission.AutoSize = true;
            this.lbl_Mission.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mission.Location = new System.Drawing.Point(55, 394);
            this.lbl_Mission.Name = "lbl_Mission";
            this.lbl_Mission.Size = new System.Drawing.Size(151, 31);
            this.lbl_Mission.TabIndex = 12;
            this.lbl_Mission.Text = "*MISSION*";
            this.lbl_Mission.Visible = false;
            // 
            // lbl_Steal
            // 
            this.lbl_Steal.AutoSize = true;
            this.lbl_Steal.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Steal.Location = new System.Drawing.Point(55, 440);
            this.lbl_Steal.Name = "lbl_Steal";
            this.lbl_Steal.Size = new System.Drawing.Size(78, 23);
            this.lbl_Steal.TabIndex = 13;
            this.lbl_Steal.Text = "*Steal*";
            this.lbl_Steal.Visible = false;
            // 
            // btn_Selection_3
            // 
            this.btn_Selection_3.BackColor = System.Drawing.Color.Orange;
            this.btn_Selection_3.Enabled = false;
            this.btn_Selection_3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Selection_3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Selection_3.Location = new System.Drawing.Point(423, 247);
            this.btn_Selection_3.Name = "btn_Selection_3";
            this.btn_Selection_3.Size = new System.Drawing.Size(104, 36);
            this.btn_Selection_3.TabIndex = 14;
            this.btn_Selection_3.Text = "*TEXT*";
            this.btn_Selection_3.UseVisualStyleBackColor = false;
            this.btn_Selection_3.Visible = false;
            // 
            // btn_Player1_Selection
            // 
            this.btn_Player1_Selection.AutoSize = true;
            this.btn_Player1_Selection.Location = new System.Drawing.Point(36, 135);
            this.btn_Player1_Selection.Name = "btn_Player1_Selection";
            this.btn_Player1_Selection.Size = new System.Drawing.Size(13, 13);
            this.btn_Player1_Selection.TabIndex = 15;
            this.btn_Player1_Selection.Text = "0";
            this.btn_Player1_Selection.Visible = false;
            // 
            // lbl_Player_2_Selection
            // 
            this.lbl_Player_2_Selection.AutoSize = true;
            this.lbl_Player_2_Selection.Location = new System.Drawing.Point(36, 171);
            this.lbl_Player_2_Selection.Name = "lbl_Player_2_Selection";
            this.lbl_Player_2_Selection.Size = new System.Drawing.Size(13, 13);
            this.lbl_Player_2_Selection.TabIndex = 16;
            this.lbl_Player_2_Selection.Text = "0";
            this.lbl_Player_2_Selection.Visible = false;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Ivory;
            this.btn_Close.Enabled = false;
            this.btn_Close.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(451, 481);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(94, 31);
            this.btn_Close.TabIndex = 17;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // ddl_Size
            // 
            this.ddl_Size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_Size.Enabled = false;
            this.ddl_Size.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddl_Size.Items.AddRange(new object[] {
            "Combat Patrol",
            "Incursion",
            "Strike Force",
            "Onslaught"});
            this.ddl_Size.Location = new System.Drawing.Point(318, 202);
            this.ddl_Size.Name = "ddl_Size";
            this.ddl_Size.Size = new System.Drawing.Size(209, 35);
            this.ddl_Size.TabIndex = 18;
            this.ddl_Size.Visible = false;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(557, 520);
            this.Controls.Add(this.ddl_Size);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lbl_Player_2_Selection);
            this.Controls.Add(this.btn_Player1_Selection);
            this.Controls.Add(this.btn_Selection_3);
            this.Controls.Add(this.lbl_Steal);
            this.Controls.Add(this.lbl_Mission);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.lbl_Tracker);
            this.Controls.Add(this.btn_Selection_2);
            this.Controls.Add(this.btn_Selection1);
            this.Controls.Add(this.lbl_IsAttacker);
            this.Controls.Add(this.lbl_Name2);
            this.Controls.Add(this.lbl_Player2);
            this.Controls.Add(this.lbl_Name1);
            this.Controls.Add(this.btn_Settings);
            this.Controls.Add(this.lbl_Player1);
            this.Controls.Add(this.btn_Activation);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Activation;
        private System.Windows.Forms.Label lbl_Player1;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Label lbl_Name1;
        private System.Windows.Forms.Label lbl_Name2;
        private System.Windows.Forms.Label lbl_Player2;
        private System.Windows.Forms.Label lbl_IsAttacker;
        private System.Windows.Forms.Button btn_Selection1;
        private System.Windows.Forms.Button btn_Selection_2;
        private System.Windows.Forms.Label lbl_Tracker;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_Mission;
        private System.Windows.Forms.Label lbl_Steal;
        private System.Windows.Forms.Button btn_Selection_3;
        private System.Windows.Forms.Label btn_Player1_Selection;
        private System.Windows.Forms.Label lbl_Player_2_Selection;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.ComboBox ddl_Size;
    }
}