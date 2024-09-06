using System;
class DelgateDemo{
	public delegate void mymethod(String s);
	public static void method1(String a){
		Console.WriteLine("a");
	}
	public static void method2(String a){
		Console.WriteLine("method 2"+ a);
	}
	public static void Main(){
		mymethod a;
		mymethod b;
		a=method1;
		b=method2;
		a=b;
		//a+=method2;
		a("hello");
	}
}