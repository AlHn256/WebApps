using System;

namespace MVCWebTestApl.Models
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

