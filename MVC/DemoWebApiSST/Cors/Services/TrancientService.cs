using System;

namespace Cors
{
    public interface ITrancientService : IService { }


    public class TrancientService : ITrancientService
    {
        private string _guid;
        public TrancientService()
        {
            _guid = Guid.NewGuid().ToString();
        }
        public string GetGuid()
        {
            return _guid;
        }
    }
}
