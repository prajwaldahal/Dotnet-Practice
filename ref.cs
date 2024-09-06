using System;
class ABC{
	public static void ChangeValue(out int sum,out int product){	
		
		int x=2;
		int y=3; 
		sum=x+y;
		product=x*y;
	}
	public static void Main(){
		int sum,product;
		ABC.ChangeValue(out sum, out product);
		Console.WriteLine("Sum={0}",sum);
		Console.WriteLine("product={0}",product);
	}
}