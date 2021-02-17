using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class frmSudoku : Form
    {
        //CancellationTokenSource source;
        Grille g;
        public frmSudoku()
        {
            InitializeComponent();
            g = new Grille(this);
        }

        private async void btnSolve_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            await g.SolveAsync(lblCount, lblTemps, stopWatch);
            await g.ReverseSolveAsync(lblCount, lblTemps, stopWatch);
            stopWatch.Stop();
        }

        private void btnGenerer_Click(object sender, EventArgs e)
        {
            g.Generate(lblCount, lblTemps, Convert.ToInt32(numericUpDown1.Value));
        }

        private void btnNettoyer_Click(object sender, EventArgs e)
        {
            g.Clean(lblCount, lblTemps);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // source.Cancel();
        }

        private void btnSolveSync_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            
            g.Solve(lblCount);
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;
            g.ReverseSolve(lblCount);
            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}H:{1:00}M:{2:00}.{3:000}S",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds);
            lblTemps.Text = "Temps : " + elapsedTime;
        }
    }
}
