﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RDI.NFe2.Business.SOA {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SOA.Infeservice")]
    public interface Infeservice {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Infeservice/ReportError", ReplyAction="http://tempuri.org/Infeservice/ReportErrorResponse")]
        bool ReportError(string error);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface InfeserviceChannel : RDI.NFe2.Business.SOA.Infeservice, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InfeserviceClient : System.ServiceModel.ClientBase<RDI.NFe2.Business.SOA.Infeservice>, RDI.NFe2.Business.SOA.Infeservice {
        
        public InfeserviceClient() {
        }
        
        public InfeserviceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InfeserviceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InfeserviceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InfeserviceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool ReportError(string error) {
            return base.Channel.ReportError(error);
        }
    }
}