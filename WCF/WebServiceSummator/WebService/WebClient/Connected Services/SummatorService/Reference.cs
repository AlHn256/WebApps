﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebClient.SummatorService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SummatorService.SummatorSoap")]
    public interface SummatorSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSumm", ReplyAction="*")]
        int GetSumm(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSumm", ReplyAction="*")]
        System.Threading.Tasks.Task<int> GetSummAsync(int x, int y);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SummatorSoapChannel : WebClient.SummatorService.SummatorSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SummatorSoapClient : System.ServiceModel.ClientBase<WebClient.SummatorService.SummatorSoap>, WebClient.SummatorService.SummatorSoap {
        
        public SummatorSoapClient() {
        }
        
        public SummatorSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SummatorSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SummatorSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SummatorSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
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
