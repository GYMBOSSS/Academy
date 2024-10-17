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
<<<<<<< HEAD
        Form1 _form;
        public Form2(Form1 form1)
=======
        string[][] array = 
        public Form2()
>>>>>>> 171cef1b1868d7aedc47b1da3092222d97442005
        {
            InitializeComponent();
            _form = form1;
        }
        private void TryEnter_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            _form.RecieveData(textBox1.Text, textBox2.Text);
=======
            
>>>>>>> 171cef1b1868d7aedc47b1da3092222d97442005
        }
    }
}
