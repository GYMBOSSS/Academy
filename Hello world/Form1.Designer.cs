namespace Hello_world
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            player = new PictureBox();
            Floor = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            Start = new Button();
            Jump = new Button();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Floor).BeginInit();
            SuspendLayout();
            // 
            // player
            // 
            player.BackgroundImage = (Image)resources.GetObject("player.BackgroundImage");
            player.BackgroundImageLayout = ImageLayout.Stretch;
            player.Location = new Point(364, 137);
            player.Name = "player";
            player.Size = new Size(104, 105);
            player.TabIndex = 0;
            player.TabStop = false;
            // 
            // Floor
            // 
            Floor.BackColor = SystemColors.ActiveCaptionText;
            Floor.Location = new Point(105, 344);
            Floor.Name = "Floor";
            Floor.Size = new Size(586, 50);
            Floor.TabIndex = 1;
            Floor.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // Start
            // 
            Start.Font = new Font("Roboto Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Start.Location = new Point(105, 137);
            Start.Name = "Start";
            Start.Size = new Size(127, 75);
            Start.TabIndex = 2;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // Jump
            // 
            Jump.Font = new Font("Roboto Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Jump.Location = new Point(105, 137);
            Jump.Name = "Jump";
            Jump.Size = new Size(127, 75);
            Jump.TabIndex = 3;
            Jump.Text = "JUMP!!!";
            Jump.UseVisualStyleBackColor = true;
            Jump.Visible = false;
            Jump.Click += Jump_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Jump);
            Controls.Add(Start);
            Controls.Add(Floor);
            Controls.Add(player);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)Floor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox player;
        private PictureBox Floor;
        private System.Windows.Forms.Timer timer1;
        private Button Start;
        private Button Jump;
    }
}
