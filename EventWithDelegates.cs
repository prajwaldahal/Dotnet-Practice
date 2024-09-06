using System;
public delegate void PriceChangedHandler(int oldPrice,int newPrice);
class product{
	public int price;
	public static event PriceChangedHandler PriceChanged;
	 public int Price{
		 get{
			 return price;
		 }
		 set{
			if(price == value) 
				return;
			int oldprice=price;
			price=value;
			if(PriceChanged != null)
				PriceChanged(oldprice,price);
		 }
	 }
}