﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Stemming.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.Istem")]
    public interface Istem {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istem/DoWork", ReplyAction="http://tempuri.org/Istem/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istem/DoWork", ReplyAction="http://tempuri.org/Istem/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istem/stemming", ReplyAction="http://tempuri.org/Istem/stemmingResponse")]
        string stemming(string str);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istem/stemming", ReplyAction="http://tempuri.org/Istem/stemmingResponse")]
        System.Threading.Tasks.Task<string> stemmingAsync(string str);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IstemChannel : Stemming.ServiceReference1.Istem, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IstemClient : System.ServiceModel.ClientBase<Stemming.ServiceReference1.Istem>, Stemming.ServiceReference1.Istem {
        
        public IstemClient() {
        }
        
        public IstemClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IstemClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IstemClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IstemClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public string stemming(string str) {
            return base.Channel.stemming(str);
        }
        
        public System.Threading.Tasks.Task<string> stemmingAsync(string str) {
            return base.Channel.stemmingAsync(str);
        }
    }
}
