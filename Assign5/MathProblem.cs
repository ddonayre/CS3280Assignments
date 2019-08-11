using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign5
{
    public abstract class MathProblem
    {
        public int NumberA { get; set; }
        public int NumberB { get; set; }
        public int Result { get; set; }
        public char Operator { get; set; }
        protected Random rand;

        public MathProblem()
        {
            this.rand = new Random();
        }

        public abstract void GenerateProblem();
         
    }
    public class AdditionProblem : MathProblem
    {
        public override void GenerateProblem()
        {
            this.Operator = '+';
            this.NumberA = this.rand.Next(0, 11);
            this.NumberB = this.rand.Next(0, 11);
            this.Result = NumberA + NumberB;
        }
    }
    public class SubstractionProblem : MathProblem
    {
        public override void GenerateProblem()
        {
            this.Operator = '-';
            this.NumberA = this.rand.Next(0, 11);
            this.NumberB = this.rand.Next(0, 11);
            if (NumberA > NumberB)
                this.Result = NumberA - NumberB;
            else
                this.Result = NumberB - NumberA;
        }

    }

    public class MultiplicationProblem : MathProblem
    {
        public override void GenerateProblem()
        {
            {
                this.Operator = '*';
                this.NumberA = this.rand.Next(0, 11);
                this.NumberB = this.rand.Next(0, 11);
                this.Result = NumberA * NumberB;
            }

        }

    }

    public class DivisionProblem : MathProblem
    {
        public override void GenerateProblem()
        {
            {
                this.Operator = '/';
                this.NumberB = this.rand.Next(1, 11);
                this.Result = this.rand.Next(1, 11);
                this.NumberA = NumberB * Result;
            }
        }
    }






}
//displayProblem()
//  generate mathproblem
//  set labels
//  checkanswer()
//  click_submitbutton()
//   validate input
//   check answer
