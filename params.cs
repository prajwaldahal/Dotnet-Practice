using System;
public class Demo{
	public static void Sum(params int[] num){
		int sum =0;
		for(int i=0;i<num.Length;i++){
			sum+=num[i];
		}
		Console.WriteLine(sum);
	}
	public static void Main(){
		Demo.Sum(1,2,3);
		Demo.Sum(1,2,3,4,5);
	}
}