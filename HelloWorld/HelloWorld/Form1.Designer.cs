namespace HelloWorld
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            toolTip1 = new ToolTip(components);
            ShowText = new Label();
            button2 = new Button();
            BG1 = new PictureBox();
            _Timer = new System.Windows.Forms.Timer(components);
            ShowHit = new Label();
            ShowLife = new Label();
            ShowMeter = new Label();
            Start = new Button();
            StopResume = new Button();
            Restart = new Button();
            Player = new PictureBox();
            BG2 = new PictureBox();
            HUD = new GroupBox();
            Settings = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)BG1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BG2).BeginInit();
            HUD.SuspendLayout();
            Settings.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(5, 22);
            button1.Name = "button1";
            button1.Size = new Size(74, 53);
            button1.TabIndex = 0;
            button1.Text = "Increase";
            button1.UseVisualStyleBackColor = true;
            button1.Click += IncrButtonClick;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // ShowText
            // 
            ShowText.AutoSize = true;
            ShowText.BackColor = SystemColors.ActiveCaption;
            ShowText.Font = new Font("Segoe UI", 20F);
            ShowText.Location = new Point(388, 415);
            ShowText.Name = "ShowText";
            ShowText.Size = new Size(90, 37);
            ShowText.TabIndex = 1;
            ShowText.Text = "label1";
            // 
            // button2
            // 
            button2.Location = new Point(138, 22);
            button2.Name = "button2";
            button2.Size = new Size(74, 53);
            button2.TabIndex = 2;
            button2.Text = "Decrease";
            button2.UseVisualStyleBackColor = true;
            button2.Click += DecrButtonClick;
            // 
            // BG1
            // 
            BG1.BackgroundImage = (Image)resources.GetObject("BG1.BackgroundImage");
            BG1.BackgroundImageLayout = ImageLayout.Stretch;
            BG1.BorderStyle = BorderStyle.FixedSingle;
            BG1.Location = new Point(0, 0);
            BG1.Name = "BG1";
            BG1.Size = new Size(616, 394);
            BG1.TabIndex = 3;
            BG1.TabStop = false;
            // 
            // _Timer
            // 
            _Timer.Tick += _Timer_Tick;
            // 
            // ShowHit
            // 
            ShowHit.AutoSize = true;
            ShowHit.Font = new Font("Segoe UI", 20F);
            ShowHit.Location = new Point(0, 15);
            ShowHit.Name = "ShowHit";
            ShowHit.Size = new Size(60, 37);
            ShowHit.TabIndex = 5;
            ShowHit.Text = "Hit!";
            ShowHit.Visible = false;
            // 
            // ShowLife
            // 
            ShowLife.AutoSize = true;
            ShowLife.Font = new Font("Segoe UI", 20F);
            ShowLife.Location = new Point(0, 71);
            ShowLife.Name = "ShowLife";
            ShowLife.Size = new Size(124, 37);
            ShowLife.TabIndex = 6;
            ShowLife.Text = "ShowLife";
            ShowLife.Click += label1_Click;
            // 
            // ShowMeter
            // 
            ShowMeter.AutoSize = true;
            ShowMeter.Font = new Font("Segoe UI", 20F);
            ShowMeter.Location = new Point(0, 43);
            ShowMeter.Name = "ShowMeter";
            ShowMeter.Size = new Size(152, 37);
            ShowMeter.TabIndex = 7;
            ShowMeter.Text = "ShowMeter";
            // 
            // Start
            // 
            Start.Font = new Font("Yu Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Start.Location = new Point(178, 397);
            Start.Name = "Start";
            Start.Size = new Size(141, 72);
            Start.TabIndex = 8;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // StopResume
            // 
            StopResume.Location = new Point(178, 400);
            StopResume.Name = "StopResume";
            StopResume.Size = new Size(75, 68);
            StopResume.TabIndex = 9;
            StopResume.Text = "Stop";
            StopResume.UseMnemonic = false;
            StopResume.UseVisualStyleBackColor = true;
            StopResume.Visible = false;
            StopResume.Click += StopResume_Click;
            // 
            // Restart
            // 
            Restart.Location = new Point(244, 400);
            Restart.Name = "Restart";
            Restart.Size = new Size(75, 67);
            Restart.TabIndex = 10;
            Restart.Text = "Restart";
            Restart.UseVisualStyleBackColor = true;
            Restart.Visible = false;
            Restart.Click += Restart_Click;
            // 
            // Player
            // 
            Player.BackgroundImage = (Image)resources.GetObject("Player.BackgroundImage");
            Player.BackgroundImageLayout = ImageLayout.Stretch;
            Player.Location = new Point(0, 302);
            Player.Name = "Player";
            Player.Size = new Size(100, 92);
            Player.TabIndex = 11;
            Player.TabStop = false;
            // 
            // BG2
            // 
            BG2.BackgroundImage = (Image)resources.GetObject("BG2.BackgroundImage");
            BG2.BackgroundImageLayout = ImageLayout.Stretch;
            BG2.BorderStyle = BorderStyle.FixedSingle;
            BG2.Location = new Point(616, 0);
            BG2.Name = "BG2";
            BG2.Size = new Size(616, 394);
            BG2.TabIndex = 12;
            BG2.TabStop = false;
            // 
            // HUD
            // 
            HUD.Controls.Add(ShowHit);
            HUD.Controls.Add(ShowMeter);
            HUD.Controls.Add(ShowLife);
            HUD.Location = new Point(12, 12);
            HUD.Name = "HUD";
            HUD.Size = new Size(150, 110);
            HUD.TabIndex = 13;
            HUD.TabStop = false;
            HUD.Text = "HUD";
            HUD.Enter += groupBox1_Enter;
            // 
            // Settings
            // 
            Settings.Controls.Add(button2);
            Settings.Controls.Add(button1);
            Settings.Location = new Point(370, 12);
            Settings.Name = "Settings";
            Settings.Size = new Size(218, 91);
            Settings.TabIndex = 17;
            Settings.TabStop = false;
            Settings.Text = "Settings";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 521);
            Controls.Add(Settings);
            Controls.Add(HUD);
            Controls.Add(Player);
            Controls.Add(Restart);
            Controls.Add(StopResume);
            Controls.Add(Start);
            Controls.Add(ShowText);
            Controls.Add(BG2);
            Controls.Add(BG1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)BG1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)BG2).EndInit();
            HUD.ResumeLayout(false);
            HUD.PerformLayout();
            Settings.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ToolTip toolTip1;
        private Label ShowText;
        private Button button2;

        private int count;
        private PictureBox BG1;
        private System.Windows.Forms.Timer _Timer;
        private Label ShowHit;
        private Label ShowLife;
        private Label ShowMeter;
        private Button Start;
        private Button StopResume;
        private Button Restart;
        private PictureBox Player;
        private PictureBox BG2;
        private GroupBox HUD;
        private GroupBox Settings;
    }
}
