using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BubblesortExercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> lista = new List<int>();
        int comparisons = 0;
        int changes = 0;
        int aux = 0;
        

        private void BubbleClick(object sender, EventArgs e)
        {
         Stopwatch time = new Stopwatch();
            time.Start();
            
                    for (int write = 0; write < name.Length; write++)
                    {
                        for (int sort = 0; sort < name.Length - 1; sort++)
                        {
                            comparisons++;
                            if (name[sort] > name[sort + 1])
                            {
                                aux = name[sort + 1];
                                name[sort + 1] = name[sort];
                                name[sort] = aux;
                                changes++;
                            }
                        }
                    }
            
            time.Stop();
         
        }
    }
}
