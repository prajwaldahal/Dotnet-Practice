using System.Linq;
using System;
class LinqTest{
	public static void Main(){
		int []a={45,2,1,87,34};
		var ResultQS=(from num in a
						where num > 3 
						orderby num ascending
						select num );
		foreach(int n in ResultQS){
			Console.WriteLine("{0}",n);
		}
	}
}