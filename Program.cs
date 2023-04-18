using ConsoleApp12.DAL;
using ConsoleApp12.Model;
using System.ComponentModel.Design;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1.Category menu");
            Console.WriteLine("2.Medicine menu");
            Console.WriteLine("0.Exit");
            Console.WriteLine("Secim edin:");
            int menu=int.Parse(Console.ReadLine());
            switch (menu)
            {
              case 0:
                    break;
              case 1:
                    Console.WriteLine("1.Create category");
                    Console.WriteLine("2.Delete category");
                    Console.WriteLine("3.Update category");
                    Console.WriteLine("0.Exit");
                    Console.WriteLine("Secim edin:");
                    int menu2 = int.Parse(Console.ReadLine());
                    switch (menu2)
                    {
                        case 0:
                            break;
                        case 1:
                            Console.WriteLine("Category adini daxil edin: ");
                            string categoryname=Console.ReadLine();
                            Category category= new Category(categoryname);
                            Context.Categories.Add(category);
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("1.Create category");
                    Console.WriteLine("2.Delete category");
                    Console.WriteLine("3.Update category");
                    Console.WriteLine("0.Exit");
                    Console.WriteLine("Secim edin:");
                    int menu3 = int.Parse(Console.ReadLine());
                    switch (menu3)
                    {
                        case 0:
                            break;
                        case 1:
                            Console.WriteLine("Medicine adini daxil edin: ");
                            string medicinename = Console.ReadLine();
                            Console.WriteLine("Qiymeti daxil edin:");
                            double price=Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Sayi daxil edin:");
                            int count=int.Parse( Console.ReadLine());
                            Medicine medicine = new Medicine(medicinename,price,count);
                            Context.Medicines.Add(medicine);
                            break;
                    }
                    break;

                    default:
                    Console.WriteLine("Duzgun daxil edin");
                    break;

            }
        }
    }
}