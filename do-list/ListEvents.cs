using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_list
{
    class ListEvents
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Priority { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}, Date: {Date}, Priority: {Priority}";
        }
    }
}
