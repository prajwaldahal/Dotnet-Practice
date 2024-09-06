using System;
class Sum{
	private int a;
	private int b;
	public int A{
		set{
			A=value;
		}
		get{
			return A;
		}
	}
	public int B{
		get;
		set;
	}
	public void Add(){
		Console.WriteLine("sum is {0}",a+b);
	}
}
class Demo{
	public static void Main(){
		Sum s = new Sum();
		s.a=12;
		s.b=13;
		s.Add();
	}
}