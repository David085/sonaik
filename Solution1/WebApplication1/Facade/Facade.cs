namespace WebApplication1.Facade
{
    
    public class Facade
    {
        public Qr ventaNueva(Usuario User, Zapato zapato)
        {
            return new Qr();
        }

        public Qr VentaVieja(Usuario userVende, Usuario userCompra, Zapato zapato)
        {
            return new Qr();
        }

        public Qr Consulta(Qr Qr, int Cedula)
        {
            return new Qr();
        }
    }
}
