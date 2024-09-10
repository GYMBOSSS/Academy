namespace В_классе_делаем_со_списками
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
            LB1 = new ListBox();
            AddB = new Button();
            AddTB = new TextBox();
            LB2 = new ListBox();
            CopyB = new Button();
            SuspendLayout();
            // 
            // LB1
            // 
            LB1.FormattingEnabled = true;
            LB1.ItemHeight = 15;
            LB1.Location = new Point(188, 96);
            LB1.Name = "LB1";
            LB1.SelectionMode = SelectionMode.MultiSimple;
            LB1.Size = new Size(120, 94);
            LB1.TabIndex = 0;
            // 
            // AddB
            // 
            AddB.Location = new Point(188, 196);
            AddB.Name = "AddB";
            AddB.Size = new Size(120, 53);
            AddB.TabIndex = 1;
            AddB.Text = "Add";
            AddB.UseVisualStyleBackColor = true;
            AddB.Click += AddB_Click;
            // 
            // AddTB
            // 
            AddTB.Location = new Point(188, 67);
            AddTB.Name = "AddTB";
            AddTB.Size = new Size(120, 23);
            AddTB.TabIndex = 2;
            // 
            // LB2
            // 
            LB2.FormattingEnabled = true;
            LB2.ItemHeight = 15;
            LB2.Location = new Point(314, 96);
            LB2.Name = "LB2";
            LB2.Size = new Size(120, 94);
            LB2.TabIndex = 3;
            // 
            // CopyB
            // 
            CopyB.Location = new Point(314, 196);
            CopyB.Name = "CopyB";
            CopyB.Size = new Size(120, 53);
            CopyB.TabIndex = 4;
            CopyB.Text = "Push selected";
            CopyB.UseVisualStyleBackColor = true;
            CopyB.Click += CopyB_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 450);
            Controls.Add(CopyB);
            Controls.Add(LB2);
            Controls.Add(AddTB);
            Controls.Add(AddB);
            Controls.Add(LB1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LB1;
        private Button AddB;
        private TextBox AddTB;
        private ListBox LB2;
        private Button CopyB;
    }
}
