using System;
puusing System;
class PriceChangedEventArgs:EventArgs{
	public readonly int newPrice;
	public readonly int oldPrice;
	public PriceChangedEventArgs(int newPrice,int oldPrice){
		this.oldPrice=oldPrice;
		this.newPrice =newPrice;
	}
}
class Product{
	public string name;
	private int price;
	public event EventHandler<PriceChangedEventArgs> PriceChanged;
	public void onPriceChanged(PriceChangedEventArgs e){
		PriceChanged?.Invoke(this,e);
	}
	public int Price{
		get{
			return price;
		}
		set{
			int oldPrice=price;
			price=value;
			onPriceChanged(new PriceChangedEventArgs(price,oldPrice));
		}
	}
}
class test{
	public static void Main(){
		Product p = new Product();
		p.Price=100;
		p.name="hello";
		p.PriceChanged+=ProductPriceChanged;
		p.Price=200;
		p.Price=200;
		p.Price=300;
	}
	static void ProductPriceChanged(object source,PriceChangedEventArgs e)
	{
		if(e.oldPrice==e.newPrice)
			Console.WriteLine("price is unchanged");
		else
		Console.WriteLine("price {0} changed to {1}",e.oldPrice,e.newPrice);
	}
}blic class PriceChangedEventArgs : EventArgs
{
 public readonly decimal LastPrice;
 public readonly decimal NewPrice;
 public PriceChangedEventArgs (decimal lastPrice, decimal newPrice)
 {
 LastPrice = lastPrice; NewPrice = newPrice;
 }
}
public class Stock
{
 string symbol;
 decimal price;
 // public Stock (string symbol) {this.symbol = symbol;}
 public event EventHandler<PriceChangedEventArgs> PriceChanged;
 protected virtual void OnPriceChanged (PriceChangedEventArgs e)
 {
 PriceChanged?.Invoke (this, e);
 }
 public decimal Price
 {
 get { return price; }
 set
 {
 if (price == value) return;
 decimal oldPrice = price;
 price = value;
 OnPriceChanged (new PriceChangedEventArgs (oldPrice, price));
 }
 }
}
class Test
{
 static void Main()
 {
 Stock stock = new Stock ("THPW");
 stock.Price = 27.10M;
 // Register with the PriceChanged event
 stock.PriceChanged += stock_PriceChanged;
 stock.Price = 31.59M;
 }
 static void stock_PriceChanged (object sender, PriceChangedEventArgs e)
 {
 if ((e.NewPrice - e.LastPrice) / e.LastPrice > 0.1M)
 Console.WriteLine ("Alert, 10% stock price increase!");
 }
}