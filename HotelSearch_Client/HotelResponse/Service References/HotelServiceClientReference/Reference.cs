﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelResponseClientt.HotelServiceClientReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Response", Namespace="http://schemas.datacontract.org/2004/07/HotelResponseService")]
    [System.SerializableAttribute()]
    public partial class Response : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HotelResponseClientt.HotelServiceClientReference.FirstResponse[] ListofHotelsField;
        
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
        public HotelResponseClientt.HotelServiceClientReference.FirstResponse[] ListofHotels {
            get {
                return this.ListofHotelsField;
            }
            set {
                if ((object.ReferenceEquals(this.ListofHotelsField, value) != true)) {
                    this.ListofHotelsField = value;
                    this.RaisePropertyChanged("ListofHotels");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="FirstResponse", Namespace="http://schemas.datacontract.org/2004/07/HotelResponseService")]
    [System.SerializableAttribute()]
    public partial class FirstResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumOfRoomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RoomTypesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string bestValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string hotelIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string locationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string minAverPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
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
        public string NumOfRoom {
            get {
                return this.NumOfRoomField;
            }
            set {
                if ((object.ReferenceEquals(this.NumOfRoomField, value) != true)) {
                    this.NumOfRoomField = value;
                    this.RaisePropertyChanged("NumOfRoom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RoomTypes {
            get {
                return this.RoomTypesField;
            }
            set {
                if ((object.ReferenceEquals(this.RoomTypesField, value) != true)) {
                    this.RoomTypesField = value;
                    this.RaisePropertyChanged("RoomTypes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string bestValue {
            get {
                return this.bestValueField;
            }
            set {
                if ((object.ReferenceEquals(this.bestValueField, value) != true)) {
                    this.bestValueField = value;
                    this.RaisePropertyChanged("bestValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string hotelId {
            get {
                return this.hotelIdField;
            }
            set {
                if ((object.ReferenceEquals(this.hotelIdField, value) != true)) {
                    this.hotelIdField = value;
                    this.RaisePropertyChanged("hotelId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string location {
            get {
                return this.locationField;
            }
            set {
                if ((object.ReferenceEquals(this.locationField, value) != true)) {
                    this.locationField = value;
                    this.RaisePropertyChanged("location");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string minAverPrice {
            get {
                return this.minAverPriceField;
            }
            set {
                if ((object.ReferenceEquals(this.minAverPriceField, value) != true)) {
                    this.minAverPriceField = value;
                    this.RaisePropertyChanged("minAverPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Response2", Namespace="http://schemas.datacontract.org/2004/07/HotelResponseService.Entity")]
    [System.SerializableAttribute()]
    public partial class Response2 : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HotelResponseClientt.HotelServiceClientReference.SecondResponse[] ListofHotels2Field;
        
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
        public HotelResponseClientt.HotelServiceClientReference.SecondResponse[] ListofHotels2 {
            get {
                return this.ListofHotels2Field;
            }
            set {
                if ((object.ReferenceEquals(this.ListofHotels2Field, value) != true)) {
                    this.ListofHotels2Field = value;
                    this.RaisePropertyChanged("ListofHotels2");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SecondResponse", Namespace="http://schemas.datacontract.org/2004/07/HotelResponseService.Entity")]
    [System.SerializableAttribute()]
    public partial class SecondResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumOfRoomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RoomTypesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string bestValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string hotelIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string locationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string minAverPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
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
        public string NumOfRoom {
            get {
                return this.NumOfRoomField;
            }
            set {
                if ((object.ReferenceEquals(this.NumOfRoomField, value) != true)) {
                    this.NumOfRoomField = value;
                    this.RaisePropertyChanged("NumOfRoom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RoomTypes {
            get {
                return this.RoomTypesField;
            }
            set {
                if ((object.ReferenceEquals(this.RoomTypesField, value) != true)) {
                    this.RoomTypesField = value;
                    this.RaisePropertyChanged("RoomTypes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string bestValue {
            get {
                return this.bestValueField;
            }
            set {
                if ((object.ReferenceEquals(this.bestValueField, value) != true)) {
                    this.bestValueField = value;
                    this.RaisePropertyChanged("bestValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string hotelId {
            get {
                return this.hotelIdField;
            }
            set {
                if ((object.ReferenceEquals(this.hotelIdField, value) != true)) {
                    this.hotelIdField = value;
                    this.RaisePropertyChanged("hotelId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string location {
            get {
                return this.locationField;
            }
            set {
                if ((object.ReferenceEquals(this.locationField, value) != true)) {
                    this.locationField = value;
                    this.RaisePropertyChanged("location");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string minAverPrice {
            get {
                return this.minAverPriceField;
            }
            set {
                if ((object.ReferenceEquals(this.minAverPriceField, value) != true)) {
                    this.minAverPriceField = value;
                    this.RaisePropertyChanged("minAverPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HotelServiceClientReference.IHotelResponse")]
    public interface IHotelResponse {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelResponse/GetHotels", ReplyAction="http://tempuri.org/IHotelResponse/GetHotelsResponse")]
        HotelResponseClientt.HotelServiceClientReference.Response GetHotels();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelResponse/GetHotels", ReplyAction="http://tempuri.org/IHotelResponse/GetHotelsResponse")]
        System.Threading.Tasks.Task<HotelResponseClientt.HotelServiceClientReference.Response> GetHotelsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelResponse/GetHotels2", ReplyAction="http://tempuri.org/IHotelResponse/GetHotels2Response")]
        HotelResponseClientt.HotelServiceClientReference.Response2 GetHotels2();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelResponse/GetHotels2", ReplyAction="http://tempuri.org/IHotelResponse/GetHotels2Response")]
        System.Threading.Tasks.Task<HotelResponseClientt.HotelServiceClientReference.Response2> GetHotels2Async();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHotelResponseChannel : HotelResponseClientt.HotelServiceClientReference.IHotelResponse, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HotelResponseClient : System.ServiceModel.ClientBase<HotelResponseClientt.HotelServiceClientReference.IHotelResponse>, HotelResponseClientt.HotelServiceClientReference.IHotelResponse {
        
        public HotelResponseClient() {
        }
        
        public HotelResponseClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HotelResponseClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HotelResponseClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HotelResponseClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public HotelResponseClientt.HotelServiceClientReference.Response GetHotels() {
            return base.Channel.GetHotels();
        }
        
        public System.Threading.Tasks.Task<HotelResponseClientt.HotelServiceClientReference.Response> GetHotelsAsync() {
            return base.Channel.GetHotelsAsync();
        }
        
        public HotelResponseClientt.HotelServiceClientReference.Response2 GetHotels2() {
            return base.Channel.GetHotels2();
        }
        
        public System.Threading.Tasks.Task<HotelResponseClientt.HotelServiceClientReference.Response2> GetHotels2Async() {
            return base.Channel.GetHotels2Async();
        }
    }
}
