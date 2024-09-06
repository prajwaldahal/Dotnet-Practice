using System;
class A{
	string name;
	public override string ToString(){
			return name;
	}
	public static void Main(){
		A a = new A{name="prajwal"};
		Console.WriteLine(a);
	}
}