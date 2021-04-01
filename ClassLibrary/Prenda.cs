using System;

namespace ClassLibrary
{
    public abstract class Prenda
    {
        public float DevuelvePrecio()
        {
            this.Precio = estado.CalcularPrecio(this.Precio);
            return this.Precio;
        }
        public float Precio { get; set; }
        public Estado estado { get; set; }

    }

    public class Saco: Prenda
    {
        public Saco() { this.Precio = 5000; }
    }

    public class Pantalon : Prenda
    {
        public Pantalon() { this.Precio = 4000; }
    }

    public class Camisa : Prenda
    {
        public Camisa() { this.Precio = 3000; }
    }

    public abstract class Estado
    {
        public abstract float CalcularPrecio(float Precio);
    }

    public class Nueva: Estado
    {
        public override float CalcularPrecio(float precio)
        {
            return precio;
        }
    }

    public class Liquidación : Estado
    {
        public override float CalcularPrecio(float precio)
        {
            return precio-500;
        }

    }

    public class Promoción : Estado
    {
        public override float CalcularPrecio(float precio)
        {
            return precio*0.5f;
        }
    }
}
