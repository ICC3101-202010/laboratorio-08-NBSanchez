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
    public partial class Form1 : Form

    {
        List<string> nomtienda = new List<string>() { "HYM", "HASBRO", "VICTORIA SECRETS" };
        List<string> duetienda = new List<string>() { "EMILIA CLARK", "JAMES CORDEL", "VICTORIA BROOKS" };
        List<string> hortienda = new List<string>() { "09:00-19:30", "10:00-21:00", "09:00-9:30" };
        List<string> cattienda = new List<string>() { "ROPA", "INFANTIL", "ROPA-MUJER" };
        List<int> idtienda = new List<int>() { 123, 206, 324 };
        List<string> nomresta = new List<string>() { "CHILLIS", "TIP Y TAP", "BAR DANES" };
        List<string> dueresta = new List<string>() { "PETER JACKSON", "ELTHON JOHN", "JIMMY PRAT" };
        List<string> horresta = new List<string>() { "09:00-19:30", "10:00-21:00", "09:00-9:30" };
        List<string> mesaresta = new List<string>() { "SI", "NO", "SI" };
        List<int> idresta = new List<int>() { 124, 506, 325 };
        List<string> nomcine = new List<string>() { "CINE HOYTS", "CINE MARK", "CINE PLANET" };
        List<string> duecine = new List<string>() { "ELON MUSK", "BARACK OBAMA", "BILL CLINTON" };
        List<string> horcine = new List<string>() { "09:00-19:30", "10:00-21:00", "09:00-9:30" };
        List<string> salascine = new List<string>() { "SI", "NO", "SI" };
        List<int> idcine = new List<int>() { 24, 708, 408 };
        List<string> nomrecre = new List<string>() { "EASY", "MAC", "BARBIE" };
        List<string> duerecre = new List<string>() { "JACK BLACK", "STEVE JOBS", "BARBARA WINTER" };
        List<string> horrecre = new List<string>() { "09:00-19:30", "10:00-21:00", "09:00-9:30" };
        List<int> idrecre = new List<int>() { 78, 288, 692 };





        Form2 form2 = new Form2();
        
        public Form1()
        {
            InitializeComponent();
            pn1_crearlocal.Hide();
            pn_craertienda.Hide();
            pn_crearcine.Hide();
            pn_crearresta.Hide();
            pn_crearrecre.Hide();
   
        }
        
        
       
        private void bt_crearlocal_Click(object sender, EventArgs e)
        {
            pn1_crearlocal.Show();
        }
        private void bt_listadetiendas_Click(object sender, EventArgs e)
        {
            
            form2.Show();
            form2.SetNomTi(nomtienda);
            form2.SetNomRe(nomresta);
            form2.SetNomCi(nomcine);
            form2.SetNomRec(nomrecre);
        }

        private void bt_creartiendo_Click(object sender, EventArgs e)
        {
            pn_craertienda.Show();
            
        }
        private void bt_crearrestaurante_Click(object sender, EventArgs e)
        {

            
            pn_crearresta.Show();
            
        }
        private void bt_backhome_Click(object sender, EventArgs e)
        {
            pn1_crearlocal.Hide();

        }

        private void bt_backtienda_Click(object sender, EventArgs e)
        {
            pn_craertienda.Hide();
            lb_exitotienda.Visible = false;
            lb_intienda.Visible = false;
            tb_nombretienda.Text = "";
            tb_nombredueñotienda.Text = "";
            tb_horarioatenciontienda.Text = "";
            tb_tiencategoria.Text = "";
        }

        private void bt_backresta_Click(object sender, EventArgs e)
        {
            pn_crearresta.Hide();
            lb_exitoresta.Visible = false;
            lb_inrest.Visible = false;
            tb_nombrerestaurante.Text = "";
            tb_nombredueñorestaurante.Text = "";
            tb_horarioatencionresta.Text = "";
            tb_tipomesaresta.Text = "";
        }

        private void bt_backcine_Click(object sender, EventArgs e)
        {
            pn_crearcine.Hide();
            lb_exitocine.Visible = false;
            lb_incine.Visible = false;
            tb_nombrecine.Text = "";
            tb_dueñocine.Text = "";
            tb_horarioatencioncine.Text = "";
            tb_cantidadsalascine.Text = "";

        }

        private void bt_crearcine_Click(object sender, EventArgs e)
        {
            pn_crearcine.Show();
        }

        private void bt_backrecrea_Click(object sender, EventArgs e)
        {
            pn_crearrecre.Hide();
            lb_crexito.Visible = false;
            lb_inrecrea.Visible = false;
            tb_nombrerecrea.Text = "";
            tb_dueñorecrea.Text = "";
            tb_horarioatencionrecrea.Text = "";
            

        }

        private void bt_crearrecreacional_Click(object sender, EventArgs e)
        {
            pn_crearrecre.Show();
        }

        private void bt_verlocal_Click(object sender, EventArgs e)
        {
            pn_todoslocales.Visible = true;

            
        }

        

        private void bt_creartienda_Click(object sender, EventArgs e)
        {
            if (tb_nombretienda.Text == "" || tb_nombredueñotienda.Text == "" || tb_horarioatenciontienda.Text == "" || tb_tiencategoria.Text == "")
            {
                lb_intienda.Visible = true;
            }

            else
            {
                Random random = new Random();
                lb_exitotienda.Visible = true;
                nomtienda.Add(tb_nombretienda.Text);
                duetienda.Add(tb_nombredueñotienda.Text);
                hortienda.Add(tb_horarioatenciontienda.Text);
                cattienda.Add(tb_tiencategoria.Text);
                idtienda.Add(random.Next(100, 400));

                form2.SetNomTi(nomtienda);
            }
        }

        private void bt_crearcine2_Click(object sender, EventArgs e)
        {
            if (tb_nombrecine.Text == "" || tb_dueñocine.Text == "" || tb_horarioatencioncine.Text == "" || tb_cantidadsalascine.Text == "")
            {
                lb_incine.Visible = true;
            }
            else
            {
                lb_exitocine.Visible = true;
                Random random = new Random();
                nomcine.Add(tb_nombrecine.Text);
                duecine.Add(tb_dueñocine.Text);
                horcine.Add(tb_horarioatencioncine.Text);
                salascine.Add(tb_cantidadsalascine.Text);
                idcine.Add(random.Next(0, 1000));
                form2.SetNomCi(nomcine);

            }

        }

        private void bt_crearrecrea_Click(object sender, EventArgs e)
        {
            if (tb_nombrerecrea.Text == "" || tb_dueñorecrea.Text == "" || tb_horarioatencionrecrea.Text == "" )
            {
                lb_inrecrea.Visible = true;
            }
            else
            {
                lb_crexito.Visible = true;
                Random random = new Random();
                nomrecre.Add(tb_nombrerecrea.Text);
                duerecre.Add(tb_dueñorecrea.Text);
                horrecre.Add(tb_horarioatencionrecrea.Text);
                idrecre.Add(random.Next(0, 1000));
                form2.SetNomRec(nomrecre);
            }

        }
        

        private void bt_crearesta_Click(object sender, EventArgs e)
        {
            if (tb_nombredueñorestaurante.Text == "" || tb_nombrerestaurante.Text == "" || tb_horarioatencionresta.Text == "" || tb_tipomesaresta.Text == "")
            {
                lb_inrest.Visible = true;
            }
            else
            {
                lb_exitoresta.Visible = true;
                Random random = new Random();
                nomresta.Add(tb_nombrerestaurante.Text);
                dueresta.Add(tb_nombredueñorestaurante.Text);
                horresta.Add(tb_horarioatencionresta.Text);
                mesaresta.Add(tb_tipomesaresta.Text);
                idresta.Add(random.Next(0, 1000));
                form2.SetNomRe(nomresta);

            }

        }

        private void bt_showtiendas_Click(object sender, EventArgs e)
        {
            rtb_showtienda.Visible = true;
            rtb_showcine.Visible = false;
            rtb_showrecre.Visible = false;
            rtb_showresta.Visible = false;
            rtb_showtienda.Text = "";
            rtb_showcine.Text = "";
            rtb_showrecre.Text = "";
            rtb_showresta.Text = "";
            for (int x = 0; x < nomtienda.Count(); x++)
            {
                rtb_showtienda.Text = rtb_showtienda.Text + idtienda[x] + "   " + nomtienda[x] +"   " + duetienda[x] + "   " + hortienda[x] + "   " + cattienda[x] + Environment.NewLine;
            }
        }

        private void bt_showresta_Click(object sender, EventArgs e)
        {
            rtb_showtienda.Visible = false;
            rtb_showcine.Visible = false;
            rtb_showrecre.Visible = false;
            rtb_showresta.Visible = true;
            rtb_showtienda.Text = "";
            rtb_showcine.Text = "";
            rtb_showrecre.Text = "";
            rtb_showresta.Text = "";
            for (int x = 0; x < nomresta.Count(); x++)
            {
                rtb_showresta.Text = rtb_showresta.Text + idresta[x] + "   " + nomresta[x] + "   " + dueresta[x] + "   " + horresta[x] + "   " + mesaresta[x] + Environment.NewLine;
            }
        }

        private void bt_showcine_Click(object sender, EventArgs e)
        {

            rtb_showtienda.Visible = false;
            rtb_showcine.Visible = true;
            rtb_showrecre.Visible = false;
            rtb_showresta.Visible = false;
            rtb_showtienda.Text = "";
            rtb_showcine.Text = "";
            rtb_showrecre.Text = "";
            rtb_showresta.Text = "";
            for (int x = 0; x < nomcine.Count(); x++)
            {
                rtb_showcine.Text = rtb_showcine.Text + idcine[x] + "   " + nomcine[x] + "   " + duecine[x] + "   " + horcine[x] + "   " + salascine[x] + Environment.NewLine;
            }
        }

        private void bt_showrecre_Click(object sender, EventArgs e)
        {
            rtb_showtienda.Visible = false;
            rtb_showcine.Visible = false;
            rtb_showrecre.Visible = true;
            rtb_showresta.Visible = false;
            rtb_showtienda.Text = "";
            rtb_showcine.Text = "";
            rtb_showrecre.Text = "";
            rtb_showresta.Text = "";
            for (int x = 0; x < nomrecre.Count(); x++)
            {
                rtb_showrecre.Text = rtb_showrecre.Text + idrecre[x] + "   " + nomrecre[x] + "   " + duerecre[x] + "   " + horrecre[x]  + Environment.NewLine;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtb_showtienda.Visible = false;
            rtb_showcine.Visible = false;
            rtb_showrecre.Visible = false;
            rtb_showresta.Visible = false;
            pn_todoslocales.Visible = false;
            rtb_showtienda.Text = "";
            rtb_showcine.Text = "";
            rtb_showrecre.Text = "";
            rtb_showresta.Text = "";

        }
       
    }
}
