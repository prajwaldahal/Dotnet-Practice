using System;
class Sum{
	public void add1(int a,int b){
		Console.WriteLine(a+b);
	}
	public void add1(int a,int b,int c){
		Console.WriteLine(a+b+c);
	}
	public  static void Main(){
		Sum s = new Sum();
		s.add1(1,2);
		s.add1(1,2,3);
	}
}