using System;
public interface Shape{
	 void Area();
}
class Circle:Shape{
	public void Area(){
		int radius=8;
		Console.WriteLine(22/7*radius*radius);
	}
	public static void Main(){
		Circle c = new Circle();
		c.Area();
	}
}