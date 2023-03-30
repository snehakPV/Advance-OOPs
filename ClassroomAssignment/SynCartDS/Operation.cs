using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SynCartDS
{
    public delegate void Operations();
    public class Operation
    {
        public static CustomerDetails currentCustomer;
        public static CustomList<CustomerDetails> customerList = new CustomList<CustomerDetails>();
        public static CustomList<OrderDetails> orderList = new CustomList<OrderDetails>();
        public static CustomList<ProductDetails> productList = new CustomList<ProductDetails>();
        public static void DefaultData()
        {
            CustomerDetails defaultCustomer1 = new CustomerDetails("Ravi", "Chennai", "9885858588", 50000, "ravi@mail.com");
            CustomerDetails defaultCustomer2 = new CustomerDetails("Baskaran", "Chennai", "9885858588", 60000, "baskar@mail.com");
            customerList.Add(defaultCustomer1);
            customerList.Add(defaultCustomer2);
            OrderDetails defaultOrder1 = new OrderDetails("CID1001", "PID101", 20000, DateTime.Now, 2, OrderStatus.Ordered);
            OrderDetails defaultOrder2 = new OrderDetails("CID1002", "PID103", 40000, DateTime.Now, 2, OrderStatus.Ordered);
            orderList.Add(defaultOrder1);
            orderList.Add(defaultOrder2);
            ProductDetails defaultProduct1 = new ProductDetails("Mobile(Samsung)", 10, 10000, 3);
            ProductDetails defaultProduct2 = new ProductDetails("Tablet(Lenova)", 5, 15000, 2);
            ProductDetails defaultProduct3 = new ProductDetails("Camera(Sony)", 3, 20000, 4);
            ProductDetails defaultProduct4 = new ProductDetails("iphone", 5, 50000, 6);
            ProductDetails defaultProduct5 = new ProductDetails("Laptop(Lenova 13)", 3, 40000, 3);
            ProductDetails defaultProduct6 = new ProductDetails("HeadPhone(Boat)", 5, 1000, 2);
            ProductDetails defaultProduct7 = new ProductDetails("Speaker(Boat)", 4, 500, 2);
            productList.Add(defaultProduct1);
            productList.Add(defaultProduct2);
            productList.Add(defaultProduct3);
            productList.Add(defaultProduct4);
            productList.Add(defaultProduct5);
            productList.Add(defaultProduct6);
            productList.Add(defaultProduct7);
          

        }
        public static void MainMenu()
        {
            int option=0;
            do
            {
            Console.WriteLine("Select from following:\n1.Registration\n2.Login\n3.Exit");
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        Registration();
                        break;
                    }
                case 2:
                    {
                        Login();
                        break;
                    }
            }
        }while(option<3);
        }
        public static void Registration()
        {
            Console.WriteLine("Enter your name: ");
            string customerName=Console.ReadLine();
            Console.WriteLine("Enter city: ");
            string city=Console.ReadLine();
            Console.WriteLine("Enter mobile number: ");
            string phone=Console.ReadLine();
            Console.WriteLine("Enter Wallet balance: ");
            double walletBalance=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter mail id: ");
            string mailID=Console.ReadLine();
            CustomerDetails customer=new CustomerDetails(customerName,city,phone,walletBalance,mailID);
            customerList.Add(customer);
            Console.WriteLine("Registered Successfully!\nYour Customer ID: "+customer.CustomerID);
        }
        public static void Login()
        {
            Console.WriteLine("Enter Customer ID: ");
            string customerID=Console.ReadLine();
            bool flag=true;
            foreach (CustomerDetails customer in customerList)
            {
                if(customerID==customer.CustomerID)
                {
                    Console.WriteLine("Login Successfull!");
                    flag=false;
                    currentCustomer=customer;
                    SubMenu();
                    break;
                }
            }
            if(flag)
            {
                Console.WriteLine("Invalid Customer ID!");
            }
        }
        public static void SubMenu()
        {
            int option;
            do
            {
            Console.WriteLine("Select from following:\n1.Purchase\n2.Order History\n3.Cancel Order\n4.Wallet Balance\n5.Wallet Recharge\n6.Exit");
            option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    Purchase();
                    break;
                }
                case 2:
                {
                    OrderHistory();
                    break;
                }
                case 3:
                {
                    Cancel();
                    break;
                }
                case 4:
                {
                    WalletBalance();
                    break;
                }
                case 5:
                {
                    WalletRecharge();
                    break;
                }
            }
            }while(option<6);
        }
        public static void Purchase()
        {
            foreach (ProductDetails product in productList)
            {
                Console.WriteLine($"{product.ProductID}|{product.ProductName}|{product.Stock}|{product.Price}|{product.ShippingDuration}");
            }
            Console.WriteLine("Select the product: ");
            string productID=Console.ReadLine();
            bool flag=true;
             foreach (ProductDetails product in productList)
            {
              
                if(productID==product.ProductID)
                {
                flag=false;
                Console.WriteLine("Enter the count of product: ");
                int count=int.Parse(Console.ReadLine());
                double deliveryCharge=50;
                double totalAmount;
                if(count<=product.Stock)
                {
                 totalAmount=(count*product.Price)+deliveryCharge;
                 if(totalAmount<=currentCustomer.WalletBalance)
                 {
                  currentCustomer.DeductBalance(totalAmount);
                  product.Stock-=count;
                  OrderDetails orderDetails=new OrderDetails(currentCustomer.CustomerID,product.ProductID,totalAmount,DateTime.Now,count,OrderStatus.Ordered);
                  orderList.Add(orderDetails);
                  Console.WriteLine("Order Created Successfully!\nYour order ID: "+orderDetails.OrderID);
                  Console.WriteLine($"Delivery Date{orderDetails.PurchaseDate.AddDays(product.ShippingDuration)}");
                 }
                 else
                 {
                    Console.WriteLine("Insufficient Wallet Balance.Please Recharge your wallet and do purchase again");
                 }
                }
                else
                {
                    Console.WriteLine("Insufficient count");
                }
                }
            }
            if(flag)
            {
                Console.WriteLine("Invalid Product ID");
            }
        }  
        public static void Cancel()
        {
            bool flag=true;
            foreach (OrderDetails order in orderList)
            { 
                if(currentCustomer.CustomerID==order.CustomerID && OrderStatus.Ordered==order.Status)
                {
                    flag=false;
                    Console.WriteLine($"{order.CustomerID}|{order.ProductID}|{order.TotalPrice}|{order.PurchaseDate}|{order.Quantity}|{order.Status}");
                }
               
                
            } 
             if(flag)
                {
                    Console.WriteLine("You have no order history");
                }

                Console.WriteLine("Enter your order ID: ");
                string orderID=Console.ReadLine();
                 foreach (OrderDetails order in orderList)
            { 
                if(currentCustomer.CustomerID==order.CustomerID && OrderStatus.Ordered==order.Status)
                {
                if(orderID==order.OrderID)
                {
                  foreach (ProductDetails product in productList)
            {
                if(product.ProductID==order.ProductID)
                {
                    product.Stock+=order.Quantity;
                }
             }
             currentCustomer.WalletRecharge(order.TotalPrice-50);
             order.Status=OrderStatus.Cancelled;
             Console.WriteLine("Order Cancelled Successfully");
                }
                }
            }
        }
        public static void WalletBalance()
        {
            Console.WriteLine(currentCustomer.WalletBalance);
        }
        public static void WalletRecharge()
        {
            Console.WriteLine("Do you wish to Recharge the balance?(yes/no)");
            string Recharge=Console.ReadLine().ToLower();
            if(Recharge=="yes")
            {
                Console.WriteLine("Enter the amount to be recharged: ");
                double amount=double.Parse(Console.ReadLine());
                currentCustomer.WalletRecharge(amount);
                Console.WriteLine(currentCustomer.WalletBalance);

            }
        }
        public static void OrderHistory()
        {
            foreach (OrderDetails order in orderList)
            { 
                if(currentCustomer.CustomerID==order.CustomerID)
                {
                Console.WriteLine($"{order.CustomerID}|{order.ProductID}|{order.TotalPrice}|{order.PurchaseDate}|{order.Quantity}|{order.Status}");
                }
            }
        }
    public static event Operations start;
    private static void Subscribe()
    {
        start=new Operations(FileHandling.Create);
        //start+=new Operations (Operation.DefaultData);
        start+=new Operations (FileHandling.ReadFromCSV);
        start+=new Operations(Operation.MainMenu);
        start+=new Operations (FileHandling.WriteToCSV);
        
    }
    public static void Starter()
    {
        Subscribe();
        start();
    }
    }
}