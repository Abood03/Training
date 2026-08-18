using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program // Subscriber
{
    static void Main(string[] args)
    {
        var stock = new Stock("Amazon");
        stock.Price = 100;

        Console.WriteLine($"stock before changing {stock.Price}");
        stock.ChangeStockPrice(0.05m);
        Console.WriteLine($"stock before changing {stock.Price}");

        // Subscribing to the event: Attaching the handler method to listen for price changes.
        stock.OnPriceChange += Stock_OnPriceChange;

        stock.ChangeStockPrice(0.05m);
        stock.ChangeStockPrice(0.02m);
        stock.ChangeStockPrice(0.00m);
    }

    // The Event Handler: This method executes automatically whenever the publisher raises the event.
    private static void Stock_OnPriceChange(Stock stock, decimal oldPrice)
    {
        if (stock.Price > oldPrice)
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else if (oldPrice > stock.Price)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red; // Should typically be another color for 'no change', e.g., Gray or Yellow.
        }
        Console.WriteLine($"{stock.Name}: {stock.Price}");
    }

    // Defines the contract/signature for the event. Any method subscribing to the event MUST match this signature.
    public delegate void StockPriceChangeHandler(Stock stock, decimal oldPrice);

    public class Stock // Publisher
    {
        private string name;
        private decimal price;

        // The event declaration based on the custom delegate.
        public event StockPriceChangeHandler OnPriceChange;

        public string Name => this.name;
        public decimal Price { get => this.price; set => this.price = value; }

        public Stock(string stockName)
        {
            this.name = stockName;
        }

        public void ChangeStockPrice(decimal percent)
        {
            decimal oldPrice = this.price;
            this.price += Math.Round(this.price * percent, 2);

            // Safety check: Ensure there is at least one active subscriber before trying to raise the event.
            if (OnPriceChange != null)
            {
                // Raising (firing) the event, broadcasting the publisher instance and the old price to all subscribers.
                OnPriceChange(this, oldPrice);
            }
        }
    }
}