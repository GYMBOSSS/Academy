﻿namespace Anketa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            FIOTB = new TextBox();
            MNTB = new TextBox();
            HNTB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            MGRB = new RadioButton();
            FGRB = new RadioButton();
            REGB = new Button();
            MNCHB = new CheckBox();
            HNCHB = new CheckBox();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            Registration = new Button();
            Enter = new Button();
            label8 = new Label();
            PWTB = new TextBox();
            EnterMenu = new ContextMenuStrip(components);
            toolStripTextBox1 = new ToolStripTextBox();
            EnterMenu2 = new ContextMenuStrip(components);
            toolStripTextBox2 = new ToolStripTextBox();
            PWenter = new TextBox();
            Enter2 = new Button();
            WPCB = new ComboBox();
            EnterCB = new ComboBox();
            EnterMenu.SuspendLayout();
            EnterMenu2.SuspendLayout();
            SuspendLayout();
            // 
            // FIOTB
            // 
            FIOTB.Location = new Point(81, 17);
            FIOTB.Name = "FIOTB";
            FIOTB.Size = new Size(158, 23);
            FIOTB.TabIndex = 0;
            FIOTB.Visible = false;
            // 
            // MNTB
            // 
            MNTB.Location = new Point(139, 129);
            MNTB.Name = "MNTB";
            MNTB.Size = new Size(100, 23);
            MNTB.TabIndex = 1;
            MNTB.Visible = false;
            // 
            // HNTB
            // 
            HNTB.Location = new Point(139, 96);
            HNTB.Name = "HNTB";
            HNTB.Size = new Size(100, 23);
            HNTB.TabIndex = 2;
            HNTB.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 17);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 4;
            label1.Text = "ФИО";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 132);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 5;
            label2.Text = "Мобильный номер";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 99);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 6;
            label3.Text = "Домашний номер";
            label3.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 176);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 8;
            label5.Text = "Пол";
            label5.Visible = false;
            // 
            // MGRB
            // 
            MGRB.AutoSize = true;
            MGRB.Location = new Point(139, 172);
            MGRB.Name = "MGRB";
            MGRB.Size = new Size(51, 19);
            MGRB.TabIndex = 9;
            MGRB.TabStop = true;
            MGRB.Text = "Муж";
            MGRB.UseVisualStyleBackColor = true;
            MGRB.Visible = false;
            // 
            // FGRB
            // 
            FGRB.AutoSize = true;
            FGRB.Location = new Point(201, 172);
            FGRB.Name = "FGRB";
            FGRB.Size = new Size(49, 19);
            FGRB.TabIndex = 10;
            FGRB.TabStop = true;
            FGRB.Text = "Жен";
            FGRB.UseVisualStyleBackColor = true;
            FGRB.Visible = false;
            // 
            // REGB
            // 
            REGB.Font = new Font("Segoe UI", 20F);
            REGB.Location = new Point(19, 234);
            REGB.Name = "REGB";
            REGB.Size = new Size(220, 47);
            REGB.TabIndex = 11;
            REGB.Text = "ЗАРЕГАТЬ";
            REGB.UseVisualStyleBackColor = true;
            REGB.Visible = false;
            REGB.Click += REGB_Click;
            // 
            // MNCHB
            // 
            MNCHB.AutoSize = true;
            MNCHB.Location = new Point(245, 131);
            MNCHB.Name = "MNCHB";
            MNCHB.Size = new Size(15, 14);
            MNCHB.TabIndex = 12;
            MNCHB.UseVisualStyleBackColor = true;
            MNCHB.Visible = false;
            MNCHB.CheckedChanged += MNCHB_CheckedChanged;
            // 
            // HNCHB
            // 
            HNCHB.AutoSize = true;
            HNCHB.Location = new Point(245, 99);
            HNCHB.Name = "HNCHB";
            HNCHB.Size = new Size(15, 14);
            HNCHB.TabIndex = 13;
            HNCHB.UseVisualStyleBackColor = true;
            HNCHB.Visible = false;
            HNCHB.CheckedChanged += HNCHB_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(153, 132);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 15;
            label6.Text = "не указано";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(153, 100);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 16;
            label7.Text = "не указано";
            label7.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 70);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 7;
            label4.Text = "Место работы";
            label4.Visible = false;
            // 
            // Registration
            // 
            Registration.Font = new Font("Segoe UI", 16F);
            Registration.Location = new Point(322, 132);
            Registration.Name = "Registration";
            Registration.Size = new Size(167, 93);
            Registration.TabIndex = 17;
            Registration.Text = "Пройти регистрацию";
            Registration.UseVisualStyleBackColor = true;
            Registration.Click += Registration_Click;
            // 
            // Enter
            // 
            Enter.Font = new Font("Segoe UI", 16F);
            Enter.Location = new Point(322, 20);
            Enter.Name = "Enter";
            Enter.Size = new Size(167, 76);
            Enter.TabIndex = 18;
            Enter.Text = "Войти";
            Enter.UseVisualStyleBackColor = true;
            Enter.Click += Enter_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 209);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 19;
            label8.Text = "Пароль";
            label8.Visible = false;
            // 
            // PWTB
            // 
            PWTB.Location = new Point(139, 205);
            PWTB.Name = "PWTB";
            PWTB.Size = new Size(100, 23);
            PWTB.TabIndex = 20;
            PWTB.Visible = false;
            // 
            // EnterMenu
            // 
            EnterMenu.Items.AddRange(new ToolStripItem[] { toolStripTextBox1 });
            EnterMenu.Name = "contextMenuStrip1";
            EnterMenu.Size = new Size(161, 29);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 23);
            // 
            // EnterMenu2
            // 
            EnterMenu2.Items.AddRange(new ToolStripItem[] { toolStripTextBox2 });
            EnterMenu2.Name = "EnterMenu2";
            EnterMenu2.Size = new Size(161, 29);
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(100, 23);
            // 
            // PWenter
            // 
            PWenter.Location = new Point(337, 185);
            PWenter.Name = "PWenter";
            PWenter.Size = new Size(134, 23);
            PWenter.TabIndex = 22;
            PWenter.Visible = false;
            // 
            // Enter2
            // 
            Enter2.Font = new Font("Segoe UI", 16F);
            Enter2.Location = new Point(322, 20);
            Enter2.Name = "Enter2";
            Enter2.Size = new Size(167, 76);
            Enter2.TabIndex = 23;
            Enter2.Text = "Войти";
            Enter2.UseVisualStyleBackColor = true;
            Enter2.Visible = false;
            Enter2.Click += Enter2_Click;
            // 
            // WPCB
            // 
            WPCB.FormattingEnabled = true;
            WPCB.Items.AddRange(new object[] { "пограмист", "не пограмист" });
            WPCB.Location = new Point(139, 62);
            WPCB.Name = "WPCB";
            WPCB.Size = new Size(121, 23);
            WPCB.TabIndex = 24;
            WPCB.Visible = false;
            // 
            // EnterCB
            // 
            EnterCB.FormattingEnabled = true;
            EnterCB.Location = new Point(337, 144);
            EnterCB.Name = "EnterCB";
            EnterCB.Size = new Size(134, 23);
            EnterCB.TabIndex = 25;
            EnterCB.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 283);
            Controls.Add(EnterCB);
            Controls.Add(WPCB);
            Controls.Add(Enter2);
            Controls.Add(PWenter);
            Controls.Add(PWTB);
            Controls.Add(label8);
            Controls.Add(Enter);
            Controls.Add(Registration);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(HNCHB);
            Controls.Add(MNCHB);
            Controls.Add(REGB);
            Controls.Add(FGRB);
            Controls.Add(MGRB);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(HNTB);
            Controls.Add(MNTB);
            Controls.Add(FIOTB);
            Name = "Form1";
            Text = "Form1";
            EnterMenu.ResumeLayout(false);
            EnterMenu.PerformLayout();
            EnterMenu2.ResumeLayout(false);
            EnterMenu2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FIOTB;
        private TextBox MNTB;
        private TextBox HNTB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private RadioButton MGRB;
        private RadioButton FGRB;
        private Button REGB;
        private CheckBox MNCHB;
        private CheckBox HNCHB;
        private Label label6;
        private Label label7;
        private Label label4;
        private Button Registration;
        private Button Enter;
        private Label label8;
        private TextBox PWTB;
        private ContextMenuStrip EnterMenu;
        private ToolStripTextBox toolStripTextBox1;
        private ContextMenuStrip EnterMenu2;
        private ToolStripTextBox toolStripTextBox2;
        private TextBox PWenter;
        private Button Enter2;
        private ComboBox WPCB;
        private ComboBox EnterCB;
    }
}
