using System;
class PriceChangedEvent:EventArgs{
	public int oldprice;
	public int newprice;
	public PriceChangedEvent(int oldprice,int newprice){
		this.oldprice =oldprice;
		this.newprice=newprice;
	}
}
class stock{
	public event EventHandler<PriceChangedEvent> pricechanged;
	
	public void onPriceChanged(PriceChangedEvent e){
		pricechanged?.Invoke(this,e);
	}
	
	public string name;
	int price;
	public int Price{
		get{return price;}
		set{
			int oldprice=price;
			price=value;
			onPriceChanged(new PriceChangedEvent(oldprice,price));
		}
	}
}

class test{
	public static void Main(){
		
		stock s = new stock();
		
		s.name="hello";
		s.Price =200;
		
		s.pricechanged+=x;
		
		s.Price=300;
		s.Price=300;
		s.Price=400;
		s.Price=500;
	}
	public static void x(object sender,PriceChangedEvent e){
		if(e.oldprice == e.newprice){
			Console.WriteLine("unchanged");
		}
		else{
			Console.WriteLine("changed");
		}
	}
}