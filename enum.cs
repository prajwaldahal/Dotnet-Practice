using System;
class EnumDemo{
	enum level{
		expert,
		hard,
		medium,
		easy
	}
	public static void Main(){
		level l = 	level.expert;
		Console.WriteLine(l);
		level z=(level)3;
		Console.WriteLine(z); 
		int y=(int)level.hard;
		Console.WriteLine(y); 
	}
}