using System;
public class Stack<T>{
	int index=0;
	T []data= new T[5];
	public void push(T val){
		data[index]=val;
		index++;
	}
	public T pop(){
		return data[--index];
	}
}
class Demo{
	public static void Main(){
		Stack<int> s= new Stack<int>();
		s.push(10);
		s.push(20);
		Console.WriteLine(s.pop());
		
		Stack<string> sw=  new Stack<string>();
		sw.push("hello");
		sw.push("subhanjal gunda");
		Console.WriteLine(sw.pop());
		Console.WriteLine(sw.pop());
	}
}