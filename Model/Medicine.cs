using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.Model
{
    internal class Medicine
    {
        public string MedicineName { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public Medicine(string medicinename,double price,int count)
        {
            MedicineName = medicinename;
            Price = price;
            Count = count;  
        }

        
}
}
