using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_24_05_2024
{
    public class A
    {
        public A()
        {
            Console.WriteLine( "Lớp A");
        }   
        public virtual double Tinh()
        {
            return 0;
        }
    }
    public class B : A
    {
        public B() {
            Console.WriteLine("Lớp B");
        }
        public override double Tinh()
        {
            return 10;
        }
    }
    public class C : A
    {
        public C()
        {
            Console.WriteLine("Lớp C");
        }
        public override double Tinh()
        {
            return 20;
        }
    }
    public class D : A
    {
        public D()
        {
            Console.WriteLine("Lớp D");
        }
        public override double Tinh()
        {
            return 30;
        }
    }

    public class QuanLy
    {
        List<A> list = new List<A>();

        public void Nhap()
        {
            list.Add(new B());
            list.Add(new B());
            list.Add(new C());
            list.Add(new C());
            list.Add(new D());
            list.Add(new D());
        }
        public void Xuat()
        {
            double tongB = 0, tongC = 0, tongD = 0;
            for (int i = 0;i < list.Count; i++)
            {
                if (list[i] is B)
                    tongB += list[i].Tinh();
                else if (list[i] is C)
                    tongC += list[i].Tinh();
                else if (list[i] is D)
                    tongD += list[i].Tinh();
            }
            Console.WriteLine($"Tong luong B = {tongB}");
            Console.WriteLine($"Tong luong C = {tongC}");
            Console.WriteLine($"Tong luong D = {tongD}");
        }
    }

}
