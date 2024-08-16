using System;

namespace MVCWebTestApl.Models
{
    public interface IScopedService : IService { }
    public class ScopedService : IScopedService
    {
        private string _guid { get; set; }
        public ScopedService()
        {
            _guid = Guid.NewGuid().ToString();
        }
        public string GetGuid()
        {
            return _guid;
        }
    }
}
