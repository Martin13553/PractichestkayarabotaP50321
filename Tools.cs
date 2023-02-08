using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrackticheskayarabotaP50321
{
    public class AuthenticationException : Exception
    {
        public AuthenticationException()
            : base("Аутенфикация не прошла")
        {

        }
    }

    public class NotExistAccountException : Exception
    {
        public NotExistAccountException()
            : base("Не сущетсвует аккаунта")
        {

        }
    }
}
