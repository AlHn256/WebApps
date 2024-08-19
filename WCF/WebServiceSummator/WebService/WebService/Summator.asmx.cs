using System.Web.Services;

namespace WebService
{
    public class Summator : System.Web.Services.WebService
    {
        [WebMethod]
        public int GetSumm(int x, int y)
        {
            return x+y;
        }
    }
}
