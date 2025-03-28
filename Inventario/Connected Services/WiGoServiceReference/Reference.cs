﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inventario.WiGoServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WiGoServiceReference.IWiGoService")]
    public interface IWiGoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWiGoService/GetData", ReplyAction="http://tempuri.org/IWiGoService/GetDataResponse")]
        string GetData(string controller, string model, string filters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWiGoService/GetData", ReplyAction="http://tempuri.org/IWiGoService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(string controller, string model, string filters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWiGoService/ExecuteProcedure", ReplyAction="http://tempuri.org/IWiGoService/ExecuteProcedureResponse")]
        string ExecuteProcedure(string controller, string model, string qtype, string datos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWiGoService/ExecuteProcedure", ReplyAction="http://tempuri.org/IWiGoService/ExecuteProcedureResponse")]
        System.Threading.Tasks.Task<string> ExecuteProcedureAsync(string controller, string model, string qtype, string datos);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWiGoServiceChannel : Inventario.WiGoServiceReference.IWiGoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WiGoServiceClient : System.ServiceModel.ClientBase<Inventario.WiGoServiceReference.IWiGoService>, Inventario.WiGoServiceReference.IWiGoService {
        
        public WiGoServiceClient() {
        }
        
        public WiGoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WiGoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WiGoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WiGoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(string controller, string model, string filters) {
            return base.Channel.GetData(controller, model, filters);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(string controller, string model, string filters) {
            return base.Channel.GetDataAsync(controller, model, filters);
        }
        
        public string ExecuteProcedure(string controller, string model, string qtype, string datos) {
            return base.Channel.ExecuteProcedure(controller, model, qtype, datos);
        }
        
        public System.Threading.Tasks.Task<string> ExecuteProcedureAsync(string controller, string model, string qtype, string datos) {
            return base.Channel.ExecuteProcedureAsync(controller, model, qtype, datos);
        }
    }
}
