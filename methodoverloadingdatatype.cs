using System;
class Sum{
	public void add1(int a,int b,int c){
		Console.WriteLine(a+b);
	}
	public int add1(int a,int b,int c){
		return a+b+c;
	}
	public  static void Main(){
		Sum s = new Sum();
		s.add1(1,2,3);
		Console.WriteLine(s.add1(1,2,3));
	}
}