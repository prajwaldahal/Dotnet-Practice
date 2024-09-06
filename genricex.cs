using System;
class X<y>{
	public y data;
}
class test{
	public static void Main(){
		X<int> y = new X<int>();
		X<string> z= new X<string>();
		y.data=12;
		z.data="prajwal";
		Console.WriteLine(y.data);
		Console.WriteLine(z.data);
	}
}