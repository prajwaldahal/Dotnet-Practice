using System;
struct  coordinate{
	public int x;
	public int y;
	public coordinate(int x,int y){
		this.x=x;
		this.y=y;
	}
	
	public void Show(){
		Console.WriteLine(point.x);
		Console.WriteLine(point.y);
	}
}
class A{
	public static void Main(){
		coordinate point = new coordinate(10,12);
		Console.WriteLine(point.x);
		Console.WriteLine(point.y);
		point.Sum(10,2);
	}
}