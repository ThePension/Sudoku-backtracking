using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public class Grille
    {
        public Cell[,] Cells { get; set; }
        public int Count { get; set; }

        public Grille(Form frm)
        {
            Cells = new Cell[9,9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Cells[i, j] = new Cell(i, j, 50, -1, frm);
                    Cells[i, j].Tbx.TextChanged += new EventHandler(Cell_ValueChanged);
                }
            }
        }
        public bool Possible(int xCell, int yCell, int val)
        {
            for (int x = 0; x < 9; x++)
            {
                // Lignes
                if (Cells[x, yCell].Value == val && x != xCell) return false;
                // Colonnes
                if (Cells[xCell, x].Value == val && x != yCell) return false;
            }

            // Carrés
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (Cells[(int)Math.Floor(xCell / 3.0)*3 + x, (int)Math.Floor(yCell / 3.0)*3 + y].Value == val && (int)Math.Floor(xCell / 3.0) * 3 + x != xCell && (int)Math.Floor(yCell / 3.0) * 3 + y != yCell) return false;
                }
            }

            return true;
        }
        protected void Cell_ValueChanged(object sender, EventArgs e)
        {
            TextBox tbx = (TextBox)sender;
            try
            {
                int x = Convert.ToInt32(tbx.Name.Substring(0, 1));
                int y = Convert.ToInt32(tbx.Name.Substring(1, 1));
                int val = Convert.ToInt32(tbx.Text);
                if (!Possible(x, y, val))
                {
                    tbx.BackColor = Color.Red;
                }
            }
            catch
            {
                tbx.BackColor = TextBox.DefaultBackColor;
            }
        }
        public bool Solve(Label lblCount)
        {
            Count++;
            //cancellationToken.ThrowIfCancellationRequested();
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    if (Cells[x, y].Value == -1) {
                        for (int n = 1; n < 10; n++)
                        {
                            if (Possible(x, y, n))
                            {
                                Cells[x, y].Value = n;
                                Cells[x, y].Tbx.Text = n.ToString();
                                if (Solve(lblCount))
                                    return true;
                                else
                                {
                                    Cells[x, y].Value = -1;
                                    Cells[x, y].Tbx.Text = "";
                                }
                            }
                        }
                        return false;
                    }
                }
            }
            lblCount.Text = "Nombre d'essais : " + Count;
            return true;
        }
        public bool ReverseSolve(Label lblCount)
        {
            Count++;
            //cancellationToken.ThrowIfCancellationRequested();
            for (int x = 9; x < 0; x--)
            {
                for (int y = 9; y < 0; y--)
                {
                    if (Cells[x, y].Value == -1)
                    {
                        for (int n = 1; n < 10; n++)
                        {
                            if (Possible(x, y, n))
                            {
                                Cells[x, y].Value = n;
                                Cells[x, y].Tbx.Text = n.ToString();
                                if (Solve(lblCount))
                                    return true;
                                else
                                {
                                    Cells[x, y].Value = -1;
                                    Cells[x, y].Tbx.Text = "";
                                }
                            }
                        }
                        return false;
                    }
                }
            }
            lblCount.Text = "Nombre d'essais : " + Count;
            return true;
        }
        public async Task<bool> SolveAsync(Label lblCount, Label lblTemps, Stopwatch stopWatch/*CancellationToken cancellationToken*/)
        {
            Count++;
            lblCount.Text = "Nombre d'essais : " + Count;
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}H:{1:00}M:{2:00}.{3:000}S",
               ts.Hours, ts.Minutes, ts.Seconds,
               ts.Milliseconds);
            lblTemps.Text = "Temps : " + elapsedTime;
            //cancellationToken.ThrowIfCancellationRequested();
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    if (Cells[x, y].Value == -1)
                    {
                        for (int n = 1; n < 10; n++)
                        {
                            if (Possible(x, y, n))
                            {
                                Cells[x, y].Value = n;
                                Cells[x, y].Tbx.Text = n.ToString();
                                await Task.Delay(TimeSpan.FromMilliseconds(1));
                                if (await SolveAsync(lblCount, lblTemps, stopWatch))
                                    return true;
                                else
                                {
                                    Cells[x, y].Value = -1;
                                    Cells[x, y].Tbx.Text = "";
                                }
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }
        public async Task<bool> ReverseSolveAsync(Label lblCount, Label lblTemps, Stopwatch stopWatch/*CancellationToken cancellationToken*/)
        {
            Count++;
            lblCount.Text = "Nombre d'essais : " + Count;
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}H:{1:00}M:{2:00}.{3:000}S",
               ts.Hours, ts.Minutes, ts.Seconds,
               ts.Milliseconds);
            lblTemps.Text = "Temps : " + elapsedTime;
            //cancellationToken.ThrowIfCancellationRequested();
            for (int x = 8; x >= 0; x--)
            {
                for (int y = 8; y >= 0; y--)
                {
                    if (Cells[x, y].Value == -1)
                    {
                        for (int n = 1; n < 10; n++)
                        {
                            if (Possible(x, y, n))
                            {
                                Cells[x, y].Value = n;
                                Cells[x, y].Tbx.Text = n.ToString();
                                await Task.Delay(TimeSpan.FromMilliseconds(1));
                                if (await ReverseSolveAsync(lblCount, lblTemps, stopWatch))
                                    return true;
                                else
                                {
                                    Cells[x, y].Value = -1;
                                    Cells[x, y].Tbx.Text = "";
                                }
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }
        public void Clean(Label lbl, Label lblTemps)
        {
            lblTemps.Text = "Temps : ";
            lbl.Text = "Nombre d'essais : ";
            Count = 0;
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    Cells[x, y].Value = -1;
                    Cells[x, y].Tbx.Text = "";
                }
            }
        }

        public void Generate(Label lbl, Label lblTemps, int max)
        {
            Clean(lbl, lblTemps);
            int count = 0,r,x,y;
            do
            {
                Random rand = new Random();
                x = rand.Next(0, 9);
                y = rand.Next(0, 9);
                if (Cells[x, y].Value == -1)
                {
                    r = rand.Next(1, 10);
                    if (Possible(x, y, r))
                    {
                        Cells[x, y].Value = r;
                        Cells[x, y].Tbx.Text = r.ToString();
                        count++;
                    }
                }

            } while (count != max);
        }
    }
}
