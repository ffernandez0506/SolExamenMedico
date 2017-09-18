﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestProject.ServiceAtencion {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RepetidoException", Namespace="http://schemas.datacontract.org/2004/07/WcfServices.Errores")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(TestProject.ServiceAtencion.Atencion))]
    public partial class RepetidoException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoField, value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Atencion", Namespace="http://schemas.datacontract.org/2004/07/WcfServices")]
    [System.SerializableAttribute()]
    public partial class Atencion : TestProject.ServiceAtencion.RepetidoException {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DniField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FechaField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Dni {
            get {
                return this.DniField;
            }
            set {
                if ((object.ReferenceEquals(this.DniField, value) != true)) {
                    this.DniField = value;
                    this.RaisePropertyChanged("Dni");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Fecha {
            get {
                return this.FechaField;
            }
            set {
                if ((object.ReferenceEquals(this.FechaField, value) != true)) {
                    this.FechaField = value;
                    this.RaisePropertyChanged("Fecha");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceAtencion.IServiceAtencion")]
    public interface IServiceAtencion {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAtencion/Registro", ReplyAction="http://tempuri.org/IServiceAtencion/RegistroResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(TestProject.ServiceAtencion.RepetidoException), Action="http://tempuri.org/IServiceAtencion/RegistroRepetidoExceptionFault", Name="RepetidoException", Namespace="http://schemas.datacontract.org/2004/07/WcfServices.Errores")]
        TestProject.ServiceAtencion.Atencion Registro(TestProject.ServiceAtencion.Atencion obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAtencion/Registro", ReplyAction="http://tempuri.org/IServiceAtencion/RegistroResponse")]
        System.Threading.Tasks.Task<TestProject.ServiceAtencion.Atencion> RegistroAsync(TestProject.ServiceAtencion.Atencion obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAtencion/Listar", ReplyAction="http://tempuri.org/IServiceAtencion/ListarResponse")]
        TestProject.ServiceAtencion.Atencion[] Listar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAtencion/Listar", ReplyAction="http://tempuri.org/IServiceAtencion/ListarResponse")]
        System.Threading.Tasks.Task<TestProject.ServiceAtencion.Atencion[]> ListarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAtencion/Obtener", ReplyAction="http://tempuri.org/IServiceAtencion/ObtenerResponse")]
        TestProject.ServiceAtencion.Atencion Obtener(string dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAtencion/Obtener", ReplyAction="http://tempuri.org/IServiceAtencion/ObtenerResponse")]
        System.Threading.Tasks.Task<TestProject.ServiceAtencion.Atencion> ObtenerAsync(string dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAtencion/Modificar", ReplyAction="http://tempuri.org/IServiceAtencion/ModificarResponse")]
        TestProject.ServiceAtencion.Atencion Modificar(TestProject.ServiceAtencion.Atencion AtencionAModificar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAtencion/Modificar", ReplyAction="http://tempuri.org/IServiceAtencion/ModificarResponse")]
        System.Threading.Tasks.Task<TestProject.ServiceAtencion.Atencion> ModificarAsync(TestProject.ServiceAtencion.Atencion AtencionAModificar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAtencion/Eliminar", ReplyAction="http://tempuri.org/IServiceAtencion/EliminarResponse")]
        TestProject.ServiceAtencion.EliminarResponse Eliminar(TestProject.ServiceAtencion.EliminarRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAtencion/Eliminar", ReplyAction="http://tempuri.org/IServiceAtencion/EliminarResponse")]
        System.Threading.Tasks.Task<TestProject.ServiceAtencion.EliminarResponse> EliminarAsync(TestProject.ServiceAtencion.EliminarRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Eliminar", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class EliminarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string dni;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string codigo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string descripcion;
        
        public EliminarRequest() {
        }
        
        public EliminarRequest(string dni, string codigo, string descripcion) {
            this.dni = dni;
            this.codigo = codigo;
            this.descripcion = descripcion;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EliminarResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class EliminarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string codigo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string descripcion;
        
        public EliminarResponse() {
        }
        
        public EliminarResponse(string codigo, string descripcion) {
            this.codigo = codigo;
            this.descripcion = descripcion;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceAtencionChannel : TestProject.ServiceAtencion.IServiceAtencion, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceAtencionClient : System.ServiceModel.ClientBase<TestProject.ServiceAtencion.IServiceAtencion>, TestProject.ServiceAtencion.IServiceAtencion {
        
        public ServiceAtencionClient() {
        }
        
        public ServiceAtencionClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceAtencionClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAtencionClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAtencionClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TestProject.ServiceAtencion.Atencion Registro(TestProject.ServiceAtencion.Atencion obj) {
            return base.Channel.Registro(obj);
        }
        
        public System.Threading.Tasks.Task<TestProject.ServiceAtencion.Atencion> RegistroAsync(TestProject.ServiceAtencion.Atencion obj) {
            return base.Channel.RegistroAsync(obj);
        }
        
        public TestProject.ServiceAtencion.Atencion[] Listar() {
            return base.Channel.Listar();
        }
        
        public System.Threading.Tasks.Task<TestProject.ServiceAtencion.Atencion[]> ListarAsync() {
            return base.Channel.ListarAsync();
        }
        
        public TestProject.ServiceAtencion.Atencion Obtener(string dni) {
            return base.Channel.Obtener(dni);
        }
        
        public System.Threading.Tasks.Task<TestProject.ServiceAtencion.Atencion> ObtenerAsync(string dni) {
            return base.Channel.ObtenerAsync(dni);
        }
        
        public TestProject.ServiceAtencion.Atencion Modificar(TestProject.ServiceAtencion.Atencion AtencionAModificar) {
            return base.Channel.Modificar(AtencionAModificar);
        }
        
        public System.Threading.Tasks.Task<TestProject.ServiceAtencion.Atencion> ModificarAsync(TestProject.ServiceAtencion.Atencion AtencionAModificar) {
            return base.Channel.ModificarAsync(AtencionAModificar);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TestProject.ServiceAtencion.EliminarResponse TestProject.ServiceAtencion.IServiceAtencion.Eliminar(TestProject.ServiceAtencion.EliminarRequest request) {
            return base.Channel.Eliminar(request);
        }
        
        public void Eliminar(string dni, ref string codigo, ref string descripcion) {
            TestProject.ServiceAtencion.EliminarRequest inValue = new TestProject.ServiceAtencion.EliminarRequest();
            inValue.dni = dni;
            inValue.codigo = codigo;
            inValue.descripcion = descripcion;
            TestProject.ServiceAtencion.EliminarResponse retVal = ((TestProject.ServiceAtencion.IServiceAtencion)(this)).Eliminar(inValue);
            codigo = retVal.codigo;
            descripcion = retVal.descripcion;
        }
        
        public System.Threading.Tasks.Task<TestProject.ServiceAtencion.EliminarResponse> EliminarAsync(TestProject.ServiceAtencion.EliminarRequest request) {
            return base.Channel.EliminarAsync(request);
        }
    }
}
