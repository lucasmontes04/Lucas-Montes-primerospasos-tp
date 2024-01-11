namespace Primerospasosotp
{
    internal class Producto
    {
        private int _Id;
        private string _Descripcion;
        private decimal _Costo;
        private decimal _PrecioVenta;
        private int _Stock;
        private int _IdUsuario;

        public bool HayPrecioDeVenta()
        {
            // Lógica para verificar si hay precio de venta
            return _PrecioVenta > 0;
        }

        public int Id
        {
            get { return _Id; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public decimal Costo
        {
            get { return _Costo; }
            set { _Costo = value; }
        }

        public decimal PrecioVenta
        {
            get { return _PrecioVenta; }
            set { _PrecioVenta = value; }
        }

        public int Stock
        {
            get { return _Stock; }
            set { _Stock = value; }
        }

        public int IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }

        public Producto()
        {
            _Id = 0;
            _Descripcion = string.Empty;
            _Costo = 0;
            _PrecioVenta = 0;
            _Stock = 0;
            _IdUsuario = 0; // Cambiado de string.Empty a 0
        }

        public Producto(int id, string Descripcion, decimal Costo, decimal PrecioVenta, int Stock, int IdUsuario)
        {
            this._Id = id;
            this._Descripcion = Descripcion;
            this._Costo = Costo;
            this._PrecioVenta = PrecioVenta;
            this._Stock = Stock;
            this._IdUsuario = IdUsuario;
        }
    }
}

