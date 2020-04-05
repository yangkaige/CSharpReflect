using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public string SayHi()
        {
            Console.WriteLine("******************");
            return "abc";
        }
    }
    public class Person
    {
        public string Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public void SayHi()
        {
            Console.WriteLine("你好{0}", this.Name);
        }
    }
    public struct MyStruct
    {
        int i;
        string Name
        {
            get;
            set;
        }
        //event Action MyEvent;
        public MyStruct(int i,string Name)
        {
            this.i = i;
            this.Name = Name;
        }
    }
    enum MyEnum
    {
        one = 1,
        two = 2,
        three = 3
    }
}
