using System;
class ABC{
	public static void swap(ref int x,ref int y){
		int temp; 
		temp=x;
		x=y;
		y=temp;
	}
	public static void Main(){
		
		int x=2,y=3;
		Console.WriteLine("before Swapping:\nx={0} y={1}",x,y);
		ABC.swap(ref x,ref y);
		Console.WriteLine("After Swapping:\nx={0} y={1}",x,y);
		
		//Console.WriteLine("x="+x+" y="+y);
	}
}