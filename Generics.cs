using System;
public class testGen<T>{
	private T data;
	 public T Data{
		get;
		set;
	 }
}
 public class MainClass{
	 public static void Main(){
		testGen<String> st=new testGen<String>();
		st.value="kcmit";
		Console.WriteLine(st.data);
	 }
 }