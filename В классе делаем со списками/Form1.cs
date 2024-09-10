using System.Windows.Forms;

namespace В_классе_делаем_со_списками
{
    public partial class Form1 : Form
    {
        List<string> arr;
        public Form1()
        {
            InitializeComponent();
            arr = new List<string>();
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            if (AddTB.Text != "")
            {
                arr.Add(AddTB.Text);
            }
            LB1.Items.Clear();
            for (int i = 0; i < arr.Count; i++) { LB1.Items.Add(arr[i]); }
        }

        private void CopyB_Click(object sender, EventArgs e)
        {
            // Создаем копию коллекции
            var items = new object[LB1.Items.Count];
            LB1.Items.CopyTo(items, 0);

            // Переносим выделенные элементы в другой ListBox
            foreach (var item in items)
            {
                if (LB1.SelectedItems.Contains(item))
                {
                    LB2.Items.Add(item);
                    LB1.Items.Remove(item);
                }
            }
        }
    }
}
