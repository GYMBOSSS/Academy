namespace Anketa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MNTB.Visible = MNCHB.Checked;
            label6.Visible = !MNCHB.Checked;
            HNTB.Visible = HNCHB.Checked;
            label6.Visible = !HNCHB.Checked;
            WPTB.Visible = WPCHB.Checked;
            label8.Visible = !WPCHB.Checked;

        }
        private void ERROR(string message)
        {
            MessageBox.Show($"Ты чёто не ввёл{message}, иди проверься", "ERRRRRROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            FIOTB.Clear(); MNTB.Clear(); HNTB.Clear(); WPTB.Clear();
        }
        private void REGGED()
        {
            MessageBox.Show("Красава, зареган", "RRRRRREGGED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void REGB_Click(object sender, EventArgs e)
        {
            List<string> not = new List<string>();
            string not = "";
            if (FIOTB.Text != "")
            {

            }
            else
            {
                not = not + "фамилию"
            }
        }

        private void MNCHB_CheckedChanged(object sender, EventArgs e)
        {
            MNTB.Visible = MNCHB.Checked;
            label6.Visible = !MNCHB.Checked;
        }

        private void HNCHB_CheckedChanged(object sender, EventArgs e)
        {
            HNTB.Visible = HNCHB.Checked;
            label7.Visible = !HNCHB.Checked;
        }

        private void WPCHB_CheckedChanged(object sender, EventArgs e)
        {
            WPTB.Visible = WPCHB.Checked;
            label8.Visible = !WPCHB.Checked;
        }
    }
}
