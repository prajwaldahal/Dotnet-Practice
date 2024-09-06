using System;
class Demo{
	string[] s="subhanjal is gunda".Split();
	public string this[int ch]{
		get{return s[ch];}
		set{s[ch]=value;}
	}
	
	public static void Main(){
		Demo d = new Demo();
		Console.WriteLine(d[2]);
		d[2]="gunda no 1";
		Console.WriteLine(d[2]);
	}
}