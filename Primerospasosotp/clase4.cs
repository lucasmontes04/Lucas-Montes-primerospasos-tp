namespace Primerospasosotp
{
    internal class clase4
    {
        private int _Id;
        private string _Comentarios;
        private int _IdUsuario;


        public clase4()
        {
            _Id = 0;
            _Comentarios = string.Empty;
            _IdUsuario = 0;
        }


        public clase4(int id, string comentarios, int idUsuario)
        {
            _Id = id;
            _Comentarios = comentarios;
            _IdUsuario = idUsuario;
        }
        public int GetId()
        {
            return _Id;
        }

        public void SetId(int value)
        {
            _Id = value;
        }


        public string GetComentarios()
        {
            return _Comentarios;
        }

        public void SetComentarios(string value)
        {
            _Comentarios = value;
        }


        public int GetIdUsuario()
        {
            return _IdUsuario;
        }

        public void SetIdUsuario(int value)
        {
            _IdUsuario = value;
        }
    }
}
