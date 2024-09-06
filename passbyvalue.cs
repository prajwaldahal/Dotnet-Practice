using System;
using System.Text;
class Test
{
 static void Foo (StringBuilder fooSB)
 {
 fooSB.Append ("test");
 fooSB = null;
 }
 static void Main()
 {
 StringBuilder sb = new StringBuilder();
 Foo (sb);
 Console.WriteLine (sb.ToString()); // test
 }
}
