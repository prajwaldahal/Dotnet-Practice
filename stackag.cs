using System;
public class stack<t>{
	t[] data=new t[100];
	int index=0;
	public void push(t val){
		data[index]=val;
		index++;
	}
	public  t pop(){
		index--;
		return data[index];
	}
}
public class demo{
	public static void Main(){
		stack<int> s1=new stack<int>();
		s1.push(20);
		s1.push(40);
		d1
		Console.WriteLine(s1.pop());
	}
}
