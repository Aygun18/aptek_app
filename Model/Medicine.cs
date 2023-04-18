using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp12.DAL;

namespace ConsoleApp12.Model
{
    internal class Medicine
    {
        public string MedicineName { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public static int _id;
        public int Id { get; set; }
        public static List<Medicine> Medicines = new List<Medicine>();
        public Medicine(string medicinename,double price,int count)
        {
            _id++;
            Id = _id;
            MedicineName = medicinename;
            Price = price;
            Count = count;  
        }
        public static void Create(string medicineName,double price,int count)
        {
            Medicine medicine = new Medicine(medicineName,price,count);
            Medicines.Add(medicine);

        }
        public static void Delete(int id)
        {
            Medicine medicine = Search(id);
            Medicines.Remove(medicine);
            
        }
        public static void Update(int id, string newMedicineName)
        {
            Medicine medicine = Search(id);
            medicine.MedicineName= newMedicineName;
        }
       
        public static Medicine Search(int id)
        {
            foreach (var item in Context.Medicines)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            throw new Exception("bele bir medicine yoxdur");
        }

        public void Sell(int quantity)
        {
            if (quantity > Count)
            {
                throw new Exception("Bu miqdar yoxdur");
            }
            Count -= quantity;
        }
    }

}


