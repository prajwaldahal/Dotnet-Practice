using System;
class jaggedArray{
	public static void Main(){
		int[][] arr = {new int[]{1,2,3},new int[]{4,5,6,7},new int[]{8,9,10,11,12}};
		foreach(int[] a in arr){
			int sum=0;
			for(int i=0;i<a.Length;i++){
				sum+=a[i];
				Console.Write(a[i]+" ");
			}
			Console.WriteLine(sum);
		}
	}
}