namespace Zadanie1
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
            BUBON = new Button();
            TB2 = new TextBox();
            TB1 = new TextBox();
            SUMBut = new Button();
            MULTButt = new Button();
            DIFButt = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // BUBON
            // 
            BUBON.Location = new Point(116, 115);
            BUBON.Name = "BUBON";
            BUBON.Size = new Size(220, 211);
            BUBON.TabIndex = 0;
            BUBON.Text = "КНОПИЧКА";
            BUBON.UseVisualStyleBackColor = true;
            BUBON.Click += BUBON_Click;
            // 
            // TB2
            // 
            TB2.Location = new Point(224, 415);
            TB2.Name = "TB2";
            TB2.Size = new Size(100, 23);
            TB2.TabIndex = 3;
            // 
            // TB1
            // 
            TB1.Location = new Point(118, 415);
            TB1.Name = "TB1";
            TB1.Size = new Size(100, 23);
            TB1.TabIndex = 4;
            // 
            // SUMBut
            // 
            SUMBut.Location = new Point(91, 354);
            SUMBut.Name = "SUMBut";
            SUMBut.Size = new Size(75, 23);
            SUMBut.TabIndex = 5;
            SUMBut.Text = "Сложить";
            SUMBut.UseVisualStyleBackColor = true;
            SUMBut.Click += SUMBut_Click;
            // 
            // MULTButt
            // 
            MULTButt.Location = new Point(282, 354);
            MULTButt.Name = "MULTButt";
            MULTButt.Size = new Size(75, 23);
            MULTButt.TabIndex = 6;
            MULTButt.Text = "Умножить";
            MULTButt.UseVisualStyleBackColor = true;
            MULTButt.Click += MULTButt_Click;
            // 
            // DIFButt
            // 
            DIFButt.Location = new Point(186, 354);
            DIFButt.Name = "DIFButt";
            DIFButt.Size = new Size(75, 23);
            DIFButt.TabIndex = 7;
            DIFButt.Text = "Вычесть";
            DIFButt.UseVisualStyleBackColor = true;
            DIFButt.Click += DIFButt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 391);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 8;
            label1.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(282, 391);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 9;
            label2.Text = "2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DIFButt);
            Controls.Add(MULTButt);
            Controls.Add(SUMBut);
            Controls.Add(TB1);
            Controls.Add(TB2);
            Controls.Add(BUBON);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BUBON;
        private TextBox TB2;
        private TextBox TB1;
        private Button SUMBut;
        private Button MULTButt;
        private Button DIFButt;
        private Label label1;
        private Label label2;
    }
}
