using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    internal class Note
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Data { get; set; }
        public string? Importance { get; set; }

        public Note(string? name, string? description, string? data, string? importance)
        {
            Name = name;
            Description = description;
            Data = data;
            Importance = importance;
        }
    }
}
