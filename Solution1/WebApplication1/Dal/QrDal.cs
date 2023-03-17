namespace WebApplication1.Dal
{
    public class QrDal
    {
        public Qr Create(Qr qr)
        {
           Contexto obj = new  Contexto(); 
    
            return qr;
        }

        public Qr Read(int id)
        {
            return new Qr();
        }

        public Qr Update(Qr qr, int id)
        {
            return qr;
        }

        public int Delete(int id)
        {
            return id;
        }
    }
}
