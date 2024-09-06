using System;
class Animal{
	public void sound(){
		Console.WriteLine("karaaaaa");
	}
	public void run(){}
}
class Dog:Animal{
	public void security(){
		Console.WriteLine("oii chor bhag");
	}
}
class kangaro:Animal{
	public void Jump(){}
}


class Test{
	public static void Main(){
		Animal hatti = new Animal();
		Animal subhanjal = new Animal();
		Animal a = new Dog();
		
		
		Dog a = new Dog();
		a.sound();
		a.security();
	}
}