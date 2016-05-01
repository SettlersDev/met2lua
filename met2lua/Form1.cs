using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace met2lua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbOut_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length != 1 || Path.GetExtension(files[0]) != ".met")
            {
                MessageBox.Show("Please drop ONE .met file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string[] lines = File.ReadAllLines(files[0]);
            Size[] chars = new Size[256];
            int validHeight = -1;

            for (int ln = 4; ln < lines.Length; ln++)
            {
                string[] pieces = lines[ln].Split(new char[] { '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (pieces.Length < 5)
                    continue;
                int ascii = int.Parse(pieces[0]);
                if (ascii >= 256)
                    break;

                Size chr = new Size(
                    1 + int.Parse(pieces[3]) - int.Parse(pieces[1]),
                    1 + int.Parse(pieces[4]) - int.Parse(pieces[2]));
                chars[ascii] = chr;

                if (chr.Height > validHeight)
                    validHeight = chr.Height;
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("font = {{\r\n\theight = {0},\r\n\twidths = [\r\n\t\t", validHeight)); 
            for (int c = 0, ln = 0; c < 256; c++, ln++)
            {
                if (ln == 16)
                {
                    ln = 0;
                    sb.Append("\r\n\t\t");
                }

                if (chars[c] != null)
                {
                    if (chars[c].Width < 10)
                        sb.Append(' ');
                    sb.Append(chars[c].Width);
                }
                else
                    sb.Append(" 0");

                if (c != 255)
                    sb.Append(", ");
            }

            sb.Append("\r\n\t]\r\n}");
            tbOut.Text = sb.ToString();
        }

        private void tbOut_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }
    }

    public class Size
    {
        public int Width;
        public int Height;
        public Size(int width, int height)
        {
            this.Height = height;
            this.Width = width;
        }
    }
}
