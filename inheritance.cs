using System;
class X{
	public X(){
		Console.WriteLine("hello from class X");
	}
	public void Sum(int a,int b){
		Console.WriteLine(a+b);
	}
}
class W:X{
	public W(){
		Console.WriteLine("hello from class W");
	}
	public static void Main(){
		W obj1=new W();
		obj1.Sum(2,3);
	}
}