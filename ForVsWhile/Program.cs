using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics; 

using System.Text;

namespace ForVsWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;
            Stopwatch st= new Stopwatch();
            st.Start();
            for (j = 0; j < 100; j++)
            {

                j = j * 2;

            }
            st.Stop();
            Console.WriteLine(st.ElapsedTicks.ToString());
            st.Reset();

            st.Start();
            j = 0;
            while(j<100)

            {

                j = j * 2;
                j++;

            }
            st.Stop();
            Console.WriteLine(st.ElapsedTicks.ToString());
        }
    }
}
