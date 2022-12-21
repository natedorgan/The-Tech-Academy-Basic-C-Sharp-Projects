using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Submission
{
    class Chain
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Chain(string name) : this(name, 1)
        {
        }
        public Chain(string name, int id)
        {
            Id = id;
            Name = name;
        }
    }
}
