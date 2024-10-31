using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalChat
{
    public class User
    {
        public string name;
        public string password;
        public string[] friends;
        public int[] dialogues;

        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
            friends = new string[0];
            dialogues = new int[0];
        }

        public User(string name, string password, string[] friends, int[] dialogues)
        {
            this.name = name;
            this.password = password;
            this.friends = friends;
            this.dialogues = dialogues;
        }

    }
}
