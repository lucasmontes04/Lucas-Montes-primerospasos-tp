namespace Primerospasosotp
{
    internal class Productosvendidio
    {
        private int Id;
        private int IdProducto;
        private int CantidadVendida;
        private int IdVenta;


        public Productosvendidio()
        {
            Id = 0;
            IdProducto = 0;
            CantidadVendida = 0;
            IdVenta = 0;
        }


        public Productosvendidio(int id, int idProducto, int cantidadVendida, int idVenta)
        {
            Id = id;
            IdProducto = idProducto;
            CantidadVendida = cantidadVendida;
            IdVenta = idVenta;
        }


        public int GetId()
        {
            return Id;
        }

        public void SetId(int value)
        {
            Id = value;
        }

        public int GetIdProducto()
        {
            return IdProducto;
        }

        public void SetIdProducto(int value)
        {
            IdProducto = value;
        }

        public int GetCantidadVendida()
        {
            return CantidadVendida;
        }

        public void SetCantidadVendida(int value)
        {
            CantidadVendida = value;
        }

        public int GetIdVenta()
        {
            return IdVenta;
        }

        public void SetIdVenta(int value)
        {
            IdVenta = value;
        }
    }
}


