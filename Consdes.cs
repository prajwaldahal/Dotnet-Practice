using System;
using static System.Console;
class Member  
{  
    public Member()  
    {  
        Console.WriteLine("Default Constructor was called.");  
    }  
    public Member(string name)  
    {  
        Console.WriteLine("Parameterized Constructor was called.");  
    }  
    ~Member()  
    {  
        Console.WriteLine("Destructor was called.");  
    }  
	public static void Main(){
		Member m = new Member();
		Member m1 = new Member("Hello");
	}
}   