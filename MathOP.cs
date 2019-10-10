using System;
namespace ShirZN1
{
    public class MathOP
    {
        private int n1;
        private int n2;
        private char op;
        private double res;

        public MathOP(int nm1,int nm2,char opp)
        {
            this.n1 = nm1; this.n2 = nm2;this.op = opp;
        }

        public int GetN1() => this.n1;
        public int GetN2() => this.n2;
        public char GetOP() => this.op;
        public double GetRes() => this.res;

        public void SetN1(int x) => this.n1 = x;
        public void SetN2(int x) => this.n2 = x;
        public void SetOP(char x) => this.op = x;
        public void SerRes(double x) => this.res = x;

        public void FindRes()
        {
            switch(this.op)
            {
                case '+':
                    this.res = this.n1 + this.n2 + 0.0;
                    break;
                case '-':
                    this.res = this.n1 - this.n2 - 0.0;
                    break;
                case '*':
                    this.res = this.n1 * this.n2 * 1.0;
                    break;
                case '/':
                    if (this.n2 != 0)
                        this.res = this.n1 / this.n2 * 1.0;
                    break;

            }
        }

        public string Stringi()
        {
            string s = " ";
            s += this.n1 + " " + this.op + " " + this.n2 + "=" + this.res;
            return s;
        }
    }
}
