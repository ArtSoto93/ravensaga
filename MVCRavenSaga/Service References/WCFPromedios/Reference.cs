﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCRavenSaga.WCFPromedios {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Promedios", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Promedios : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClaseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DefMaxField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DefensaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FuerzaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FuerzaMaxField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HPField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HPMaxField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HabMaxField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HabilidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MagiaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MagiaMaxField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NivelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResMaxField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResistenciaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SueMaxField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SuerteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VelMaxField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VelocidadField;
        
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
        public string Clase {
            get {
                return this.ClaseField;
            }
            set {
                if ((object.ReferenceEquals(this.ClaseField, value) != true)) {
                    this.ClaseField = value;
                    this.RaisePropertyChanged("Clase");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DefMax {
            get {
                return this.DefMaxField;
            }
            set {
                if ((object.ReferenceEquals(this.DefMaxField, value) != true)) {
                    this.DefMaxField = value;
                    this.RaisePropertyChanged("DefMax");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Defensa {
            get {
                return this.DefensaField;
            }
            set {
                if ((object.ReferenceEquals(this.DefensaField, value) != true)) {
                    this.DefensaField = value;
                    this.RaisePropertyChanged("Defensa");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Fuerza {
            get {
                return this.FuerzaField;
            }
            set {
                if ((object.ReferenceEquals(this.FuerzaField, value) != true)) {
                    this.FuerzaField = value;
                    this.RaisePropertyChanged("Fuerza");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FuerzaMax {
            get {
                return this.FuerzaMaxField;
            }
            set {
                if ((object.ReferenceEquals(this.FuerzaMaxField, value) != true)) {
                    this.FuerzaMaxField = value;
                    this.RaisePropertyChanged("FuerzaMax");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HP {
            get {
                return this.HPField;
            }
            set {
                if ((object.ReferenceEquals(this.HPField, value) != true)) {
                    this.HPField = value;
                    this.RaisePropertyChanged("HP");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HPMax {
            get {
                return this.HPMaxField;
            }
            set {
                if ((object.ReferenceEquals(this.HPMaxField, value) != true)) {
                    this.HPMaxField = value;
                    this.RaisePropertyChanged("HPMax");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HabMax {
            get {
                return this.HabMaxField;
            }
            set {
                if ((object.ReferenceEquals(this.HabMaxField, value) != true)) {
                    this.HabMaxField = value;
                    this.RaisePropertyChanged("HabMax");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Habilidad {
            get {
                return this.HabilidadField;
            }
            set {
                if ((object.ReferenceEquals(this.HabilidadField, value) != true)) {
                    this.HabilidadField = value;
                    this.RaisePropertyChanged("Habilidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Magia {
            get {
                return this.MagiaField;
            }
            set {
                if ((object.ReferenceEquals(this.MagiaField, value) != true)) {
                    this.MagiaField = value;
                    this.RaisePropertyChanged("Magia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MagiaMax {
            get {
                return this.MagiaMaxField;
            }
            set {
                if ((object.ReferenceEquals(this.MagiaMaxField, value) != true)) {
                    this.MagiaMaxField = value;
                    this.RaisePropertyChanged("MagiaMax");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nivel {
            get {
                return this.NivelField;
            }
            set {
                if ((object.ReferenceEquals(this.NivelField, value) != true)) {
                    this.NivelField = value;
                    this.RaisePropertyChanged("Nivel");
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
        public string ResMax {
            get {
                return this.ResMaxField;
            }
            set {
                if ((object.ReferenceEquals(this.ResMaxField, value) != true)) {
                    this.ResMaxField = value;
                    this.RaisePropertyChanged("ResMax");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Resistencia {
            get {
                return this.ResistenciaField;
            }
            set {
                if ((object.ReferenceEquals(this.ResistenciaField, value) != true)) {
                    this.ResistenciaField = value;
                    this.RaisePropertyChanged("Resistencia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SueMax {
            get {
                return this.SueMaxField;
            }
            set {
                if ((object.ReferenceEquals(this.SueMaxField, value) != true)) {
                    this.SueMaxField = value;
                    this.RaisePropertyChanged("SueMax");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Suerte {
            get {
                return this.SuerteField;
            }
            set {
                if ((object.ReferenceEquals(this.SuerteField, value) != true)) {
                    this.SuerteField = value;
                    this.RaisePropertyChanged("Suerte");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VelMax {
            get {
                return this.VelMaxField;
            }
            set {
                if ((object.ReferenceEquals(this.VelMaxField, value) != true)) {
                    this.VelMaxField = value;
                    this.RaisePropertyChanged("VelMax");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Velocidad {
            get {
                return this.VelocidadField;
            }
            set {
                if ((object.ReferenceEquals(this.VelocidadField, value) != true)) {
                    this.VelocidadField = value;
                    this.RaisePropertyChanged("Velocidad");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFPromedios.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getPromediosEF", ReplyAction="http://tempuri.org/IService/getPromediosEFResponse")]
        MVCRavenSaga.WCFPromedios.Promedios[] getPromediosEF(int Cuantos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getPromediosEF", ReplyAction="http://tempuri.org/IService/getPromediosEFResponse")]
        System.Threading.Tasks.Task<MVCRavenSaga.WCFPromedios.Promedios[]> getPromediosEFAsync(int Cuantos);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : MVCRavenSaga.WCFPromedios.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<MVCRavenSaga.WCFPromedios.IService>, MVCRavenSaga.WCFPromedios.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MVCRavenSaga.WCFPromedios.Promedios[] getPromediosEF(int Cuantos) {
            return base.Channel.getPromediosEF(Cuantos);
        }
        
        public System.Threading.Tasks.Task<MVCRavenSaga.WCFPromedios.Promedios[]> getPromediosEFAsync(int Cuantos) {
            return base.Channel.getPromediosEFAsync(Cuantos);
        }
    }
}
