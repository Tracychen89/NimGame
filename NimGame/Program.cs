using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimGame
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public bool CanWinNim(int n)
        {
            // if the request is 1-m stones, we can solve this problem by change 4 to m+1

            if (n % 4 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
