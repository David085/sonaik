namespace WebApplication1.Dal
{
    public class UsuarioDal
    {
        public Usuario Create(Usuario usuario)
        {
            return usuario;
        }

        public Usuario Read(int id)
        {
            return new Usuario();
        }

        public Usuario Update(Usuario usuario, int id)
        {
            return usuario;
        }

        public int Delete(int id)
        {
            return id;
        }
    }
}
