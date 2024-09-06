
using System;
using System.Collections.Generic;
using System.Linq;



class Category{
	public int id;
	public string title;
	public string image;
	public Category(int id,string title,string image){
		this.id=id;
		this.title=title;
		this.image=image;
	}
}

class product{
	
	public int cid;
	public string title;
	public int price;
	
	public product(int id,int cid,string title,int price){
		this.cid=cid;
		this.title=title;
		this.price=price;
	}
}

class Demo{
	public static void Main(){
		List<Category> c1 = new List<Category>(){new Category(1,"footware","shoes.jpg"),new Category(2,"clothes","cloth.jpg"),new Category(3,"electronic","elec.jpg")};
		List<product> p1 = new List<product>(){new product(1,"goldstar",2000),new product(2,"tomato",200),new product(1,"jordan",3000),new product(3,"mango",200),new product(2,"spinach",30)};
		
		var c=p1.FindAll(c=>c.cid==1);
		Console.WriteLine(p1.Count());
		
		foreach(var c2 in c)
		{
			Console.WriteLine(c2.title);
		}
		
		var data=p1.GroupBy(k=>k.cid);
		foreach(var c3 in data)
		{
			Console.WriteLine("{0}:",c3.Key);
			foreach(var c4 in c3){
				Console.WriteLine(c4.title,c4.price);
			}
		}
		
		var c9=p1.Where(c=>c.price==(p1.Max(y=>y.price)));
			Console.WriteLine("c");
		foreach(var c8 in c9){
			Console.WriteLine( c8.title);
		}
		
		var data2=p1.FindAll(c=>(c.price>500 && c.price<2000));
		foreach(var c4 in data2){
			Console.WriteLine(c4.title);
		}
		
		dynamic x=	(from z in c1 join p in p1 on 
					z.id equals p.cid 
					select new{p.cid,p.price});
		foreach(object y in x){
			Console.WriteLine("{0}",y.ToString());
		}
	}
}