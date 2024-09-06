using System;
public class MainClass{
	private static int count=1;
	public static void countinc(){
		count++;
	}
	enum level{
		beginers,
		pro,
		expert
	}
	public static void Main(){
		Console.WriteLine(MainClass.count);
		MainClass.countinc();
		Console.WriteLine(MainClass.count);
	}
}
// public static class ChildClass:MainClass{
	// public static void Main(){
		// Console.WriteLine(MainClass.name);
		// MainClass.sum(1,2);
	// }
// }