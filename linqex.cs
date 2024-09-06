using System;
using System.Linq;
using System.Collections.Generic;

class Employee{
	public string name;
	public int age;
	public string id;
	public string addr;
	public double salary;
	
}
class Demo{
	List<Employee> e = new List<Employee>();
	for(i=0;i<5;i++){
		Employee e1 = new Employee();
		
		Console.WriteLine("enter a name");
		e1.name=Console.ReadLine();
		Console.WriteLine("enter a age");
		e1.age=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("enter a id");
		e1.id=Console.ReadLine();
		Console.WriteLine("enter a address");
		e1.addr=Console.ReadLine();
		Console.WriteLine("enter a salary");
		e1.salary=Convert.ToDouble(Console.ReadLine());
		
		e.add(e1);
	}
	var x=
	
}