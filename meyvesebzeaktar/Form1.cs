using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meyvesebzeaktar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            for (int i=0; i<lstYiyecekler.Items.Count; i++)
                if (lstYiyecekler.Items[i].ToString()=="kiraz"||
                    lstYiyecekler.Items[i].ToString() == "erik" ||
                    lstYiyecekler.Items[i].ToString() == "çilek")
                {
                    lstMeyve.Items.Add(lstYiyecekler.Items[i]);
                }
                else
                {
                    lstSebze.Items.Add(lstYiyecekler.Items[i]);
                }
            }
        }
    }

