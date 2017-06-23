using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrewingLog
{
    public partial class Brew : Form
    {
        private float m_priming = 0.5f;
        private float m_multiplier = 7.36f;

        private Beer beer;

        public float Priming
        {
            get
            {
                return m_priming;
            }

            set
            {
                m_priming = value;
            }
        }

        public float Multiplier
        {
            get
            {
                return m_multiplier;
            }

            set
            {
                m_multiplier = value;
            }
        }

        public Brew()
        {
            InitializeComponent();
        }

        public Brew(Beer b)
        {
            InitializeComponent();

            bnTb.Text = "" + b.ID;
            styTb.Text = b.Style;
            brTb.Text = b.Brand;
            fermTb.Text = b.Fermentables;
            abvTb.Text = "" + b.ABV;
            ogTb.Text = "" + b.OG;
            fgTb.Text = "" + b.FG;

            Date s = b.StartDate;
            sdDay.Value = s.GetDay();
            sdMonth.Value = s.GetMonth();
            sdYear.Value = s.GetYear();

            Date f = b.FinishingDate;
            fdDay.Value = f.GetDay();
            fdMonth.Value = f.GetMonth();
            fdYear.Value = f.GetYear();

            typeTb.Text = b.HopsType;
            meTb.Text = b.Method;
            blTb.Text = b.BrewLength;
            liTb.Text = "" + b.Litres;
            comTb.Text = b.Comments;

            beer = new Beer(b);
        }

        public Beer CreateBeer()
        {
            Beer b = new Beer();

            b.ID = ulong.Parse(bnTb.Text);
            b.Style = styTb.Text;
            b.Brand = brTb.Text;
            b.Fermentables = fermTb.Text;

            if (abvTb.Text != "")
            b.ABV = (float.Parse(abvTb.Text));

            b.OG = float.Parse(ogTb.Text);

            if(fgTb.Text != "")
                b.FG = float.Parse(fgTb.Text);

            Date s = new Date(Int32.Parse("" + sdDay.Value), Int32.Parse("" + sdMonth.Value), Int32.Parse("" + sdYear.Value));
            Date f = new Date(Int32.Parse("" + fdDay.Value), Int32.Parse("" + fdMonth.Value), Int32.Parse("" + fdYear.Value));
            b.StartDate = s;
            b.FinishingDate = f;

            b.HopsType = typeTb.Text;
            b.Method = meTb.Text;
            b.BrewLength = blTb.Text;

            if(liTb.Text != "")
                b.Litres = float.Parse(liTb.Text);

            b.Comments = comTb.Text;

            return b;
        }

        private void ClearForm()
        {
            bnTb.Text = "";
            styTb.Text = "";
            brTb.Text = "";
            fermTb.Text = "";
            abvTb.Text = "";
            ogTb.Text = "";
            fgTb.Text = "";
            sdDay.Value = sdMonth.Value = sdYear.Value = 1;
            fdDay.Value = fdMonth.Value = fdYear.Value = 1;

            typeTb.Text = "";
            meTb.Text = "";
            blTb.Text = "";
            liTb.Text = "";
            comTb.Text = "";
        }

        private void svBtn_Click(object sender, EventArgs e)
        {
            int n;
            float m;
            bool bn = false, abv = false, og = false, fg = false, li = false;

            if (Int32.TryParse(bnTb.Text, out n))
            {
                bn = true;
            }

            if (float.TryParse(ogTb.Text, out m))
            {
                og = true;
            }

            if (float.TryParse(fgTb.Text, out m))
            {
                fg = true;
            }

            if (fgTb.Text == "")
                fg = true;


            if (float.TryParse(abvTb.Text, out m))
            {
                abv = true;
            }

            if (abvTb.Text == "")
            {
                abv = true;
            }

            if (float.TryParse(liTb.Text, out m))
            {
                li = true;
            }

            if (liTb.Text == "")
            {
                li = true;
            }

            if (og && fg && bn && abv && li)
            {
                beer = new Beer(CreateBeer());

                string folder = "brewing/", pathstring = "BrewingID" + beer.ID + ".beer";

                Serial<Beer>.Save(beer, pathstring, folder);

                MessageBox.Show("Saved as: " + folder + pathstring);
            }
            else
            {
                MessageBox.Show("Please ensure all numeric values are set correctly.\n\n" +
                                "Brew Number, Original Gravity, Final Gravity (can be empty),\nLitres (can be empty), Alcoholic Percentage (can be empty).");
            }
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void Calculate()
        {
            float res = 0;
            float og, fg;

            if (fgTb.Text != "")
            {
                if (float.TryParse(ogTb.Text, out og))
                {
                    if (float.TryParse(fgTb.Text, out fg))
                    {
                        res = og - fg;
                        res /= m_multiplier;
                        res += m_priming;

                        res = (float)Math.Round(res, 2, MidpointRounding.AwayFromZero);
                    }
                }
            }

            if (beer != null)
            {
                beer.ABV = res;

                beer = new Beer(beer);
            }

            abvTb.Text = "" + res;
        }

        private void calABVBtn_Click(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
