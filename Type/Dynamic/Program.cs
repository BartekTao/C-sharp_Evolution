//#define example1  //動態型別只存在於編譯時期
//#define example2 //動態型別在編譯期間不會出錯
//#define example3 //example2的出錯範例
//#define example4 //繼承DynamicObject簡單範例
#define example5 //應用於反射，速度提升、程式碼簡短 (C# 4.0)
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Dynamic
{
    class Program
    {
#if example1
        static void Main(string[] args)
        {
            dynamic dyn = 1;
            object obj = 1;

            // Rest the mouse pointer over dyn and obj to see their
            // types at compile time.
            System.Console.WriteLine(dyn.GetType());
            System.Console.WriteLine(obj.GetType());
        }
#endif

#if example2
        static void Main(string[] args)
        {
            dynamic dynInt = 1;
            dynamic dynString = "thisIsString";
            int intValue = 1;

            addValue(intValue);
            addValue(dynInt);
            addValue(dynString);
#if example3
            string stringValue = "thisIsAnotherString";
            addValue(stringValue);
#endif

            static void addValue(int value)
            {
                Console.WriteLine(value + value);
            }
        }
#endif

#if example4
        static void Main(string[] args)
        {
            dynamic d = CreateDynamicObject();

            Console.WriteLine("Prop1: {0}", d.Prop1);
            Console.WriteLine("Prop2: {0}", d.Prop2);
            Console.WriteLine("Prop3: {0}", d.Prop4[0]);
            Console.WriteLine("PropX: {0}", d.PropX);

            d.InvokeVoid();
            var e = d.InvokeAdd(1, 2);

            Console.WriteLine("e={0}", e);


            //進行 10000000 次的比較，可以展顯出兩者差異
            string rateResult = Compare(10000000);
            Console.WriteLine(rateResult);
            Console.Read();
        }

        static dynamic CreateDynamicObject()
        {
            dynamic d = new MyDynamicObject();

            // assign property
            d.Prop1 = 1;
            d.Prop2 = 2;
            d.Prop3 = 3;
            d.Prop4 = new List<string>();
            d.Prop4.Add("5");

            // assign void method.
            d.InvokeVoid = new Action(() => Console.WriteLine("InvokeVoid."));

            // assign returnable method.
            d.InvokeAdd = new Func<int, int, int>((a, b) => a + b);

            return d;
        }
        public class MyDynamicObject : DynamicObject
        {
            private IDictionary<string, object> _objectMembers = new Dictionary<string, object>();

            public override bool TryGetMember(GetMemberBinder binder, out object result)
            {
                if (!this._objectMembers.ContainsKey(binder.Name))
                {
                    result = null;
                    return true;
                }
                else
                {
                    result = this._objectMembers[binder.Name];
                    return true;
                }
            }

            public override bool TrySetMember(SetMemberBinder binder, object value)
            {
                if (!this._objectMembers.ContainsKey(binder.Name))
                {
                    this._objectMembers.Add(binder.Name, value);
                    return true;
                }
                else
                {
                    this._objectMembers[binder.Name] = value;
                    return true;
                }
            }
        }
#endif

#if example5

        static void Main(string[] args)
        {
            //進行 10000000 次的比較，可以展顯出兩者差異
            string rateResult = Compare(10000000);
            Console.WriteLine(rateResult);
        }
        /// <summary>
        /// 範例類別
        /// </summary>
        public class DyamicSample
        {
            public string Name { get; set; }

            public int Add(int a, int b)
            {
                return a + b;
            }


        }

        /// <summary>
        /// 比較反射與Dynamic的速度差異
        /// </summary>
        public static string Compare(int times)
        {
            string resultMessage = string.Empty;

            //----------以下是反射
            //建立碼表計時器
            Stopwatch sw = new Stopwatch();
            DyamicSample origin = new DyamicSample();
            var addMetohd = typeof(DyamicSample).GetMethod("Add");

            sw.Restart();
            for (int i = times; i > 0; i--)
            {
                addMetohd.Invoke(origin, new object[] { 1, 2 });
            }
            resultMessage += string.Format("反射(Reflect)耗費：{0} 毫秒  \r\n", sw.ElapsedMilliseconds);
            sw.Stop();

            //----------以下是反射 優化
            DyamicSample originPeformance = new DyamicSample();
            var addMetohdPeformance = typeof(DyamicSample).GetMethod("Add");
            //優化部分-執行委派 FCL 3.0提供以下方法
            var delegateObj = (Func<DyamicSample, int, int, int>)Delegate.CreateDelegate(
                   typeof(Func<DyamicSample, int, int, int>),
                   addMetohdPeformance
                );

            sw.Restart();
            for (int i = times; i > 0; i--)
            {
                delegateObj(originPeformance, 1, 2);
            }
            resultMessage += string.Format("反射優化(Reflect)耗費：{0} 毫秒  \r\n", sw.ElapsedMilliseconds);
            sw.Stop();


            dynamic dynamicObj = new DyamicSample();
            //----------以下是Dynamic
            sw.Restart();
            for (int i = times; i > 0; i--)
            {
                dynamicObj.Add(1, 2);
            }
            resultMessage += string.Format("Dynamic 耗費：{0} 毫秒  \r\n", sw.ElapsedMilliseconds);
            sw.Stop();


            return resultMessage;
        }
#endif

    }
}
