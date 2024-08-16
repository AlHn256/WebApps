using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteService
{
    public class SummatorRemoteService :MarshalByRefObject, ISummatorRemoteService
    {
        public int GetSum(int x, int y)
        {
            return x + y;
        }
    }
}
