using System;
using static System.Console;
class Test{
	public static void Display(params int[] a){
		int sum=0;
		for(int i=0;i<a.Length;i++){
			sum=sum+a[i];
		}
		WriteLine(sum);
		
	}
	// public static void sum(int a,int b){
		// Console.WriteLine("called from sum {0}",a+b);
	// }
	static void Main(){
		Test.Display(1,2,3,4,5,6,7,8,9);
		Test.Display(10,11,12);
		//Test.sum(2,3);
		//Test.sum(3,4,5);
	}
}