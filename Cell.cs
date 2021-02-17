using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Value { get; set; }
        public TextBox Tbx { get; }

        public Cell(int X, int Y, int Width, int Value, Form frm)
        {
            this.X = X;
            this.Y = Y;
            this.Width = Width;
            this.Value = Value;
            Tbx = new TextBox();
            Tbx.Multiline = true;
            Tbx.Name = X + "" + Y;
            Tbx.Size = new Size(new Point(Width, Width));
            Tbx.MaxLength = 1;
            Tbx.TextAlign = HorizontalAlignment.Center;
            Tbx.Font = new Font("Microsoft Sans Serif",Width/2);

            Tbx.TextChanged += new EventHandler(Tbx_TextChanged); 

            //Tbx.Location = new Point((X/3) * Width, (Y/3) * Width);
            Tbx.Location = new Point(X * Width, Y * Width);
            //MessageBox.Show($"XY:{X},{Y} XY%3: {X % 3},{Y % 3}");
            if (Value != -1) {
                Tbx.Enabled = false;
                Tbx.Text = Value.ToString();
            }
            //Panel.Controls.Add(Tbx);
            frm.Controls.Add(Tbx);
        }

        protected void Tbx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Value = Convert.ToInt32(Tbx.Text);
            }
            catch
            {
                Value = -1;
            }
        }
    }
}
