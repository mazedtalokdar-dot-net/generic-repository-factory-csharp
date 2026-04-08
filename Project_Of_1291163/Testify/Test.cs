using Project_Of_1291163.Fectories;
using Project_Of_1291163.Models;
using Project_Of_1291163.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Of_1291163.Testify
{
    public class Test
    {
        IRepoFectory fectory;
        public Test(IRepoFectory fectory)
        {
            this.fectory = fectory;
        }
        public void Run()
        {
            Console.WriteLine("[########################################] Orders And It's Status [########################################]");
            Console.WriteLine();


            IRepo<Orders> repoO = fectory.CreateRepo<Orders>();
            repoO.AddRange(new Orders[] {
                new Orders { ID=1001,OrderStatus="Delivared",DelivaryFee=50.00,TotalAmount=1455.30m},
                new Orders { ID=1002,OrderStatus="Delivared",DelivaryFee=50.00,TotalAmount=566.00m},
                new Orders { ID=1003,OrderStatus="Delivared",DelivaryFee=50.00,TotalAmount=1290.45m},
                new Orders { ID=1004,OrderStatus="Delivared",DelivaryFee=50.00,TotalAmount=455.30m},
                new Orders { ID=1005,OrderStatus="Pending",DelivaryFee=50.00,TotalAmount=1665.55m},
                new Orders { ID=1006,OrderStatus="Delivared",DelivaryFee=00.00,TotalAmount=430.00m},
                new Orders { ID=1011,OrderStatus="Delivared",DelivaryFee=50.00,TotalAmount=230.00m},
                new Orders { ID=1012,OrderStatus="Delivared",DelivaryFee=50.00,TotalAmount=356.00m},
                new Orders { ID=1013,OrderStatus="Delivared",DelivaryFee=50.00,TotalAmount=645.60m},
                new Orders { ID=1014,OrderStatus="Delivared",DelivaryFee=50.00,TotalAmount=1340.60m},
                new Orders { ID=1015,OrderStatus="Delivared",DelivaryFee=50.00,TotalAmount=1880.66m}

            });
            Console.WriteLine("[##############################################] Get All [#############################################]");
            Console.WriteLine();
            Console.WriteLine("========================================================================================================");
            repoO.GetAll().ToList()
                          .ForEach(o => Console.WriteLine($"[Order ID =>{o.ID}]\t[OrderStatus =>{o.OrderStatus}]\t[DelivaryFee =>{o.DelivaryFee}]\t[TotalAmount =>{o.TotalAmount}]\t"));
            Console.WriteLine("========================================================================================================");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("[###############################################]  Get By Id [##############################################]");
            Console.WriteLine("========================================================================================================");

            var or = repoO.GetById(1005);
            Console.WriteLine($"[Order ID =>{or.ID}]\t[OrderStatus =>{or.OrderStatus}]\t[DelivaryFee =>{or.DelivaryFee}]\t[TotalAmount =>{or.TotalAmount}]\t");
            Console.WriteLine("========================================================================================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("[###############################################]  Update Order Info [##############################################]");
            Console.WriteLine("========================================================================================================");
            or.OrderStatus = "Delivared"; or.DelivaryFee = 40.00;or.TotalAmount = 1650.00m;
            repoO.Update(or);
            Console.WriteLine($"[Order ID =>{or.ID}]\t[OrderStatus =>{or.OrderStatus}]\t[DelivaryFee =>{or.DelivaryFee}]\t[TotalAmount =>{or.TotalAmount}]\t");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("[###############################################]  Delete  Order Info [##############################################]");
            Console.WriteLine("========================================================================================================");
            repoO.Delete(1001);
            repoO.Delete(1002);
            Console.WriteLine("========================================================================================================");
            repoO.GetAll().ToList()
                          .ForEach(o => Console.WriteLine($"[Order ID =>{o.ID}]\t[OrderStatus =>{o.OrderStatus}]\t[DelivaryFee =>{o.DelivaryFee}]\t[TotalAmount =>{o.TotalAmount}]\t"));
            Console.WriteLine("========================================================================================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            IRepo<Riders> repoR = fectory.CreateRepo<Riders>();
            repoR.AddRange(new Riders[] {
                new Riders { ID=1001,Name="Sohan",Phone=015454646565L,PayAccount="Bkash"},
                new Riders { ID=1002,Name="Jawad",Phone=015143243L,PayAccount="Roket"},
                new Riders { ID=1003,Name="Rehan",Phone=01651654651L,PayAccount="Nagad"},
                new Riders { ID=1004,Name="Abed",Phone=01156132134L,PayAccount="Paypal"},
                new Riders { ID=1005,Name="Sultan",Phone=01216546216L,PayAccount="Bank"},
                new Riders { ID=1006,Name="Suleman",Phone=016516116516L,PayAccount="Cash"}


            });
            Console.WriteLine("[##############################################] Get All Riders[#############################################]");
            Console.WriteLine();
            Console.WriteLine("========================================================================================================");
            repoR.GetAll().ToList()
                          .ForEach(o => Console.WriteLine($"[Rider ID =>{o.ID}]\t[Rider Name =>{o.Name}]\t[Rider Phone =>{o.Phone}]\t[Payment Method =>{o.PayAccount}]\t"));
            Console.WriteLine("========================================================================================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("[###############################################]  Rider By Id [##############################################]");
            Console.WriteLine("========================================================================================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var rr = repoR.GetById(1005);
            Console.WriteLine($"[Rider ID =>{rr.ID}]\t[Rider Name =>{rr.Name}]\t[Rider Phone =>{rr.Phone}]\t[Payment Method =>{rr.PayAccount}]\t");
            Console.WriteLine("========================================================================================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("[###############################################]  Update Rider Info [##############################################]");
            Console.WriteLine("========================================================================================================");
            rr.Name = "Kutub Uddin"; rr.Phone = 017777770152L; rr.PayAccount = "Card";
            repoO.Update(or);
            Console.WriteLine($"[Rider ID =>{rr.ID}]\t[Rider Name =>{rr.Name}]\t[Rider Phone =>{rr.Phone}]\t[Payment Method =>{rr.PayAccount}]\t");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("[###############################################]  Delete  Rider Info [##############################################]");
            Console.WriteLine("========================================================================================================");
            repoR.Delete(1001);
            repoR.Delete(1002);
            Console.WriteLine("========================================================================================================");
            repoR.GetAll().ToList()
                         .ForEach(o => Console.WriteLine($"[Rider ID =>{o.ID}]\t[Rider Name =>{o.Name}]\t[Rider Phone =>{o.Phone}]\t[Payment Method =>{o.PayAccount}]\t"));
            Console.WriteLine("========================================================================================================");
        }
    }
}
