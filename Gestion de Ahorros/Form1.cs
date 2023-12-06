using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DesactivarControles();
        }
        private Double dinero;
        private void ActivarControles()
        {
            nombre.Enabled = false;
            monto.Enabled = false;
            abrirCuenta.Enabled = false;

            retiro.Enabled = true;
            deposito.Enabled = true;
        }
        private void DesactivarControles()
        {
            nombre.Enabled = true;
            monto.Enabled = true;
            abrirCuenta.Enabled = true;

            retiro.Enabled = false;
            deposito.Enabled = false;
        }
        private void abrirCuenta_Click(object sender, EventArgs e)
        {
            string cliente;
            cliente = nombre.Text;
            dinero = Convert.ToDouble(monto.Text);

            if (dinero > 0)
            {
                ActivarControles();
            }
            else
            {
                MessageBox.Show("El monto debe ser mayor a 0", "Gestion de Ahorro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private double leer (string mensaje)
        {
            double cantidad;
            cantidad = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese monto a " + mensaje, "Gestion de Ahorros","0",100,0));
            return cantidad;
        }

        private void deposito_Click(object sender, EventArgs e)
        {
            double Deposito;
            Deposito = leer("Depositar");
            dinero = dinero + Deposito;
            ListaDeposito.Items.Add(Deposito);
            mostrar();

        }
        private void mostrar()
        {
            saldo.Text = Convert.ToString(dinero);
        }

        private void retiro_Click(object sender, EventArgs e)
        {
            double retiro;
            retiro = leer("Retirar");
            if (retiro <= dinero)
            {
                dinero = dinero - retiro;
                ListaRetiros.Items.Add(retiro);
                mostrar();
            }
            else
            {
                MessageBox.Show("El monto a retirar es mayor al saldo disponible", "Gestion de Ahorros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            nombre.Clear();
            monto.Clear();
            saldo.Clear();
            ListaDeposito.Items.Clear();
            ListaRetiros.Items.Clear();
            DesactivarControles();
        }
    }
}
