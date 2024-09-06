using System;
class x{
	public int y;
	public x(){
		Console.WriteLine("hello");
	}
	public x(int y){
		this.y=y;
	}
	public void Sum(){
		Console.WriteLine(2+3);
	}
}
class w:x{
	public w(){
		Console.WriteLine("hello");
	}
	public  w(int x){
		Console.WriteLine("w called");
	}
	public static void Main(){
		w a=new w();
		a.Sum();
	}
}