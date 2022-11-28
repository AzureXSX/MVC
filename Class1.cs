using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp20
{
    public class TASK
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public TASK(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
