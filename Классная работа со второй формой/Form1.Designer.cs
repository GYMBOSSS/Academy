namespace Классная_работа_со_второй_формой
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
            EnterB = new Button();
            AdminB = new Button();
            AdminCB = new ComboBox();
            SuspendLayout();
            // 
            // EnterB
            // 
            EnterB.Location = new Point(93, 96);
            EnterB.Name = "EnterB";
            EnterB.Size = new Size(146, 237);
            EnterB.TabIndex = 0;
            EnterB.Text = "button1";
            EnterB.UseVisualStyleBackColor = true;
            EnterB.Click += EnterB_Click;
            // 
            // AdminB
            // 
            AdminB.Location = new Point(93, 96);
            AdminB.Name = "AdminB";
            AdminB.Size = new Size(146, 78);
            AdminB.TabIndex = 1;
            AdminB.Text = "button1";
            AdminB.UseVisualStyleBackColor = true;
            AdminB.Visible = false;
            AdminB.Click += AdminB_Click;
            // 
            // AdminCB
            // 
            AdminCB.FormattingEnabled = true;
            AdminCB.Location = new Point(93, 195);
            AdminCB.Name = "AdminCB";
            AdminCB.Size = new Size(146, 23);
            AdminCB.TabIndex = 2;
            AdminCB.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 450);
            Controls.Add(AdminCB);
            Controls.Add(AdminB);
            Controls.Add(EnterB);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button EnterB;
        private Button AdminB;
        private ComboBox AdminCB;
    }
}
