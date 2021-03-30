using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class Ventas
    {
        public List<Venta> ventas { get; set; }

        public Ventas()
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

        public float Precio { get; set; }
        public DateTime fecha { get; set; }

        public Venta()
        {
            this.prendas = new List<Prenda>();
        }

    }

    public abstract class Tipo
    {
        public virtual float CalcularPrecio(int cuotas,float precio)
        {
            return precio;
        }    

    }
    public class Tarjeta: Tipo
    {
        override public float CalcularPrecio(int cuotas, float precio)
        {
            float recargo = 0.05F;

            return (cuotas * recargo + 0.01F * precio);
        }
    }
    public class Efectivo : Tipo
    {
      
    }
}
