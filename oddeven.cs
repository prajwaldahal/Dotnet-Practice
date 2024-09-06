using System;
class OddEven{
	public static void Main(){
		int[]a=new int[5];
		int counte=0;
		int counto=0;
		for(int i=0;i<5;i++){
			Console.Write("enter a number: ");
			a[i]=Convert.ToInt32(Console.ReadLine());
		}
		int[]odd=new int[5];
		int[]even=new int[5];
		for(int i=0;i<5;i++){
			if(a[i]%2==0){
				even[counte]=a[i];
				counte++;
			}
			else{
				odd[counto]=a[i];
				counto++;
			}
		}
		Console.WriteLine("even numbers are: ");
		for(int i=0;i<counte;i++){
			Console.Write(" {0}",even[i]);
		}
		Console.WriteLine();
		Console.WriteLine("odd numbers are: ");
		for(int i=0;i<counto;i++){
			Console.Write(" {0}",odd[i]);
		}
	}
}
