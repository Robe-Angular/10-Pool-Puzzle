using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10_Pool_Puzzle
{
    class Kangaroo
    {
        FileStream fs;
        int Croc;
        int Dingo = 0;
        public int Wombat(int Wallaby)
        {
            Dingo ++;
            try
            {
                if(Wallaby > 0)
                {
                    fs = File.OpenWrite("wobbiegong");
                    Croc = 0;
                } else if (Wallaby < 0)
                {
                    Croc = 3;
                }
                else
                {
                    fs = File.OpenRead("wobbiegong");
                    Croc = 1;
                }
            }
            catch(IOException)
            {
                Croc = -3;
            }
            catch
            {
                Croc = 4;
            }
            finally
            {
                if(Dingo> 2)
                {
                    Croc -= Dingo;
                }
            }
            Console.WriteLine(Croc);
            return Croc;
        }
    }
}
