namespace Zadanie1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BUBON_Click(object sender, EventArgs e)
        {

            MessageBox.Show
                (
                    "������ ���������\n����� �������������\n�������� �� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Question
                );

            Application.Exit();
        }

        private void SUMBut_Click(object sender, EventArgs e)
        {
            if (TB1.Text == "" ^ TB2.Text == "")
            {
                MessageBox.Show("�� �������, ����� �������", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                int d = int.Parse(TB1.Text) + int.Parse(TB2.Text);
                MessageBox.Show(d.ToString(), "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void DIFButt_Click(object sender, EventArgs e)
        {
            if (TB1.Text == "" ^ TB2.Text == "")
            {
                MessageBox.Show("�� �������, ����� �������", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                int d = int.Parse(TB1.Text) - int.Parse(TB2.Text);
                MessageBox.Show(d.ToString(), "��������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MULTButt_Click(object sender, EventArgs e)
        {
            if (TB1.Text == "" ^ TB2.Text == "")
            {
                MessageBox.Show("�� �������, ����� �������", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                int d = int.Parse(TB1.Text) * int.Parse(TB2.Text);
                MessageBox.Show(d.ToString(),"������������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
