using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        { 
            
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental { CarId = 3, CustomerId = 1, RentDate = new DateTime(2021, 04, 13) });
            Console.WriteLine("Durum: "+result.Success+" Mesaj: "+result.Message);
            Console.ReadLine();
        }
    }
}
