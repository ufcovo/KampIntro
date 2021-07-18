using System;

namespace OOP2
{
    class Program
    {
        //Gercek Musteri - Tuzel Musteri 
        // Birbirlerine benzer olsa da birbirlerinin yerine kullanilamaz!
        static void Main(string[] args)
        {
            //Mert Bulut
            Individual client1 = new Individual();
            client1.CustomerNo = "12345";
            client1.CustomerName = "Mert";
            client1.CustomerSurname = "Bulut";
            client1.TcNo = "1234567890";
            client1.CustomerId = 1;

            //Kodlama.io
            Coorporate client2 = new Coorporate();
            client2.CustomerId = 2;
            client2.CustomerNo = "54321";
            client2.CompanyName = "Kodlama.io";
            client2.TaxNo = "123456879";

            Customer client3 = new Individual();
            Customer client4 = new Coorporate();
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(client1);
            customerManager.Add(client2);
        }
    }
}
