using System;
class Car{
	public int speed;
	public Car( bool x){
		if(x){
			Console.Write("enter speed of car:");
			speed=Convert.ToInt32(Console.ReadLine());
		}
	}
	public static Car operator+ (Car c, Car c2){
		Car c3 = new Car(false);
		c3.speed=c.speed+c2.speed;
		return c3;
	}
	public static void Main(){
		Car c = new Car(true);
		Car c2 = new Car(true);
		Car c3=c+c2;
		Console.WriteLine("total speed of car1 and car2 is: "+c3.speed);
	}
} 