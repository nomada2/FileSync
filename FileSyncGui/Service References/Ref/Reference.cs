﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FileSyncGui.Ref {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Credentials", Namespace="http://schemas.datacontract.org/2004/07/FileSyncObjects")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(FileSyncGui.Ref.UserIdentity))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(FileSyncGui.Ref.UserContents))]
    public partial class Credentials : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
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
        public string Login {
            get {
                return this.LoginField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginField, value) != true)) {
                    this.LoginField = value;
                    this.RaisePropertyChanged("Login");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UserIdentity", Namespace="http://schemas.datacontract.org/2004/07/FileSyncObjects")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(FileSyncGui.Ref.UserContents))]
    public partial class UserIdentity : FileSyncGui.Ref.Credentials {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime LastLoginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public System.DateTime LastLogin {
            get {
                return this.LastLoginField;
            }
            set {
                if ((this.LastLoginField.Equals(value) != true)) {
                    this.LastLoginField = value;
                    this.RaisePropertyChanged("LastLogin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserContents", Namespace="http://schemas.datacontract.org/2004/07/FileSyncObjects")]
    [System.SerializableAttribute()]
    public partial class UserContents : FileSyncGui.Ref.UserIdentity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<FileSyncGui.Ref.MachineContents> MachinesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<FileSyncGui.Ref.MachineContents> Machines {
            get {
                return this.MachinesField;
            }
            set {
                if ((object.ReferenceEquals(this.MachinesField, value) != true)) {
                    this.MachinesField = value;
                    this.RaisePropertyChanged("Machines");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MachineContents", Namespace="http://schemas.datacontract.org/2004/07/FileSyncObjects")]
    [System.SerializableAttribute()]
    public partial class MachineContents : FileSyncGui.Ref.MachineIdentity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<FileSyncGui.Ref.DirectoryContents> DirectoriesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<FileSyncGui.Ref.DirectoryContents> Directories {
            get {
                return this.DirectoriesField;
            }
            set {
                if ((object.ReferenceEquals(this.DirectoriesField, value) != true)) {
                    this.DirectoriesField = value;
                    this.RaisePropertyChanged("Directories");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MachineIdentity", Namespace="http://schemas.datacontract.org/2004/07/FileSyncObjects")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(FileSyncGui.Ref.MachineContents))]
    public partial class MachineIdentity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DirectoryContents", Namespace="http://schemas.datacontract.org/2004/07/FileSyncObjects")]
    [System.SerializableAttribute()]
    public partial class DirectoryContents : FileSyncGui.Ref.DirectoryIdentity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<FileSyncGui.Ref.FileContents> FilesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<FileSyncGui.Ref.FileContents> Files {
            get {
                return this.FilesField;
            }
            set {
                if ((object.ReferenceEquals(this.FilesField, value) != true)) {
                    this.FilesField = value;
                    this.RaisePropertyChanged("Files");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DirectoryIdentity", Namespace="http://schemas.datacontract.org/2004/07/FileSyncObjects")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(FileSyncGui.Ref.DirectoryContents))]
    public partial class DirectoryIdentity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LocalPathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LocalPath {
            get {
                return this.LocalPathField;
            }
            set {
                if ((object.ReferenceEquals(this.LocalPathField, value) != true)) {
                    this.LocalPathField = value;
                    this.RaisePropertyChanged("LocalPath");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="FileContents", Namespace="http://schemas.datacontract.org/2004/07/FileSyncObjects")]
    [System.SerializableAttribute()]
    public partial class FileContents : FileSyncGui.Ref.FileIdentity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContentsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Contents {
            get {
                return this.ContentsField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentsField, value) != true)) {
                    this.ContentsField = value;
                    this.RaisePropertyChanged("Contents");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FileIdentity", Namespace="http://schemas.datacontract.org/2004/07/FileSyncObjects")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(FileSyncGui.Ref.FileContents))]
    public partial class FileIdentity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HashField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ModifiedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long SizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private FileSyncGui.Ref.FileType TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime UploadedField;
        
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
        public string Hash {
            get {
                return this.HashField;
            }
            set {
                if ((object.ReferenceEquals(this.HashField, value) != true)) {
                    this.HashField = value;
                    this.RaisePropertyChanged("Hash");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Modified {
            get {
                return this.ModifiedField;
            }
            set {
                if ((this.ModifiedField.Equals(value) != true)) {
                    this.ModifiedField = value;
                    this.RaisePropertyChanged("Modified");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Size {
            get {
                return this.SizeField;
            }
            set {
                if ((this.SizeField.Equals(value) != true)) {
                    this.SizeField = value;
                    this.RaisePropertyChanged("Size");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public FileSyncGui.Ref.FileType Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Uploaded {
            get {
                return this.UploadedField;
            }
            set {
                if ((this.UploadedField.Equals(value) != true)) {
                    this.UploadedField = value;
                    this.RaisePropertyChanged("Uploaded");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FileType", Namespace="http://schemas.datacontract.org/2004/07/FileSyncObjects")]
    public enum FileType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PlainText = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        FormattedText = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Audio = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Video = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Image = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Archive = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Executable = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Other = 7,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Ref.IFileSyncModel")]
    public interface IFileSyncModel {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileSyncModel/AddUser", ReplyAction="http://tempuri.org/IFileSyncModel/AddUserResponse")]
        void AddUser(FileSyncGui.Ref.Credentials c, FileSyncGui.Ref.UserContents u);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileSyncModel/Login", ReplyAction="http://tempuri.org/IFileSyncModel/LoginResponse")]
        void Login(FileSyncGui.Ref.Credentials c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileSyncModel/GetUser", ReplyAction="http://tempuri.org/IFileSyncModel/GetUserResponse")]
        FileSyncGui.Ref.UserContents GetUser(FileSyncGui.Ref.Credentials c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileSyncModel/GetMachineList", ReplyAction="http://tempuri.org/IFileSyncModel/GetMachineListResponse")]
        void GetMachineList(FileSyncGui.Ref.Credentials c, FileSyncGui.Ref.UserContents u);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileSyncModel/DelUser", ReplyAction="http://tempuri.org/IFileSyncModel/DelUserResponse")]
        void DelUser(FileSyncGui.Ref.Credentials c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileSyncModel/AddMachine", ReplyAction="http://tempuri.org/IFileSyncModel/AddMachineResponse")]
        void AddMachine(FileSyncGui.Ref.Credentials c, FileSyncGui.Ref.MachineContents m);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileSyncModel/ChangeMachineDetails", ReplyAction="http://tempuri.org/IFileSyncModel/ChangeMachineDetailsResponse")]
        void ChangeMachineDetails(FileSyncGui.Ref.Credentials c, FileSyncGui.Ref.MachineContents newM, FileSyncGui.Ref.MachineContents oldM);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileSyncModel/GetDirList", ReplyAction="http://tempuri.org/IFileSyncModel/GetDirListResponse")]
        void GetDirList(FileSyncGui.Ref.Credentials c, FileSyncGui.Ref.MachineContents m);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileSyncModel/AddDirectory", ReplyAction="http://tempuri.org/IFileSyncModel/AddDirectoryResponse")]
        void AddDirectory(FileSyncGui.Ref.Credentials c, FileSyncGui.Ref.MachineContents m, FileSyncGui.Ref.DirectoryContents d);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileSyncModel/GetFileList", ReplyAction="http://tempuri.org/IFileSyncModel/GetFileListResponse")]
        void GetFileList(FileSyncGui.Ref.Credentials c, FileSyncGui.Ref.MachineContents m, FileSyncGui.Ref.DirectoryContents d);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileSyncModel/AddFile", ReplyAction="http://tempuri.org/IFileSyncModel/AddFileResponse")]
        void AddFile(FileSyncGui.Ref.Credentials c, FileSyncGui.Ref.MachineContents m, FileSyncGui.Ref.DirectoryContents d, FileSyncGui.Ref.FileContents f);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileSyncModel/GetFileContent", ReplyAction="http://tempuri.org/IFileSyncModel/GetFileContentResponse")]
        void GetFileContent(FileSyncGui.Ref.Credentials c, FileSyncGui.Ref.MachineContents m, FileSyncGui.Ref.DirectoryContents d, FileSyncGui.Ref.FileContents f);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFileSyncModelChannel : FileSyncGui.Ref.IFileSyncModel, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FileSyncModelClient : System.ServiceModel.ClientBase<FileSyncGui.Ref.IFileSyncModel>, FileSyncGui.Ref.IFileSyncModel {
        
        public FileSyncModelClient() {
        }
        
        public FileSyncModelClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FileSyncModelClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileSyncModelClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileSyncModelClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddUser(FileSyncGui.Ref.Credentials c, FileSyncGui.Ref.UserContents u) {
            base.Channel.AddUser(c, u);
        }
        
        public void Login(FileSyncGui.Ref.Credentials c) {
            base.Channel.Login(c);
        }
        
        public FileSyncGui.Ref.UserContents GetUser(FileSyncGui.Ref.Credentials c) {
            return base.Channel.GetUser(c);
        }
        
        public void GetMachineList(FileSyncGui.Ref.Credentials c, FileSyncGui.Ref.UserContents u) {
            base.Channel.GetMachineList(c, u);
        }
        
        public void DelUser(FileSyncGui.Ref.Credentials c) {
            base.Channel.DelUser(c);
        }
        
        public void AddMachine(FileSyncGui.Ref.Credentials c, FileSyncGui.Ref.MachineContents m) {
            base.Channel.AddMachine(c, m);
        }
        
        public void ChangeMachineDetails(FileSyncGui.Ref.Credentials c, FileSyncGui.Ref.MachineContents newM, FileSyncGui.Ref.MachineContents oldM) {
            base.Channel.ChangeMachineDetails(c, newM, oldM);
        }
        
        public void GetDirList(FileSyncGui.Ref.Credentials c, FileSyncGui.Ref.MachineContents m) {
            base.Channel.GetDirList(c, m);
        }
        
        public void AddDirectory(FileSyncGui.Ref.Credentials c, FileSyncGui.Ref.MachineContents m, FileSyncGui.Ref.DirectoryContents d) {
            base.Channel.AddDirectory(c, m, d);
        }
        
        public void GetFileList(FileSyncGui.Ref.Credentials c, FileSyncGui.Ref.MachineContents m, FileSyncGui.Ref.DirectoryContents d) {
            base.Channel.GetFileList(c, m, d);
        }
        
        public void AddFile(FileSyncGui.Ref.Credentials c, FileSyncGui.Ref.MachineContents m, FileSyncGui.Ref.DirectoryContents d, FileSyncGui.Ref.FileContents f) {
            base.Channel.AddFile(c, m, d, f);
        }
        
        public void GetFileContent(FileSyncGui.Ref.Credentials c, FileSyncGui.Ref.MachineContents m, FileSyncGui.Ref.DirectoryContents d, FileSyncGui.Ref.FileContents f) {
            base.Channel.GetFileContent(c, m, d, f);
        }
    }
}
