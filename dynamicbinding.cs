using System;
class DynamicBinding{
	public static int Sum(int a,int  b){
		return a+b;
	}
	public static double Sum(double a,double b){
		return a+b;
	}
	public static float Sum(float a,int b){
		return a+b;
	}
	public static void Main(){
		dynamic a=Sum(3,4);
		dynamic b =Sum(3.9,4.9);
		object c=Sum(3.7,4);
		Console.WriteLine(a.GetType());
		Console.WriteLine(a);
		Console.WriteLine(b.GetType());
		Console.WriteLine(b);
		Console.WriteLine(c.GetType());
		Console.WriteLine(c);
	}
}