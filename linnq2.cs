using System.Linq;
using System;
class LinqTest{
	public static void Main(){
		string []a={"an","roshan","padam","pidim","subhanjal","shreya","roshni"};
		var ResultQS=(from name 
							in a
						where name.Length > 3 
						orderby name descending
						select name);
		
			
		foreach(var b in ResultQS){
			Console.WriteLine(b);
		}
	}
}