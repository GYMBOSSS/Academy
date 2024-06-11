partial class NoteApp
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
        // Инициализация меню
        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

        // Настройка 'MenuStrip'
        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
    this.fileToolStripMenuItem});
        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Size = new System.Drawing.Size(784, 24);
        this.menuStrip1.TabIndex = 0;
        this.menuStrip1.Text = "menuStrip1";

        // Настройка 'fileToolStripMenuItem'
        this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
    this.newToolStripMenuItem,
    this.openToolStripMenuItem,
    this.saveToolStripMenuItem});
        this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
        this.fileToolStripMenuItem.Text = "Файл";

        // Настройка 'newToolStripMenuItem'
        this.newToolStripMenuItem.Name = "newToolStripMenuItem";
        this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        this.newToolStripMenuItem.Text = "Новый";

        // Настройка 'openToolStripMenuItem'
        this.openToolStripMenuItem.Name = "openToolStripMenuItem";
        this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        this.openToolStripMenuItem.Text = "Открыть";

        // Настройка 'saveToolStripMenuItem'
        this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
        this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        this.saveToolStripMenuItem.Text = "Сохранить";

        // Инициализация 'RichTextBox'
        this.richTextBox1 = new System.Windows.Forms.RichTextBox();
        this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.richTextBox1.Location = new System.Drawing.Point(0, 24);
        this.richTextBox1.Name = "richTextBox1";
        this.richTextBox1.Size = new System.Drawing.Size(784, 537);
        this.richTextBox1.TabIndex = 1;
        this.richTextBox1.Text = "";

        // Добавление 'MenuStrip' и 'RichTextBox' на форму
        this.Controls.Add(this.richTextBox1);
        this.Controls.Add(this.menuStrip1);

        // Остальные настройки формы
        this.MainMenuStrip = this.menuStrip1;
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(784, 561);
        this.Name = "NoteApp";
        this.Text = "NoteApp";
        this.ResumeLayout(false);
        this.PerformLayout();


    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.RichTextBox richTextBox1;
}
