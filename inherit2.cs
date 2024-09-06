using System;

class Andriodos{
	public void textmsg(){
		Console.WriteLine("here is text mdg");
	}
	public void phne(){}
	public void mutiplecontrol(){}
}

class Miui:Andriodos{
	public void youtubebg(){
		Console.WriteLine("moj gar");
	}
}

class Test{
	public static void Main(){
		Andriodos a = new Andriodos();
		Miui mi = new Miui();
	
	    a=mi;
		a.youtubebg();
	
	    mi = (Miui)a;
		a.textmsg();2
		mi.youtubebg();
	}
}