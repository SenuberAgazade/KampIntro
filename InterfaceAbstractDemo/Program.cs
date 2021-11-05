using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer { Id = 1, FirstName = "Engin", LastName = "Demirog", DateOfBirth = new DateTime(1985, 1, 6), NationalityId = "1234567890" });

            Console.ReadKey();
        }
    }
}
