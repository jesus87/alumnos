using System.Collections.Generic;
using System.Text;
using System;

namespace Students.Core.Models
{
    public class Order
    {
        public Order() {
            DateCreated = DateTime.Now;
        }

        public int OrderId { get; set; }

        public string Description { get; set; }

        public decimal AmountTotal { get; set; }

        public DateTime DateCreated { get; private set; }

        public int StudentId { get; set; }

        public Student Student { get; set; }

    }
}
