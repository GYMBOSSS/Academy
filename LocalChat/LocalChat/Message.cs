using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalChat
{
    internal class Message
    {
        public int index;
        public bool self;
        public string contains;

        public Message(int index, bool self, string contains)
        {
            this.index = index;
            this.self = self;
            this.contains = contains;
        }
    }
}
