﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace client.ServiceBookReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceBookReference.IServiceBook")]
    public interface IServiceBook {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBook/HelloWorld", ReplyAction="http://tempuri.org/IServiceBook/HelloWorldResponse")]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBook/HelloWorld", ReplyAction="http://tempuri.org/IServiceBook/HelloWorldResponse")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBook/GetAllBooksIdsByPhrase", ReplyAction="http://tempuri.org/IServiceBook/GetAllBooksIdsByPhraseResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ServiceModel.FaultException), Action="http://tempuri.org/IServiceBook/GetAllBooksIdsByPhraseFaultExceptionFault", Name="FaultException", Namespace="http://schemas.datacontract.org/2004/07/System.ServiceModel")]
        string[] GetAllBooksIdsByPhrase(string phrase);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBook/GetAllBooksIdsByPhrase", ReplyAction="http://tempuri.org/IServiceBook/GetAllBooksIdsByPhraseResponse")]
        System.Threading.Tasks.Task<string[]> GetAllBooksIdsByPhraseAsync(string phrase);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBook/GetBookById", ReplyAction="http://tempuri.org/IServiceBook/GetBookByIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ServiceModel.FaultException), Action="http://tempuri.org/IServiceBook/GetBookByIdFaultExceptionFault", Name="FaultException", Namespace="http://schemas.datacontract.org/2004/07/System.ServiceModel")]
        Dto.Book GetBookById(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBook/GetBookById", ReplyAction="http://tempuri.org/IServiceBook/GetBookByIdResponse")]
        System.Threading.Tasks.Task<Dto.Book> GetBookByIdAsync(string id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceBookChannel : client.ServiceBookReference.IServiceBook, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceBookClient : System.ServiceModel.ClientBase<client.ServiceBookReference.IServiceBook>, client.ServiceBookReference.IServiceBook {
        
        public ServiceBookClient() {
        }
        
        public ServiceBookClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceBookClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceBookClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceBookClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        public string[] GetAllBooksIdsByPhrase(string phrase) {
            return base.Channel.GetAllBooksIdsByPhrase(phrase);
        }
        
        public System.Threading.Tasks.Task<string[]> GetAllBooksIdsByPhraseAsync(string phrase) {
            return base.Channel.GetAllBooksIdsByPhraseAsync(phrase);
        }
        
        public Dto.Book GetBookById(string id) {
            return base.Channel.GetBookById(id);
        }
        
        public System.Threading.Tasks.Task<Dto.Book> GetBookByIdAsync(string id) {
            return base.Channel.GetBookByIdAsync(id);
        }
    }
}
