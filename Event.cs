using System;
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
}