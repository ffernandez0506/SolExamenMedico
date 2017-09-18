﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestProject.ServiceEmpresa {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RepetidoException", Namespace="http://schemas.datacontract.org/2004/07/WcfServices.Errores")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(TestProject.ServiceEmpresa.Empresa))]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Empresa", Namespace="http://schemas.datacontract.org/2004/07/WcfServices")]
    [System.SerializableAttribute()]
    public partial class Empresa : TestProject.ServiceEmpresa.RepetidoException {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DireccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RUCField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefonoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Direccion {
            get {
                return this.DireccionField;
            }
            set {
                if ((object.ReferenceEquals(this.DireccionField, value) != true)) {
                    this.DireccionField = value;
                    this.RaisePropertyChanged("Direccion");
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
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RUC {
            get {
                return this.RUCField;
            }
            set {
                if ((object.ReferenceEquals(this.RUCField, value) != true)) {
                    this.RUCField = value;
                    this.RaisePropertyChanged("RUC");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefono {
            get {
                return this.TelefonoField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefonoField, value) != true)) {
                    this.TelefonoField = value;
                    this.RaisePropertyChanged("Telefono");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceEmpresa.IServiceEmpresa")]
    public interface IServiceEmpresa {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceEmpresa/Registro", ReplyAction="http://tempuri.org/IServiceEmpresa/RegistroResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(TestProject.ServiceEmpresa.RepetidoException), Action="http://tempuri.org/IServiceEmpresa/RegistroRepetidoExceptionFault", Name="RepetidoException", Namespace="http://schemas.datacontract.org/2004/07/WcfServices.Errores")]
        TestProject.ServiceEmpresa.Empresa Registro(TestProject.ServiceEmpresa.Empresa obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceEmpresa/Registro", ReplyAction="http://tempuri.org/IServiceEmpresa/RegistroResponse")]
        System.Threading.Tasks.Task<TestProject.ServiceEmpresa.Empresa> RegistroAsync(TestProject.ServiceEmpresa.Empresa obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceEmpresa/Listar", ReplyAction="http://tempuri.org/IServiceEmpresa/ListarResponse")]
        TestProject.ServiceEmpresa.Empresa[] Listar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceEmpresa/Listar", ReplyAction="http://tempuri.org/IServiceEmpresa/ListarResponse")]
        System.Threading.Tasks.Task<TestProject.ServiceEmpresa.Empresa[]> ListarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceEmpresa/Obtener", ReplyAction="http://tempuri.org/IServiceEmpresa/ObtenerResponse")]
        TestProject.ServiceEmpresa.Empresa Obtener(string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceEmpresa/Obtener", ReplyAction="http://tempuri.org/IServiceEmpresa/ObtenerResponse")]
        System.Threading.Tasks.Task<TestProject.ServiceEmpresa.Empresa> ObtenerAsync(string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceEmpresa/Modificar", ReplyAction="http://tempuri.org/IServiceEmpresa/ModificarResponse")]
        TestProject.ServiceEmpresa.Empresa Modificar(TestProject.ServiceEmpresa.Empresa empresaAModificar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceEmpresa/Modificar", ReplyAction="http://tempuri.org/IServiceEmpresa/ModificarResponse")]
        System.Threading.Tasks.Task<TestProject.ServiceEmpresa.Empresa> ModificarAsync(TestProject.ServiceEmpresa.Empresa empresaAModificar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceEmpresa/Eliminar", ReplyAction="http://tempuri.org/IServiceEmpresa/EliminarResponse")]
        TestProject.ServiceEmpresa.EliminarResponse Eliminar(TestProject.ServiceEmpresa.EliminarRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceEmpresa/Eliminar", ReplyAction="http://tempuri.org/IServiceEmpresa/EliminarResponse")]
        System.Threading.Tasks.Task<TestProject.ServiceEmpresa.EliminarResponse> EliminarAsync(TestProject.ServiceEmpresa.EliminarRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Eliminar", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class EliminarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string nombre;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string codigo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string descripcion;
        
        public EliminarRequest() {
        }
        
        public EliminarRequest(string nombre, string codigo, string descripcion) {
            this.nombre = nombre;
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
    public interface IServiceEmpresaChannel : TestProject.ServiceEmpresa.IServiceEmpresa, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceEmpresaClient : System.ServiceModel.ClientBase<TestProject.ServiceEmpresa.IServiceEmpresa>, TestProject.ServiceEmpresa.IServiceEmpresa {
        
        public ServiceEmpresaClient() {
        }
        
        public ServiceEmpresaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceEmpresaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceEmpresaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceEmpresaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TestProject.ServiceEmpresa.Empresa Registro(TestProject.ServiceEmpresa.Empresa obj) {
            return base.Channel.Registro(obj);
        }
        
        public System.Threading.Tasks.Task<TestProject.ServiceEmpresa.Empresa> RegistroAsync(TestProject.ServiceEmpresa.Empresa obj) {
            return base.Channel.RegistroAsync(obj);
        }
        
        public TestProject.ServiceEmpresa.Empresa[] Listar() {
            return base.Channel.Listar();
        }
        
        public System.Threading.Tasks.Task<TestProject.ServiceEmpresa.Empresa[]> ListarAsync() {
            return base.Channel.ListarAsync();
        }
        
        public TestProject.ServiceEmpresa.Empresa Obtener(string nombre) {
            return base.Channel.Obtener(nombre);
        }
        
        public System.Threading.Tasks.Task<TestProject.ServiceEmpresa.Empresa> ObtenerAsync(string nombre) {
            return base.Channel.ObtenerAsync(nombre);
        }
        
        public TestProject.ServiceEmpresa.Empresa Modificar(TestProject.ServiceEmpresa.Empresa empresaAModificar) {
            return base.Channel.Modificar(empresaAModificar);
        }
        
        public System.Threading.Tasks.Task<TestProject.ServiceEmpresa.Empresa> ModificarAsync(TestProject.ServiceEmpresa.Empresa empresaAModificar) {
            return base.Channel.ModificarAsync(empresaAModificar);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TestProject.ServiceEmpresa.EliminarResponse TestProject.ServiceEmpresa.IServiceEmpresa.Eliminar(TestProject.ServiceEmpresa.EliminarRequest request) {
            return base.Channel.Eliminar(request);
        }
        
        public void Eliminar(string nombre, ref string codigo, ref string descripcion) {
            TestProject.ServiceEmpresa.EliminarRequest inValue = new TestProject.ServiceEmpresa.EliminarRequest();
            inValue.nombre = nombre;
            inValue.codigo = codigo;
            inValue.descripcion = descripcion;
            TestProject.ServiceEmpresa.EliminarResponse retVal = ((TestProject.ServiceEmpresa.IServiceEmpresa)(this)).Eliminar(inValue);
            codigo = retVal.codigo;
            descripcion = retVal.descripcion;
        }
        
        public System.Threading.Tasks.Task<TestProject.ServiceEmpresa.EliminarResponse> EliminarAsync(TestProject.ServiceEmpresa.EliminarRequest request) {
            return base.Channel.EliminarAsync(request);
        }
    }
}
