using System;
class Rsa{
	public static void Main(){
			checked{
					double b = Math.Pow(8,35) % 221;
					Console.WriteLine("msg={0}",b);
			
					double c = Math.Pow(b,11) % 221;
					Console.WriteLine("msg={0}",c);
			}
			
			// for(int i=0;i<1000;i++){
				// dynamic c=11 * i % 12;
				
				// if(c == 1)
					// Console.WriteLine("d="+i);
			// }
			
			// for(long i=5;i<200;i+=5){
				// if(i % 12 == 1)
					// Console.WriteLine(i);
			// }
	}
}