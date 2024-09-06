using System;
class MDArray{
	public static void Main(){
		int[,] arr = new int[3,4];
		for(int i=0;i<3;i++){
			for(int j=0;j<4;j++){
				Console.WriteLine("Enter a number");
				arr[i,j]=Convert.ToInt32(Console.ReadLine());
			}
		}
		foreach(int a in  arr){
			Console.Write("{0} ",a);
		}
	}
}