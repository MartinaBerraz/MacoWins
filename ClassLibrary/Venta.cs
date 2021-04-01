using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class Local
    {
        public List<Venta> ventas { get; set; }

        public Local()
        {
            ventas = new List<Venta>();
        }
        public void IngresarVenta(Venta venta)
        {
            ventas.Add(venta);
        }

        public float CalcularTot(DateTime fecha)
        {
            float monto=0;

            foreach (Venta v in this.ventas)
            {
                if(v.fecha.Date== fecha.Date)
                {
                    monto += v.Precio;
                }
            }

            return monto;
        }
    }
    public class Venta
    {
        public List<Prenda> prendas { get; set; }
        public int Cantidad { get; set; }
        public Tipo tipo { get; set; }
        public float Precio { get; set; }
        public DateTime fecha { get; set; }

        public Venta()
        {
            this.prendas = new List<Prenda>();
        }
        
        public float Total_recargo()
        {
            foreach( Prenda p in prendas)
            {
                this.Precio += p.DevuelvePrecio() * 0.01F;
            }

            return Precio;
        }
    

        public void AñadirPrenda(Prenda p)
        {
            this.prendas.Add(p);
            Cantidad += 1;
            Precio += p.DevuelvePrecio();

            return;
        }

    }

    public abstract class Tipo
    {
        public virtual float CalcularPrecio(string cuotas, float precio)
        {
            return precio;
        }
        

    }
    public class Tarjeta: Tipo
    {
        override public float CalcularPrecio(string cuotas, float precio)
        {
            
            float recargo = 100F;
            try
            {
                int n= int.Parse(cuotas);
                return (n* recargo + precio);
            }
            catch
            {
                return -1;
            }
            
        }
    }
    public class Efectivo : Tipo
    {
      
    }
}
