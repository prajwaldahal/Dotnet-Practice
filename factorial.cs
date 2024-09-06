using System;
class Factorial{
	// public static int CalcFactorial(int n){
		// if(n==0 || n==1)
			// return 1;
		// else
			// return n*CalcFactorial(n-1);
	// }
	public static void Main(){
		int p=1;
		Console.Write("enter a number: ");
		int a=Convert.ToInt32(Console.ReadLine());
		for(int i=2;i<=a;i++){
			p=p*i;
		}
		
		
		Console.WriteLine("the factorial of {0} is {1}",a,p);//CalcFactorial(a));
	}
} 