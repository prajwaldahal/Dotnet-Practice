using System.Linq;
using System;
using static System.Console;
class Employee{
	public string name;
	public int salary;
}
class LinqTest{
	public static void Main(){
		Employee []a=new Employee[5];
		for(int i=0;i<5;i++){
			a[i]=new Employee();
			Write("enter a name of employee{0}: ",i+1);
			a[i].name=Console.ReadLine();
			Write($"enter a salary of employee{i+1}: ");
			a[i].salary=Convert.ToInt32(Console.ReadLine());
		}
		 var ResultQS=(from e in a
						where e.salary > 3000 && e.name=="ram"
						select e);
		foreach(var b in ResultQS){
			WriteLine("{0}",b.name);
		 }
	}
}