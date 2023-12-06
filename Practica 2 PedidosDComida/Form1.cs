using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2_PedidosDComida
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int CantidadHamburguesas;
        int Cantidadhotdog;
        int CantidadSandwish;
        int CantidadTe;
        int CantidadRefresco;
        int CantidadPapas;

        double totalVta;
        double CostoHamburguesa;
        double CostoHotDog;
        double CostoSandwish;
        double CostoTe;
        double CostoRefresco;
        double CostoPapas;

        double hamburguesa = 20.5;
        double hotdog = 19.25;
        double sandwish = 17.5;
        double papasfirtas = 4.5;
        double refresco = 4;
        double te = 5;
        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            costo.Text = "";
            if (radioButton1.Checked == true)
            {
                CantidadHamburguesas = 1;
                CantidadRefresco = 1;
                CantidadPapas = 1;
                Cantidadhotdog = 0;
                CantidadSandwish = 0;
                CantidadTe = 0;

                Hamburguesa1.Text = CantidadHamburguesas.ToString();
                Refresco5.Text = CantidadRefresco.ToString();
                Papas6.Text = CantidadPapas.ToString();

                Hamburguesa1.Enabled = true;
                Refresco5.Enabled = true;
                Papas6.Enabled = true;

                Hotdog2.Enabled = false;
                Te4.Enabled = false;
                Sandwish3.Enabled = false;
                Hotdog2.Text = "";
                Sandwish3.Text = "";
                Te4.Text = "";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            costo.Text = "";
            if (radioButton2.Checked == true)
            {
                CantidadRefresco = 1;
                CantidadPapas = 1;
                Cantidadhotdog = 1;
                CantidadSandwish = 0;


                Hotdog2.Text = Cantidadhotdog.ToString();
                Refresco5.Text = CantidadRefresco.ToString();
                Papas6.Text = CantidadPapas.ToString();

                Hotdog2.Enabled = true;
                Refresco5.Enabled = true;
                Papas6.Enabled = true;

                Hamburguesa1.Enabled = false;
                Te4.Enabled = false;
                Sandwish3.Enabled = false;
                Hamburguesa1.Text = "";
                Sandwish3.Text = "";
                Te4.Text = "";

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            costo.Text = "";
            if (radioButton3.Checked == true)
            {
                CantidadRefresco = 1;
                CantidadPapas = 1;
                CantidadSandwish = 1;
                Cantidadhotdog = 0;
                CantidadTe = 0;
                CantidadHamburguesas = 0;

                Sandwish3.Text = CantidadSandwish.ToString();
                Refresco5.Text = CantidadRefresco.ToString();
                Papas6.Text = CantidadPapas.ToString();

                Sandwish3.Enabled = true;
                Refresco5.Enabled = true;
                Papas6.Enabled = true;

                Hamburguesa1.Enabled = false;
                Te4.Enabled = false;
                Hotdog2.Enabled = false;

                Hamburguesa1.Text = "";
                Hotdog2.Text = "";
                Te4.Text = "";


            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
           
            costo.Text = "";
            
            if (radioButton4.Checked == true)
            {
                Sandwish3.Enabled = true;
                Refresco5.Enabled = true;
                Papas6.Enabled = true;
                Hamburguesa1.Enabled = true;
                Te4.Enabled = true;
                Hotdog2.Enabled = true;

                CantidadRefresco = 1;
                CantidadPapas = 1;
                CantidadSandwish = 1;
                Cantidadhotdog = 1;
                CantidadTe = 1;
                CantidadHamburguesas = 1;

                Sandwish3.Text = CantidadSandwish.ToString();
                Refresco5.Text = CantidadRefresco.ToString();
                Papas6.Text = CantidadPapas.ToString();
                Hotdog2.Text = Cantidadhotdog.ToString();
                Hamburguesa1.Text = CantidadHamburguesas.ToString();
                Te4.Text = CantidadTe.ToString();

            }
        }

        private void total_Click(object sender, EventArgs e)
        {
                CostoHamburguesa = (CantidadHamburguesas * hamburguesa);
                CostoHotDog = (Cantidadhotdog * hotdog);
                CostoSandwish = (CantidadSandwish * sandwish);
                CostoTe = (CantidadTe * te);
                CostoRefresco = (CantidadRefresco * refresco);
                CostoPapas = (CantidadPapas * papasfirtas);
                totalVta = CostoHamburguesa + CostoHotDog + CostoSandwish + CostoRefresco + CostoTe + CostoPapas;
                costo.Text = totalVta.ToString();

        }

        private void salida_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
    
       
}
