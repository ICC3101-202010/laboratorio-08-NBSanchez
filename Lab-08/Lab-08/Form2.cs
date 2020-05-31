using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_08
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           

        }
        List<string> nomtienda = new List<string>();
        List<string> nomresta = new List<string>();
        List<string> nomcine = new List<string>();
        List<string> nomrecre = new List<string>();
        List<string> allnom = new List<string>();
       

        public void SetNomTi(List<string> nomtienda )

        {
            this.nomtienda = nomtienda;
            for (int x = 0; x < nomtienda.Count(); x++)
            {
                allnom.Add(nomtienda[x]);
            }


        }
        public void SetNomRe(List<string> nomresta)
        {
            this.nomresta = nomresta;
            for (int x = 0; x < nomresta.Count(); x++)
            {
                allnom.Add(nomresta[x]);
            }
        }
        public void SetNomCi(List<string> nomcine)
        {
            this.nomcine = nomcine;
            for (int x = 0; x < nomcine.Count(); x++)
            {
                allnom.Add(nomcine[x]);
            }
        }
        public void SetNomRec(List<string> nomrecre)
        {
            this.nomrecre = nomrecre;
            for (int x = 0; x < nomrecre.Count(); x++)
            {
                allnom.Add(nomrecre[x]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            for (int x = 0; x < allnom.Count(); x++)
            {
                tb_todaslocal.Text = tb_todaslocal.Text + i + "  " + allnom[x] + "\n";
                i++;
            }
        }
    }
}
