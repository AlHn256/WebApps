﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinFormClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ISummator")]
    public interface ISummator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISummator/GetSumm", ReplyAction="http://tempuri.org/ISummator/GetSummResponse")]
        int GetSumm(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISummator/GetSumm", ReplyAction="http://tempuri.org/ISummator/GetSummResponse")]
        System.Threading.Tasks.Task<int> GetSummAsync(int x, int y);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISummatorChannel : WinFormClient.ServiceReference1.ISummator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SummatorClient : System.ServiceModel.ClientBase<WinFormClient.ServiceReference1.ISummator>, WinFormClient.ServiceReference1.ISummator {
        
        public SummatorClient() {
        }
        
        public SummatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SummatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SummatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SummatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetSumm(int x, int y) {
            return base.Channel.GetSumm(x, y);
        }
        
        public System.Threading.Tasks.Task<int> GetSummAsync(int x, int y) {
            return base.Channel.GetSummAsync(x, y);
        }
    }
}
