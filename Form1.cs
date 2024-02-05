using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Pool_Puzzle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kangaroo Joey = new Kangaroo();
            int Koala = Joey.Wombat(
                Joey.Wombat(Joey.Wombat(1)));
            try
            {
                Console.WriteLine((15 / Koala) + "eggs per pound");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("G'Day Mate!");
            }
        }
    }
}
