using System;
using NewUnit4;

namespace ShirZN1
{
    class MainClass
    {
        public static void NegResults(Node<double>li)
        {
            Node<double> pos = li;
            int count = 0;
            while(pos!=null)
            {
                if (pos.GetValue() < 0.0)
                    count++;
                pos = pos.GetNext();
            }
            Console.WriteLine("There are {0} negative results",count);
        }

        public static void FindResults(Node<MathOP>li)
        {
            Node<MathOP> pos = li;
            while(pos!=null)
            {
                pos.GetValue().FindRes();
                pos = pos.GetNext();
            }
        }

        public static Node<double> MakeResList(Node<MathOP>li)
        {
            Node<double> pos = new Node<double>(li.GetValue().GetRes());
            li = li.GetNext();
            while(li!=null)
            {
                pos = new Node<double>(li.GetValue().GetRes(), pos);
                li = li.GetNext();
            }
            return pos;
        }

        public static Node<MathOP> DelByZero(Node<MathOP>li)
        {
            Node<MathOP> pos = li;
            while ((pos.GetValue().GetN2() == 0) && (pos.GetValue().GetOP() == '/'))
            {
                pos = DelFirst(pos);
                if (pos == null)
                    return null;
            }
            while (pos.HasNext())
            {
                if ((pos.GetNext().GetValue().GetN2()) == 0 && (pos.GetNext().GetValue().GetOP() == '/'))
                {
                    pos.SetNext(pos.GetNext().GetNext());
                }
                pos = pos.GetNext();
            }
            return pos;
        }

        public static Node<MathOP> DelFirst(Node<MathOP>li)
        {
            li = li.GetNext();
            return li;
        }

        public static Node<MathOP> Make_List()
        {
            Console.Write("Num1:");            int num1 = int.Parse(Console.ReadLine());            Console.Write("Num2:");            int num2 = int.Parse(Console.ReadLine());            Console.Write("OP:");            char op = char.Parse(Console.ReadLine());            MathOP mop1 = new MathOP(num1, num2, op);            Node<MathOP> li = new Node<MathOP>(mop1);
            for (int i = 0; i < 2; i++)            {                Console.Write("Num1:");                num1 = int.Parse(Console.ReadLine());                Console.Write("Num2:");                num2 = int.Parse(Console.ReadLine());                Console.Write("OP:");                op = char.Parse(Console.ReadLine());                mop1 = new MathOP(num1, num2, op);                li = new Node<MathOP>(mop1, li);
            }            return li;

        }
        public static void Main(string[] args)
        {
            Node<MathOP> li = Make_List();
            li = DelByZero(li);
            FindResults(li);
            Node<double> li2 = MakeResList(li);
            NegResults(li2);
            
        }
    }
}
