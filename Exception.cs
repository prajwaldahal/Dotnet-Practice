using System;
class Generate1{
	public static int divide10(int x){
		return 10/x;
	}
	public static void Main(){
			try{
				Console.WriteLine(divide10(0));
			}catch(DivideByZeroException e){
				Console.WriteLine(e.Message);
			}
	}
}

class Generate2{
	public static void Main(){
			try{
				int []a={1,2,3,4};
				Console.WriteLine(a[0]);
				Console.WriteLine(a[4]); //yesle xia exception create garxa 4 index nia  xiana
			}catch(IndexOutOfRangeException e){
				Console.WriteLine(e.Message);
			}
	}
}