using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1505_Part4_Q2
{
    class Rational
    {
        int mone;
        int mechane;
        double rationalNumber;
        public Rational(int mone, int mechane)
        {
            this.mone = mone;
            this.mechane = mechane;

            if ((mone % 1 == 0) && (mechane > 0))
            {
                rationalNumber = ((double)(mone / mechane));
            }
            else
                rationalNumber = 0;
        }

        public bool greaterThan(Rational rationalNum)
        {
            return ((this.mone * rationalNum.mechane) > (this.mechane * rationalNum.mone));
        }

        public bool equals (Rational rationalNum)
        {
            return ((this.mone * rationalNum.mechane) == (this.mechane * rationalNum.mone));
        }

        public Rational plus(Rational rNum)
        {
            return (new Rational(((this.mone * rNum.mechane) + (this.mechane * rNum.mone)) , (this.mechane * rNum.mechane)));
        }

        public Rational minus(Rational rNum)
        {
            return (new Rational(((this.mone * rNum.mechane) - (this.mechane * rNum.mone)), (this.mechane * rNum.mechane)));
        }

        public Rational multiply(Rational rNum)
        {
            return (new Rational(((this.mone * rNum.mone)), (this.mechane * rNum.mechane)));
        }

        public int GetNumerator()
        {
            return this.mone;
        }

        public int getDenominator()
        {
            return this.mechane;
        }

        public override string ToString()
        {
            return $"Mone is {mone}, Mechane is {mechane} The number is: {mone}/{mechane}.";
        }
    }
}
