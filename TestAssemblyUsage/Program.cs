using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace TestAssemblyUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = Assembly.LoadFile(@"D:\testspace\c#pro\TestAssemblyUsage\ClassLibrary1\bin\Debug\ClassLibrary1.dll");
            //获取该程序集下所有的类型信息
            //Type[] types = asm.GetTypes();
            //foreach (var item in types)
            //{
            //    Console.WriteLine(item.Name);
            //}
            //获取所有公有的类型信息
            //Type[] types = asm.GetExportedTypes();
            //foreach (var item in types)
            //{
            //    Console.WriteLine(item.Name);
            //}
            //获取程序集中指定类的类型信息
            Type type = asm.GetType("ClassLibrary1.Person");
            //创建该类型的一个实例 
            //object obj = Activator.CreateInstance(type);
            ConstructorInfo constructorInfo = type.GetConstructor(new Type[] { });
            object obj = constructorInfo.Invoke(null);
            //获取该类的属性元数据，并给其赋值
            PropertyInfo propertyInfo = type.GetProperty("Name");
            propertyInfo.SetValue(obj, "AAA");
            //获取该属性的值
            Console.WriteLine(propertyInfo.GetValue(obj));
            //调用该实例方法
            MethodInfo methodInfo = type.GetMethod("SayHi");
            methodInfo.Invoke(obj, null);
            Console.ReadKey();
        }
    }
}
