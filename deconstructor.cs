using System;
class Demo{
	string FirstName{get;set;}
	string LastName{get; set;}
	public void Dis(){
		Console.WriteLine("hello");
	}
	public void Deconstruct(out string firstname,out string lastname){
		firstname=FirstName;
		lastname=LastName;
	}
	public static void Main(){
		Demo d = new Demo{FirstName="abcd",LastName="thuldd"};
		var(FirstName,LastName)=d;
		d.Dis();
		Console.WriteLine("hello puja k xa maiya you are looking good today");
	}
}