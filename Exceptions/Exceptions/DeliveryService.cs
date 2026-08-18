using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class DeliveryService
    {
        private readonly static Random random= new Random();
        public void Start(Delivery delivery)
        {
            try
            {
                Process(delivery);
                Ship(delivery);
                Transit(delivery);
                Deliver(delivery);

            }
            catch(AccidentException ex)
            {
                //inform the user 
                //log the Exception
                //Ducking (rethrowing )
                throw;
                //Console.WriteLine($"there was an accident at{ex.Location} ");
                //delivery.DeliveryStatus = DeliveryStatus.UNKNOWN; 
            }
            catch (Exception ex)
            {
                throw;
                //Console.WriteLine($"deliver fails during to {ex.Message}");
                //delivery.DeliveryStatus = DeliveryStatus.UNKNOWN;
            }


        }
        private void Process(Delivery delivery)
        {
            FakeIt("Processing");
            if (random.Next(1, 5) == 1)
            {
                throw new InvalidOperationException("unable to process the Item");
            }
            delivery.DeliveryStatus = DeliveryStatus.PROCESSED;
        }
        private void Ship(Delivery delivery)
        {

            FakeIt("Shipping");
            if (random.Next(1, 5) == 1)
            {
                throw new InvalidOperationException("Parcel is damaged during the loading process");
            }
            delivery.DeliveryStatus = DeliveryStatus.SHIPPED;
        }
        private void Transit(Delivery delivery)
        {
            FakeIt("On its way");
            if (random.Next(1, 5) == 1)
            {
                throw new AccidentException("amman", "accidant !");
            }
            
            delivery.DeliveryStatus = DeliveryStatus.INTRANSIT;
        }
       
        private void Deliver(Delivery delivery)
        {
            if (random.Next(1, 5) == 1)
            {
                throw new InvalidAddressExeption($"during the loading process");
            }
            FakeIt("Delivering");

            delivery.DeliveryStatus = DeliveryStatus.DELIVERED;
        }
       private void FakeIt(string title)
        {
            Console.Write(title);
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.WriteLine(".");

        }
    }
}
