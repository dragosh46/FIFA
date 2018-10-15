using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1.Classes
{
    class SimulareMeci
    {
        public Tuple<int, int> ScorRandom()
        {
            var random = new Random();
            var questions = new List<int>
            {
                0,1,2,3,1,4,0,5,1,2,6,0,7,8,1,2,9,0,1,
            };
            int index = random.Next();

            var t = questions[random.Next(questions.Count)];

            var questions1 = new List<int>
            {
                0,1,2,3,1,0,4,5,1,2,6,7,0,8,1,2,9,0,1,
            };
            int index1 = random.Next();
            var t1 = questions1[random.Next(questions1.Count)];
            return new Tuple<int, int>(t,t1);


        }


    }
}
