using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrackticheskayarabotaP50321
{
    public interface IBuilder<T>
    {
        public T GetResult();
    }
}
