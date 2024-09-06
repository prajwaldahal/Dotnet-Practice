using System;
struct  coordinate{
	public int x;
	public int y;
	public coordinate(int x,int y){
		this.x=x;
		this.y=y;
	}
	
	public void Show(){
		Console.WriteLine("x={0} y={1}",x,y);
	}
}
class A{
	public int x;
	public int y;
	public A(int x,int y){
		this.x=x;
		this.y=y;
	}
	
	public void Show(){
		Console.WriteLine("x={0} y={1}",x,y);
	}
}
class Demo{
	public static void Main(){
		coordinate c = new coordinate(10,12);
		Console.WriteLine("when struct object is created");
		c.Show();
		ModifyStructVal(c);
		
		Console.WriteLine("After  ModifyStructVal method is called");
		c.Show();
		Console.WriteLine(" ");
		A obj = new A(14,15);
		Console.WriteLine("when class object is created");
		obj.Show();
		ModifyClassVal(obj);
		Console.WriteLine("After  ModifyClassVal method is called");
		obj.Show();
	}
	public static void ModifyStructVal(coordinate c){
		c.x+=100;
		c.y+=100;
		Console.WriteLine("inside ModifyStructVal x={0} y={1}",c.x,c.y);
	}
	public static void ModifyClassVal(A a){
		a.x+=100;
		a.y+=100;
		Console.WriteLine("inside ModifyClassVal x={0} y={1}",a.x,a.y);
	}
}