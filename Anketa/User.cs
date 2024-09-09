using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anketa
{
    internal class User
    {
        public string FIO;
        public string WorPl;
        public string MobNum;
        public string HomNum;
        public string Gen;
        public string PassWord;

        public User(string fIO, string worPl, string mobNum, string homNum, string gen, string passWord)
        {
            FIO = fIO;
            WorPl = worPl;
            MobNum = mobNum;
            HomNum = homNum;
            Gen = gen;
            PassWord = passWord;
        }
    }
}
