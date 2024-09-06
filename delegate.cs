using System;
using static System.Console;
public delegate void MyDelegate(String msg);
public class ClassA{
	public static void MethodA(String message){
		WriteLine("MethodA called with msg:"+message);
	}
}
public class ClassB{
	public static void MethodB(String message){
		WriteLine("MethodB called with msg: "+message);
	}
}

class test{
	public static void Main(){
		MyDelegate del1 = ClassA.MethodA;
		MyDelegate del2 = ClassB.MethodB;
		MyDelegate del = del1+del2;
		del("hello");
		del=del2-del1;
		del("hello");
	}
}