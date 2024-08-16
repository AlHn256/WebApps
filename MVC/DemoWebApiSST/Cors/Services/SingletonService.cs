using System;

namespace Cors
{
    public interface ISingletonService : IService { }
    public class SingletonService : ISingletonService
    {
        private string _guid { get; set; }
        public SingletonService()
        {
            _guid = Guid.NewGuid().ToString();
        }
        public string GetGuid()
        {
            return _guid;
        }
    }
}

