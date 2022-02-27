using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SVGQuadConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string SVG = txtSVG.Text;
            string CSS = txtCSS.Text;

            int Left = int.Parse((Regex.Match(CSS, "left: (.*)px;")).Groups[1].Value);
            int Top = int.Parse((Regex.Match(CSS, "top: (.*)px;")).Groups[1].Value);

            var CoordMatches = Regex.Matches(SVG, "([0-9.]*),([0-9.-]*) [ZzCc]");

            string output = string.Empty;

            if (chbTriStr.Checked)
            {
                int i = 0;
                txtOutput.Text += updateOutputStr(i, CoordMatches, Left, Top);
                i = 1;
                txtOutput.Text += updateOutputStr(i, CoordMatches, Left, Top);
                i = 3;
                txtOutput.Text += updateOutputStr(i, CoordMatches, Left, Top);
                i = 2;
                txtOutput.Text += updateOutputStr(i, CoordMatches, Left, Top);
            }
            else
            {
                for (int i = 0; i < CoordMatches.Count - 1; i++)
                {
                    txtOutput.Text += updateOutputStr(i, CoordMatches, Left, Top);
                }
            }

        }

        private string updateOutputStr(int i, MatchCollection CoordMatches, int Left, int Top)
        {
            Match match = CoordMatches[i];
            string g1 = match.Groups[1].Value;
            g1.Replace(".000", ".0");
            string g2 = match.Groups[2].Value;
            g2.Replace(".000", ".0");

            double ig1 = double.Parse(g1); double ig2 = double.Parse(g2);
            ig1 += Left; ig2 += Top;

            return string.Format("{0}, {1},{2}", ig1, ig2, Environment.NewLine);
        }
    }
}
