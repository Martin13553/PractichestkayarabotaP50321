using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrackticheskayarabotaP50321
{
    public class Regist
    {
        public void StartAuthorization(User user)
        {
            IPanel? panel = null;
            switch ((RoleType)user.RoleType)
            {
                case RoleType.AdminManager:
                    panel = new Adminka();
                    break;
                case RoleType.EmployeeManager:
                    panel = new EmployeeManagerPanel();
                    break;
            }
            panel?.StartPanel(user);
        }
    }
}
