using System;
using static System.Console;
class LambdaExoressionDemo{
	public static void Main(){
		Func<string,string,int> TotalLength=(s1,s2)=>s1.Length+s2.Length;
		WriteLine(TotalLength("hello","world"));
	}
}