using System;
class UnderAgeException:Exception{
	public UnderAgeException(){
		
	}
	public UnderAgeException(string message):base(message)
	{
		
	}
}
class Demo{
	public static void Main(){
		int age=Convert.ToInt32(Console.ReadLine());
		try{
			if(age<18)
				throw new UnderAgeException("you cannot vote");
			else
				Console.WriteLine("you can vote");
		}
		catch(UnderAgeException ex){
			Console.WriteLine(ex.Message);
		}
	}
}