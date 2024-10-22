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
    public partial class AdminForm : Form
    {
        Form1 _form1;
        private string name;
        private string password;
        public AdminForm(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }
        public void RecieveData(string name, string password)
        {
            this.name = name;
            this.password = password; 
        }
    }
}
