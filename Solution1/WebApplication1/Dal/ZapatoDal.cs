namespace WebApplication1.Dal
{
    public class ZapatoDal
    {
       public Zapato Create(Zapato zapato)
        {
            return zapato;
        }

        public Zapato Read(int id)
        {
            return new Zapato();
        }

        public Zapato Update(Zapato zapato, int id)
        {
            return zapato;
        }

        public int Delete(int id)
        {
            return id;
        }
    }
}
