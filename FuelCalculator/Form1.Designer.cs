namespace FuelCalculator
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
            AutRegB = new Button();
            SchetB = new Button();
            name_tb = new TextBox();
            GasRB = new RadioButton();
            PetRB = new RadioButton();
            DiesRB = new RadioButton();
            GasCB = new ComboBox();
            PetCB = new ComboBox();
            DiesCB = new ComboBox();
            label1 = new Label();
            CarTypeCB = new ComboBox();
            FuelConsTB = new TextBox();
            AvgSpdTB = new TextBox();
            label2 = new Label();
            label3 = new Label();
            RegFB = new Button();
            BackB = new Button();
            SuspendLayout();
            // 
            // AutRegB
            // 
            AutRegB.Location = new Point(206, 25);
            AutRegB.Name = "AutRegB";
            AutRegB.Size = new Size(107, 99);
            AutRegB.TabIndex = 0;
            AutRegB.Text = "Зарегать авто";
            AutRegB.UseVisualStyleBackColor = true;
            AutRegB.Click += AutRegB_Click;
            // 
            // SchetB
            // 
            SchetB.Location = new Point(206, 137);
            SchetB.Name = "SchetB";
            SchetB.Size = new Size(107, 99);
            SchetB.TabIndex = 1;
            SchetB.Text = "Посчитать";
            SchetB.UseVisualStyleBackColor = true;
            SchetB.Click += SchetB_Click;
            // 
            // name_tb
            // 
            name_tb.Location = new Point(33, 25);
            name_tb.Name = "name_tb";
            name_tb.Size = new Size(150, 23);
            name_tb.TabIndex = 2;
            name_tb.Text = "Name";
            name_tb.Visible = false;
            // 
            // GasRB
            // 
            GasRB.AutoSize = true;
            GasRB.Location = new Point(12, 65);
            GasRB.Name = "GasRB";
            GasRB.Size = new Size(44, 19);
            GasRB.TabIndex = 3;
            GasRB.TabStop = true;
            GasRB.Text = "Gas";
            GasRB.UseVisualStyleBackColor = true;
            GasRB.Visible = false;
            GasRB.CheckedChanged += GasRB_CheckedChanged;
            // 
            // PetRB
            // 
            PetRB.AutoSize = true;
            PetRB.Location = new Point(12, 97);
            PetRB.Name = "PetRB";
            PetRB.Size = new Size(42, 19);
            PetRB.TabIndex = 4;
            PetRB.TabStop = true;
            PetRB.Text = "Pet";
            PetRB.UseVisualStyleBackColor = true;
            PetRB.Visible = false;
            PetRB.CheckedChanged += PetRB_CheckedChanged;
            // 
            // DiesRB
            // 
            DiesRB.AutoSize = true;
            DiesRB.Location = new Point(12, 126);
            DiesRB.Name = "DiesRB";
            DiesRB.Size = new Size(47, 19);
            DiesRB.TabIndex = 5;
            DiesRB.TabStop = true;
            DiesRB.Text = "Dies";
            DiesRB.UseVisualStyleBackColor = true;
            DiesRB.Visible = false;
            DiesRB.CheckedChanged += DiesRB_CheckedChanged;
            // 
            // GasCB
            // 
            GasCB.FormattingEnabled = true;
            GasCB.Items.AddRange(new object[] { "Metan", "Hydrogen" });
            GasCB.Location = new Point(62, 64);
            GasCB.Name = "GasCB";
            GasCB.Size = new Size(121, 23);
            GasCB.TabIndex = 6;
            GasCB.Visible = false;
            // 
            // PetCB
            // 
            PetCB.FormattingEnabled = true;
            PetCB.Items.AddRange(new object[] { "АИ-92", "АИ-95", "АИ-80" });
            PetCB.Location = new Point(62, 93);
            PetCB.Name = "PetCB";
            PetCB.Size = new Size(121, 23);
            PetCB.TabIndex = 7;
            PetCB.Visible = false;
            // 
            // DiesCB
            // 
            DiesCB.FormattingEnabled = true;
            DiesCB.Items.AddRange(new object[] { "Summer", "Winter" });
            DiesCB.Location = new Point(62, 122);
            DiesCB.Name = "DiesCB";
            DiesCB.Size = new Size(121, 23);
            DiesCB.TabIndex = 8;
            DiesCB.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 158);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 9;
            label1.Text = "Car type";
            label1.Visible = false;
            // 
            // CarTypeCB
            // 
            CarTypeCB.FormattingEnabled = true;
            CarTypeCB.Items.AddRange(new object[] { "Taxi", "Boss's car", "Petrol bus", "Petrol truck" });
            CarTypeCB.Location = new Point(69, 155);
            CarTypeCB.Name = "CarTypeCB";
            CarTypeCB.Size = new Size(114, 23);
            CarTypeCB.TabIndex = 10;
            CarTypeCB.Visible = false;
            // 
            // FuelConsTB
            // 
            FuelConsTB.Location = new Point(69, 184);
            FuelConsTB.Name = "FuelConsTB";
            FuelConsTB.Size = new Size(114, 23);
            FuelConsTB.TabIndex = 11;
            FuelConsTB.Visible = false;
            // 
            // AvgSpdTB
            // 
            AvgSpdTB.Location = new Point(69, 213);
            AvgSpdTB.Name = "AvgSpdTB";
            AvgSpdTB.Size = new Size(114, 23);
            AvgSpdTB.TabIndex = 12;
            AvgSpdTB.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 187);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 13;
            label2.Text = "Fuel cons";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 216);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 14;
            label3.Text = "Avg spd";
            label3.Visible = false;
            // 
            // RegFB
            // 
            RegFB.Location = new Point(206, 137);
            RegFB.Name = "RegFB";
            RegFB.Size = new Size(107, 41);
            RegFB.TabIndex = 15;
            RegFB.Text = "Запись в файл";
            RegFB.UseVisualStyleBackColor = true;
            RegFB.Visible = false;
            RegFB.Click += RegFB_Click;
            // 
            // BackB
            // 
            BackB.Location = new Point(206, 199);
            BackB.Name = "BackB";
            BackB.Size = new Size(107, 37);
            BackB.TabIndex = 16;
            BackB.Text = "Обратно";
            BackB.UseVisualStyleBackColor = true;
            BackB.Visible = false;
            BackB.Click += BackB_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 248);
            Controls.Add(BackB);
            Controls.Add(RegFB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(AvgSpdTB);
            Controls.Add(FuelConsTB);
            Controls.Add(CarTypeCB);
            Controls.Add(label1);
            Controls.Add(DiesCB);
            Controls.Add(PetCB);
            Controls.Add(GasCB);
            Controls.Add(DiesRB);
            Controls.Add(PetRB);
            Controls.Add(GasRB);
            Controls.Add(name_tb);
            Controls.Add(SchetB);
            Controls.Add(AutRegB);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AutRegB;
        private Button SchetB;
        private TextBox name_tb;
        private RadioButton GasRB;
        private RadioButton PetRB;
        private RadioButton DiesRB;
        private ComboBox GasCB;
        private ComboBox PetCB;
        private ComboBox DiesCB;
        private Label label1;
        private ComboBox CarTypeCB;
        private TextBox FuelConsTB;
        private TextBox AvgSpdTB;
        private Label label2;
        private Label label3;
        private Button RegFB;
        private Button BackB;
    }
}
