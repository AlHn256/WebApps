using System.ServiceModel;

namespace Summator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISummator" in both code and config file together.
    [ServiceContract]
    public interface ISummator
    {
        [OperationContract]
        int GetSumm(int x, int y);
    }
}
