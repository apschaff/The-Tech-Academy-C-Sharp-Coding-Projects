using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceRecordApp
{
    public class Record
    {
        public int Id { get; set; }
        public string Vehicle { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public string MaintenanceDescription { get; set; }
        public string PerformedBy { get; set; }
        public int Cost { get; set; }
    }

    public class MaintenanceDbContext : DbContext
    {
        public DbSet<Record> Records { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Please enter your vehicle maintenance information as instructed.");
            Console.Write("\nPlease enter your vehicle model: ");
            string vehicle = Console.ReadLine();
            Console.Write("\nPlease enter the date of service in the format mm/dd/yyyy: ");
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            Console.Write("\nPlease enter a brief Maintenance description: ");
            string description = Console.ReadLine();
            Console.Write("\nPlease enter the name of the shop that performed the work: ");
            string shop = Console.ReadLine();
            Console.Write("\nPlease enter the cost of the service (whole numbers only): ");
            int cost = Convert.ToInt32(Console.ReadLine());
        }
    } 
}
