namespace Anketa
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
            FIOTB = new TextBox();
            MNTB = new TextBox();
            HNTB = new TextBox();
            WPTB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            MGRB = new RadioButton();
            FGRB = new RadioButton();
            REGB = new Button();
            MNCHB = new CheckBox();
            HNCHB = new CheckBox();
            WPCHB = new CheckBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // FIOTB
            // 
            FIOTB.Location = new Point(81, 27);
            FIOTB.Name = "FIOTB";
            FIOTB.Size = new Size(158, 23);
            FIOTB.TabIndex = 0;
            // 
            // MNTB
            // 
            MNTB.Location = new Point(139, 65);
            MNTB.Name = "MNTB";
            MNTB.Size = new Size(100, 23);
            MNTB.TabIndex = 1;
            // 
            // HNTB
            // 
            HNTB.Location = new Point(139, 106);
            HNTB.Name = "HNTB";
            HNTB.Size = new Size(100, 23);
            HNTB.TabIndex = 2;
            // 
            // WPTB
            // 
            WPTB.Location = new Point(139, 147);
            WPTB.Name = "WPTB";
            WPTB.Size = new Size(100, 23);
            WPTB.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 27);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 4;
            label1.Text = "ФИО";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 68);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 5;
            label2.Text = "Мобильный номер";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 109);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 6;
            label3.Text = "Домашний номер";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 147);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 7;
            label4.Text = "Место работы";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 186);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 8;
            label5.Text = "Пол";
            // 
            // MGRB
            // 
            MGRB.AutoSize = true;
            MGRB.Location = new Point(139, 182);
            MGRB.Name = "MGRB";
            MGRB.Size = new Size(51, 19);
            MGRB.TabIndex = 9;
            MGRB.TabStop = true;
            MGRB.Text = "Муж";
            MGRB.UseVisualStyleBackColor = true;
            // 
            // FGRB
            // 
            FGRB.AutoSize = true;
            FGRB.Location = new Point(139, 207);
            FGRB.Name = "FGRB";
            FGRB.Size = new Size(49, 19);
            FGRB.TabIndex = 10;
            FGRB.TabStop = true;
            FGRB.Text = "Жен";
            FGRB.UseVisualStyleBackColor = true;
            // 
            // REGB
            // 
            REGB.Font = new Font("Segoe UI", 20F);
            REGB.Location = new Point(19, 232);
            REGB.Name = "REGB";
            REGB.Size = new Size(220, 47);
            REGB.TabIndex = 11;
            REGB.Text = "ЗАРЕГАТЬ";
            REGB.UseVisualStyleBackColor = true;
            REGB.Click += REGB_Click;
            // 
            // MNCHB
            // 
            MNCHB.AutoSize = true;
            MNCHB.Location = new Point(245, 67);
            MNCHB.Name = "MNCHB";
            MNCHB.Size = new Size(83, 19);
            MNCHB.TabIndex = 12;
            MNCHB.Text = "checkBox1";
            MNCHB.UseVisualStyleBackColor = true;
            MNCHB.CheckedChanged += MNCHB_CheckedChanged;
            // 
            // HNCHB
            // 
            HNCHB.AutoSize = true;
            HNCHB.Location = new Point(245, 109);
            HNCHB.Name = "HNCHB";
            HNCHB.Size = new Size(83, 19);
            HNCHB.TabIndex = 13;
            HNCHB.Text = "checkBox2";
            HNCHB.UseVisualStyleBackColor = true;
            HNCHB.CheckedChanged += HNCHB_CheckedChanged;
            // 
            // WPCHB
            // 
            WPCHB.AutoSize = true;
            WPCHB.Location = new Point(245, 149);
            WPCHB.Name = "WPCHB";
            WPCHB.Size = new Size(83, 19);
            WPCHB.TabIndex = 14;
            WPCHB.Text = "checkBox3";
            WPCHB.UseVisualStyleBackColor = true;
            WPCHB.CheckedChanged += WPCHB_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(153, 68);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 15;
            label6.Text = "не указано";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(153, 110);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 16;
            label7.Text = "не указано";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(153, 150);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 17;
            label8.Text = "не указано";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 291);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(WPCHB);
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
            Controls.Add(WPTB);
            Controls.Add(HNTB);
            Controls.Add(MNTB);
            Controls.Add(FIOTB);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FIOTB;
        private TextBox MNTB;
        private TextBox HNTB;
        private TextBox WPTB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RadioButton MGRB;
        private RadioButton FGRB;
        private Button REGB;
        private CheckBox MNCHB;
        private CheckBox HNCHB;
        private CheckBox WPCHB;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
