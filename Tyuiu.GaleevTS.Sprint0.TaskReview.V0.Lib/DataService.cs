using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.GaleevTS.Sprint0.TaskReview.V0.Lib
{
    public class DataService
    {
        public int Calc(int x, int y, int z)
        {
            int res = (x + y + z) * 5;
            return res;
        }
    }
}
