using System;
class Sort{
	public static void Main(){
		 int[] a=new int[3];//{1,4,7,2,3,9,0,12,13,17,54,32,67,3,2,8,32,56};
		 Array.Reverse(a);
		foreach(int b in a)
		{
			Console.WriteLine(b);
		}
	}
}