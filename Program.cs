namespace PrackticheskayarabotaP50321
{
    public class Program
    {
        public static void Main()
        {
            User user = new login().StartAuthentication();
            new Regist().StartAuthorization(user);
        }
    }
}