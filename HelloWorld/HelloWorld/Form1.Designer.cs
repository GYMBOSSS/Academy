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
            pictureBox1 = new PictureBox();
            _Timer = new System.Windows.Forms.Timer(components);
            ShowHit = new Label();
            ShowLife = new Label();
            ShowMeter = new Label();
            Start = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(657, 466);
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
            ShowText.Location = new Point(726, 415);
            ShowText.Name = "ShowText";
            ShowText.Size = new Size(90, 37);
            ShowText.TabIndex = 1;
            ShowText.Text = "label1";
            // 
            // button2
            // 
            button2.Location = new Point(737, 467);
            button2.Name = "button2";
            button2.Size = new Size(74, 53);
            button2.TabIndex = 2;
            button2.Text = "Decrease";
            button2.UseVisualStyleBackColor = true;
            button2.Click += DecrButtonClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(704, 394);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // _Timer
            // 
            _Timer.Tick += _Timer_Tick;
            // 
            // ShowHit
            // 
            ShowHit.AutoSize = true;
            ShowHit.Font = new Font("Segoe UI", 20F);
            ShowHit.Location = new Point(138, 130);
            ShowHit.Name = "ShowHit";
            ShowHit.Size = new Size(117, 37);
            ShowHit.TabIndex = 5;
            ShowHit.Text = "ShowHit";
            // 
            // ShowLife
            // 
            ShowLife.AutoSize = true;
            ShowLife.Font = new Font("Segoe UI", 20F);
            ShowLife.Location = new Point(0, 434);
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
            ShowMeter.Location = new Point(0, 397);
            ShowMeter.Name = "ShowMeter";
            ShowMeter.Size = new Size(152, 37);
            ShowMeter.TabIndex = 7;
            ShowMeter.Text = "ShowMeter";
            // 
            // Start
            // 
            Start.Font = new Font("Yu Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Start.Location = new Point(277, 397);
            Start.Name = "Start";
            Start.Size = new Size(141, 72);
            Start.TabIndex = 8;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 521);
            Controls.Add(Start);
            Controls.Add(ShowMeter);
            Controls.Add(ShowLife);
            Controls.Add(ShowHit);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(ShowText);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ToolTip toolTip1;
        private Label ShowText;
        private Button button2;

        private int count;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer _Timer;
        private Label ShowHit;
        private Label ShowLife;
        private Label ShowMeter;
        private Button Start;
    }
}
