﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaWeb.TipoServ {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Tipo", Namespace="http://schemas.datacontract.org/2004/07/CapaDato")]
    [System.SerializableAttribute()]
    public partial class Tipo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private CapaWeb.TipoServ.Persona[] PersonaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoPersonaField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CapaWeb.TipoServ.Persona[] Persona {
            get {
                return this.PersonaField;
            }
            set {
                if ((object.ReferenceEquals(this.PersonaField, value) != true)) {
                    this.PersonaField = value;
                    this.RaisePropertyChanged("Persona");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoPersona {
            get {
                return this.TipoPersonaField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoPersonaField, value) != true)) {
                    this.TipoPersonaField = value;
                    this.RaisePropertyChanged("TipoPersona");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Persona", Namespace="http://schemas.datacontract.org/2004/07/CapaDato")]
    [System.SerializableAttribute()]
    public partial class Persona : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApMaternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApPaternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DivField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DomicilioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> FechaNacimientoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FonoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private CapaWeb.TipoServ.Obra[] ObraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RutField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SexoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> TipoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private CapaWeb.TipoServ.Tipo Tipo1Field;
        
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
        public string ApMaterno {
            get {
                return this.ApMaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApMaternoField, value) != true)) {
                    this.ApMaternoField = value;
                    this.RaisePropertyChanged("ApMaterno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApPaterno {
            get {
                return this.ApPaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApPaternoField, value) != true)) {
                    this.ApPaternoField = value;
                    this.RaisePropertyChanged("ApPaterno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Div {
            get {
                return this.DivField;
            }
            set {
                if ((object.ReferenceEquals(this.DivField, value) != true)) {
                    this.DivField = value;
                    this.RaisePropertyChanged("Div");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Domicilio {
            get {
                return this.DomicilioField;
            }
            set {
                if ((object.ReferenceEquals(this.DomicilioField, value) != true)) {
                    this.DomicilioField = value;
                    this.RaisePropertyChanged("Domicilio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> FechaNacimiento {
            get {
                return this.FechaNacimientoField;
            }
            set {
                if ((this.FechaNacimientoField.Equals(value) != true)) {
                    this.FechaNacimientoField = value;
                    this.RaisePropertyChanged("FechaNacimiento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Fono {
            get {
                return this.FonoField;
            }
            set {
                if ((object.ReferenceEquals(this.FonoField, value) != true)) {
                    this.FonoField = value;
                    this.RaisePropertyChanged("Fono");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombres {
            get {
                return this.NombresField;
            }
            set {
                if ((object.ReferenceEquals(this.NombresField, value) != true)) {
                    this.NombresField = value;
                    this.RaisePropertyChanged("Nombres");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CapaWeb.TipoServ.Obra[] Obra {
            get {
                return this.ObraField;
            }
            set {
                if ((object.ReferenceEquals(this.ObraField, value) != true)) {
                    this.ObraField = value;
                    this.RaisePropertyChanged("Obra");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Rut {
            get {
                return this.RutField;
            }
            set {
                if ((object.ReferenceEquals(this.RutField, value) != true)) {
                    this.RutField = value;
                    this.RaisePropertyChanged("Rut");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sexo {
            get {
                return this.SexoField;
            }
            set {
                if ((object.ReferenceEquals(this.SexoField, value) != true)) {
                    this.SexoField = value;
                    this.RaisePropertyChanged("Sexo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Tipo {
            get {
                return this.TipoField;
            }
            set {
                if ((this.TipoField.Equals(value) != true)) {
                    this.TipoField = value;
                    this.RaisePropertyChanged("Tipo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CapaWeb.TipoServ.Tipo Tipo1 {
            get {
                return this.Tipo1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Tipo1Field, value) != true)) {
                    this.Tipo1Field = value;
                    this.RaisePropertyChanged("Tipo1");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Obra", Namespace="http://schemas.datacontract.org/2004/07/CapaDato")]
    [System.SerializableAttribute()]
    public partial class Obra : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ArtistaRutField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CuidadosEspecialesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DimensionesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstiloField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FechaCreacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> FechaIngresoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private CapaWeb.TipoServ.Persona PersonaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProcedenciaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private CapaWeb.TipoServ.Ubicacion UbicacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UbicacionIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<long> ValorField;
        
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
        public string ArtistaRut {
            get {
                return this.ArtistaRutField;
            }
            set {
                if ((object.ReferenceEquals(this.ArtistaRutField, value) != true)) {
                    this.ArtistaRutField = value;
                    this.RaisePropertyChanged("ArtistaRut");
                }
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
        public string CuidadosEspeciales {
            get {
                return this.CuidadosEspecialesField;
            }
            set {
                if ((object.ReferenceEquals(this.CuidadosEspecialesField, value) != true)) {
                    this.CuidadosEspecialesField = value;
                    this.RaisePropertyChanged("CuidadosEspeciales");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Dimensiones {
            get {
                return this.DimensionesField;
            }
            set {
                if ((object.ReferenceEquals(this.DimensionesField, value) != true)) {
                    this.DimensionesField = value;
                    this.RaisePropertyChanged("Dimensiones");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estilo {
            get {
                return this.EstiloField;
            }
            set {
                if ((object.ReferenceEquals(this.EstiloField, value) != true)) {
                    this.EstiloField = value;
                    this.RaisePropertyChanged("Estilo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FechaCreacion {
            get {
                return this.FechaCreacionField;
            }
            set {
                if ((object.ReferenceEquals(this.FechaCreacionField, value) != true)) {
                    this.FechaCreacionField = value;
                    this.RaisePropertyChanged("FechaCreacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> FechaIngreso {
            get {
                return this.FechaIngresoField;
            }
            set {
                if ((this.FechaIngresoField.Equals(value) != true)) {
                    this.FechaIngresoField = value;
                    this.RaisePropertyChanged("FechaIngreso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CapaWeb.TipoServ.Persona Persona {
            get {
                return this.PersonaField;
            }
            set {
                if ((object.ReferenceEquals(this.PersonaField, value) != true)) {
                    this.PersonaField = value;
                    this.RaisePropertyChanged("Persona");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Procedencia {
            get {
                return this.ProcedenciaField;
            }
            set {
                if ((object.ReferenceEquals(this.ProcedenciaField, value) != true)) {
                    this.ProcedenciaField = value;
                    this.RaisePropertyChanged("Procedencia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CapaWeb.TipoServ.Ubicacion Ubicacion {
            get {
                return this.UbicacionField;
            }
            set {
                if ((object.ReferenceEquals(this.UbicacionField, value) != true)) {
                    this.UbicacionField = value;
                    this.RaisePropertyChanged("Ubicacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UbicacionId {
            get {
                return this.UbicacionIdField;
            }
            set {
                if ((this.UbicacionIdField.Equals(value) != true)) {
                    this.UbicacionIdField = value;
                    this.RaisePropertyChanged("UbicacionId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> Valor {
            get {
                return this.ValorField;
            }
            set {
                if ((this.ValorField.Equals(value) != true)) {
                    this.ValorField = value;
                    this.RaisePropertyChanged("Valor");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Ubicacion", Namespace="http://schemas.datacontract.org/2004/07/CapaDato")]
    [System.SerializableAttribute()]
    public partial class Ubicacion : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> IluminacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> MaxObrasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> MetrosCuadradosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private CapaWeb.TipoServ.Obra[] ObraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SalonField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Iluminacion {
            get {
                return this.IluminacionField;
            }
            set {
                if ((this.IluminacionField.Equals(value) != true)) {
                    this.IluminacionField = value;
                    this.RaisePropertyChanged("Iluminacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> MaxObras {
            get {
                return this.MaxObrasField;
            }
            set {
                if ((this.MaxObrasField.Equals(value) != true)) {
                    this.MaxObrasField = value;
                    this.RaisePropertyChanged("MaxObras");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> MetrosCuadrados {
            get {
                return this.MetrosCuadradosField;
            }
            set {
                if ((this.MetrosCuadradosField.Equals(value) != true)) {
                    this.MetrosCuadradosField = value;
                    this.RaisePropertyChanged("MetrosCuadrados");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CapaWeb.TipoServ.Obra[] Obra {
            get {
                return this.ObraField;
            }
            set {
                if ((object.ReferenceEquals(this.ObraField, value) != true)) {
                    this.ObraField = value;
                    this.RaisePropertyChanged("Obra");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Salon {
            get {
                return this.SalonField;
            }
            set {
                if ((object.ReferenceEquals(this.SalonField, value) != true)) {
                    this.SalonField = value;
                    this.RaisePropertyChanged("Salon");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TipoServ.IServicioTipo")]
    public interface IServicioTipo {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioTipo/ListarTipos", ReplyAction="http://tempuri.org/IServicioTipo/ListarTiposResponse")]
        CapaWeb.TipoServ.Tipo[] ListarTipos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioTipo/ListarTipos", ReplyAction="http://tempuri.org/IServicioTipo/ListarTiposResponse")]
        System.Threading.Tasks.Task<CapaWeb.TipoServ.Tipo[]> ListarTiposAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioTipoChannel : CapaWeb.TipoServ.IServicioTipo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioTipoClient : System.ServiceModel.ClientBase<CapaWeb.TipoServ.IServicioTipo>, CapaWeb.TipoServ.IServicioTipo {
        
        public ServicioTipoClient() {
        }
        
        public ServicioTipoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioTipoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioTipoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioTipoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CapaWeb.TipoServ.Tipo[] ListarTipos() {
            return base.Channel.ListarTipos();
        }
        
        public System.Threading.Tasks.Task<CapaWeb.TipoServ.Tipo[]> ListarTiposAsync() {
            return base.Channel.ListarTiposAsync();
        }
    }
}