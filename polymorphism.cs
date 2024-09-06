using System;
using static System.Console;
class Demo{
	public virtual void Display(){
		WriteLine("hello from demo");
	}
	 
	public void Display1(){
		WriteLine("hello from demo");
	}
}

class Demo2:Demo{
	public override void Display(){
		WriteLine("hello from demo 2");
	}
	public void Display1(){
		WriteLine("hello from demo 2");
	}
}

class Test{
	public static void Main(){
		Demo d= new Demo2();
		d.Display();
		
		d.Display1();
	}
}