using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Классная_работа_со_второй_формой
{
    public partial class Form2 : Form
    {
        Form1 _form;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            _form = form1;
        }
        private void TryEnter_Click(object sender, EventArgs e)
        {
            _form.RecieveData(textBox1.Text, textBox2.Text);
        }
    }
}
