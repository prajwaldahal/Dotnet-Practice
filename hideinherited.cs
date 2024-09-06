	using System;
	public class Demo{
	  public void A(){
		Console.WriteLine("from demo"); 
	  }
	  public static void B(){
		  Console.WriteLine("prajwal");
	  }
	}
	
	class test{
		public static void Main(){
			Demo d = new Demo();
			d.A();
			Demo.B();
			
			// Demo1 d1 = new Demo1();
			// Demo2 d2=new Demo2();
			
			// d=d2;
			// d.A();
			
			// d=d1;
			// d.A();
		}
	}