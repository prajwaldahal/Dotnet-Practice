/*consider the two collection Category(id,
   title, image) and Product(id, category_id, title, price,
   image). Write a program to do following operation using
   Linq
     a) Select all product under category id 10(FootWare) and
        count total number of product.
     b) Group all product by category id.
     c) Find and display the Expensive product.
     d) Find and display all products having price 
        500-2000*/





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
	
	public product(int cid,string title,int price){
		this.cid=cid;
		this.title=title;
		this.price=price;
	}
}

class Demo{
	public static void Main(){
		List<Category> c1 = new List<Category>(){new Category(1,"footwork","shoes.jpg"),new Category(2,"vegetable","123.jpg"),new Category(3,"fruits","xyz.jpg")};
		List<product> p1 = new List<product>(){new product(1,"goldstar",2000),new product(2,"tomato",200),new product(1,"jordan",3000),new product(3,"mango",200),new product(2,"spinach",30)};
		
		//a
		var c=p1.FindAll(c=>c.cid==1);
		Console.WriteLine(p1.Count());
		
		foreach(var c2 in c)
		{
			Console.WriteLine(c2.title);
		}
		
		//b
		var data=p1.GroupBy(k=>k.cid);
		foreach(var c3 in data)
		{
			Console.WriteLine("{0}:",c3.Key);
			foreach(var c4 in c3){
				Console.WriteLine(c4.title,c4.price);
			}
		}
		
		//c 
		var c9=p1.Where(c=>c.price==(p1.Max(y=>y.price)));
			Console.WriteLine("c");
		foreach(var c8 in c9){
			Console.WriteLine( c8.title);
		}
		
		//d
		var data2=p1.FindAll(c=>(c.price>500 && c.price<2000));
		foreach(var c4 in data2){
			Console.WriteLine(c4.title);
		}
		
		//implementing join
		dynamic x=	(from z in c1 join p in p1 on 
					z.id equals p.cid 
					select new{p.cid,p.price});
		foreach(object y in x){
			Console.WriteLine("{0}",y.ToString());
		}
	}
}