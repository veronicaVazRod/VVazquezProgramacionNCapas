﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SL_WCF.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Saludar", ReplyAction="http://tempuri.org/IService1/SaludarResponse")]
        string Saludar(string Nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Saludar", ReplyAction="http://tempuri.org/IService1/SaludarResponse")]
        System.Threading.Tasks.Task<string> SaludarAsync(string Nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Sumar", ReplyAction="http://tempuri.org/IService1/SumarResponse")]
        int Sumar(int numero1, int numero2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Sumar", ReplyAction="http://tempuri.org/IService1/SumarResponse")]
        System.Threading.Tasks.Task<int> SumarAsync(int numero1, int numero2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Restar", ReplyAction="http://tempuri.org/IService1/RestarResponse")]
        int Restar(int numero1, int numero2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Restar", ReplyAction="http://tempuri.org/IService1/RestarResponse")]
        System.Threading.Tasks.Task<int> RestarAsync(int numero1, int numero2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : SL_WCF.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<SL_WCF.ServiceReference1.IService1>, SL_WCF.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Saludar(string Nombre) {
            return base.Channel.Saludar(Nombre);
        }
        
        public System.Threading.Tasks.Task<string> SaludarAsync(string Nombre) {
            return base.Channel.SaludarAsync(Nombre);
        }
        
        public int Sumar(int numero1, int numero2) {
            return base.Channel.Sumar(numero1, numero2);
        }
        
        public System.Threading.Tasks.Task<int> SumarAsync(int numero1, int numero2) {
            return base.Channel.SumarAsync(numero1, numero2);
        }
        
        public int Restar(int numero1, int numero2) {
            return base.Channel.Restar(numero1, numero2);
        }
        
        public System.Threading.Tasks.Task<int> RestarAsync(int numero1, int numero2) {
            return base.Channel.RestarAsync(numero1, numero2);
        }
    }
}