using System;
using System.Windows.Forms;
using System.IO;

public class NoteApp : Form
{
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem newToolStripMenuItem;
    private ToolStripMenuItem openToolStripMenuItem;
    private ToolStripMenuItem saveToolStripMenuItem;
    private RichTextBox richTextBox1;

    public NoteApp()
    {
        menuStrip1 = new MenuStrip();
        fileToolStripMenuItem = new ToolStripMenuItem();
        newToolStripMenuItem = new ToolStripMenuItem();
        openToolStripMenuItem = new ToolStripMenuItem();
        saveToolStripMenuItem = new ToolStripMenuItem();
        richTextBox1 = new RichTextBox();

        menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
        fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem });

        fileToolStripMenuItem.Text = "Файл";
        newToolStripMenuItem.Text = "Новый";
        openToolStripMenuItem.Text = "Открыть";
        saveToolStripMenuItem.Text = "Сохранить";

        newToolStripMenuItem.Click += new EventHandler(NewToolStripMenuItem_Click);
        openToolStripMenuItem.Click += new EventHandler(OpenToolStripMenuItem_Click);
        saveToolStripMenuItem.Click += new EventHandler(SaveToolStripMenuItem_Click);

        richTextBox1.Dock = DockStyle.Fill;
        Controls.Add(richTextBox1);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
    }

    private void NewToolStripMenuItem_Click(object sender, EventArgs e)
    {
        richTextBox1.Clear();
    }

    private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFile1 = new OpenFileDialog();
        if (openFile1.ShowDialog() == DialogResult.OK)
        {
            richTextBox1.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);
        }
    }

    private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFile1 = new SaveFileDialog();
        saveFile1.DefaultExt = "*.txt";
        saveFile1.Filter = "Text Files|*.txt";

        if (saveFile1.ShowDialog() == DialogResult.OK)
        {
            using (StreamWriter sw = new StreamWriter(saveFile1.FileName))
            {
                sw.WriteLine(richTextBox1.Text);
            }
        }
    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new NoteApp());
    }
}

