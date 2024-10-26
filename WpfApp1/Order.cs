using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Order
    {
        public int Id { get; set; }
        public DateTime DateStart { get; set; }
        public string Instruments { get; set; }
        public string Typeofproblem { get; set; }
        public string ClientDescription { get; set; }
        public string Client { get; set; }
        public string Worker { get; set; }
        public string WorkerDescription { get; set; }
        public string Status { get; set; }

        public DateTime DateEnd { get; set; }
    }
}
