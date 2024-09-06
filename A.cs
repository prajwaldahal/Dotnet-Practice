using System;
class A:Sum{
		public override void add1(int a,int b)
		{
			Console.WriteLine(a+b);
		}
		public override void mul(int a,int b)
		{
			Console.WriteLine((a/(float)b).ToString("0.00"));
		}
		public static void Main()
		{
			Sum s = new A();
			s.add1(1,2);
			s.mul(10,3);
		}
}