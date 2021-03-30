using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace MacoWIns
{
    public partial class Form1 : Form
    {
        

        Ventas ventas;
        Venta venta;

        public Form1()
        {
            InitializeComponent();
            
            ventas = new Ventas();
            venta = new Venta();
            
    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_fecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btn_AgregarItem_Click(object sender, EventArgs e)
        {
            Prenda prenda;

            if (radioBtn_Camisa.Checked == true){ prenda = new Camisa();}
            else 
            { 
                if (radioBtn_Pantalon.Checked == true) {  prenda = new Pantalon(); }
                else { prenda = new Saco();  }
            }

            if (radioBtn_Liq.Checked == true) {prenda.estado = new Liquidación(); }
            else
            {
                if (radioBtn_Promo.Checked == true) { prenda.estado = new Promoción(); }
                else { prenda.estado = new Nueva(); }
            }

            venta.Precio+=prenda.DevuelvePrecio();
            venta.Cantidad += 1;

            venta.prendas.Add(prenda);

            lbl_cantItems.Text = venta.Cantidad.ToString();
            lbl_Monto.Text = "$ " + venta.Precio.ToString();
            
        }

        private void btn_FinalizarVenta_Click(object sender, EventArgs e)
        {
            venta.fecha = DateTime.Today;
            ventas.IngresarVenta(venta);
      
            MessageBox.Show("La venta del día "+ venta.fecha.ToShortDateString() +" con un monto de $"+ venta.Precio+" fue realizada con éxito ", "Aviso del sistema");
            venta = new Venta();

            lbl_Monto.Text = "0";
            lbl_cantItems.Text = "0";

        }

        private void btn_CalcularG_Click(object sender, EventArgs e)
        {
            try
            {
                float monto= ventas.CalcularTot(Convert.ToDateTime(textBox_FechaG.Text));
                MessageBox.Show("La ganancia del día " + textBox_FechaG.Text + " fue de $" + monto.ToString());
            }
            catch
            {
                MessageBox.Show("La fecha ingresada está vacía o en un formato incorrecto","ERROR");
            }
            
        }
    }
}
