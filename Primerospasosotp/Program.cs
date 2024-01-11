using Primerospasosotp;

Usuario usuario1 = new Usuario();


Console.WriteLine("Ingrese la información del usuario:");

Console.Write("ID: ");
int id = int.Parse(Console.ReadLine());

Console.Write("Nombre: ");
string nombre = Console.ReadLine();

Console.Write("Apellido: ");
string apellido = Console.ReadLine();

Console.Write("Nombre de Usuario: ");
string nombreUsuario = Console.ReadLine();

Console.Write("Contraseña: ");
string contraseña = Console.ReadLine();

Console.Write("Mail: ");
string mail = Console.ReadLine();

Usuario usuario2 = new Usuario(id, nombre, apellido, nombreUsuario, contraseña, mail);


Producto producto1 = new Producto();


Producto producto2 = new Producto(1, "Sprite", 4000, 3, 1000, 1, 1);


producto2.Descripcion = "Manaos";
producto2.Costo = 2500;
producto2.PrecioVenta = 5000;
producto2.Id = 3;


Console.WriteLine("Ingrese Codigo");
producto2.Codigo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese Descripcion");
producto2.Descripcion = Console.ReadLine();
Console.WriteLine("Ingrese Precio de Compra");
producto2.PrecioCompra = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese Precio de Venta");
producto2.PrecioVenta = (decimal)Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Id: " + producto2.Id);
Console.WriteLine("Codigo: " + producto2.Codigo);
Console.WriteLine("Descripcion: " + producto2.Descripcion);
Console.WriteLine("Precio Compra: " + producto2.Costo);
Console.WriteLine("Precio Venta: " + producto2.PrecioVenta);
Console.WriteLine("IdUsuario: " + producto2.IdUsuario);


ProductoVendido productoVendido1 = new ProductoVendido();

ProductoVendido productoVendido2 = new ProductoVendido(1, "Sprite", 4000, 3);

Console.WriteLine("Ingrese la información de Productosvendidio:");

Console.Write("ID: ");
int idProductosvendidio = int.Parse(Console.ReadLine());

Console.Write("ID Producto: ");
int idProductoProductosvendidio = int.Parse(Console.ReadLine());

Console.Write("Cantidad Vendida: ");
int cantidadVendidaProductosvendidio = int.Parse(Console.ReadLine());

Console.Write("ID Venta: ");
int idVentaProductosvendidio = int.Parse(Console.ReadLine());


Productosvendidio productosvendidio = new Productosvendidio(idProductosvendidio, idProductoProductosvendidio, cantidadVendidaProductosvendidio, idVentaProductosvendidio);


clase4 objetoClase4 = new clase4();


Console.WriteLine("Ingrese la información de clase4:");

Console.Write("ID: ");
int idClase4 = int.Parse(Console.ReadLine());

Console.Write("Comentarios: ");
string comentariosClase4 = Console.ReadLine();

Console.Write("ID Usuario: ");
int idUsuarioClase4 = int.Parse(Console.ReadLine());


Console.ReadKey();
        }
    }
}