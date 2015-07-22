﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.0.
// 
#pragma warning disable 1591

namespace WebService1C.dbsrv {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="DrawingsServiceSoapBinding", Namespace="http://www.sample-package.org")]
    public partial class DrawingsService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetDrawingsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetTechRoutesOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetTechOperationsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public DrawingsService() {
            this.Url = global::WebService1C.Properties.Settings.Default.WebService1C_dbsrv_DrawingsService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetDrawingsCompletedEventHandler GetDrawingsCompleted;
        
        /// <remarks/>
        public event GetTechRoutesCompletedEventHandler GetTechRoutesCompleted;
        
        /// <remarks/>
        public event GetTechOperationsCompletedEventHandler GetTechOperationsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.sample-package.org#DrawingsService:GetDrawings", RequestNamespace="http://www.sample-package.org", ResponseNamespace="http://www.sample-package.org", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("return")]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public Drawing[] GetDrawings() {
            object[] results = this.Invoke("GetDrawings", new object[0]);
            return ((Drawing[])(results[0]));
        }
        
        /// <remarks/>
        public void GetDrawingsAsync() {
            this.GetDrawingsAsync(null);
        }
        
        /// <remarks/>
        public void GetDrawingsAsync(object userState) {
            if ((this.GetDrawingsOperationCompleted == null)) {
                this.GetDrawingsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDrawingsOperationCompleted);
            }
            this.InvokeAsync("GetDrawings", new object[0], this.GetDrawingsOperationCompleted, userState);
        }
        
        private void OnGetDrawingsOperationCompleted(object arg) {
            if ((this.GetDrawingsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDrawingsCompleted(this, new GetDrawingsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.sample-package.org#DrawingsService:GetTechRoutes", RequestNamespace="http://www.sample-package.org", ResponseNamespace="http://www.sample-package.org", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("return")]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public TechRoute[] GetTechRoutes() {
            object[] results = this.Invoke("GetTechRoutes", new object[0]);
            return ((TechRoute[])(results[0]));
        }
        
        /// <remarks/>
        public void GetTechRoutesAsync() {
            this.GetTechRoutesAsync(null);
        }
        
        /// <remarks/>
        public void GetTechRoutesAsync(object userState) {
            if ((this.GetTechRoutesOperationCompleted == null)) {
                this.GetTechRoutesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTechRoutesOperationCompleted);
            }
            this.InvokeAsync("GetTechRoutes", new object[0], this.GetTechRoutesOperationCompleted, userState);
        }
        
        private void OnGetTechRoutesOperationCompleted(object arg) {
            if ((this.GetTechRoutesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTechRoutesCompleted(this, new GetTechRoutesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.sample-package.org#DrawingsService:GetTechOperations", RequestNamespace="http://www.sample-package.org", ResponseNamespace="http://www.sample-package.org", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("return")]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public Operation[] GetTechOperations() {
            object[] results = this.Invoke("GetTechOperations", new object[0]);
            return ((Operation[])(results[0]));
        }
        
        /// <remarks/>
        public void GetTechOperationsAsync() {
            this.GetTechOperationsAsync(null);
        }
        
        /// <remarks/>
        public void GetTechOperationsAsync(object userState) {
            if ((this.GetTechOperationsOperationCompleted == null)) {
                this.GetTechOperationsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTechOperationsOperationCompleted);
            }
            this.InvokeAsync("GetTechOperations", new object[0], this.GetTechOperationsOperationCompleted, userState);
        }
        
        private void OnGetTechOperationsOperationCompleted(object arg) {
            if ((this.GetTechOperationsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTechOperationsCompleted(this, new GetTechOperationsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sample-package.org")]
    public partial class Drawing {
        
        private string designationField;
        
        private string numberOnSpecField;
        
        private string profileField;
        
        private string typeSizeField;
        
        private string measurementField;
        
        private string gostSortField;
        
        private string markStealField;
        
        private string gostMatField;
        
        private int lengthField;
        
        private int widthField;
        
        private int countField;
        
        private int countAllField;
        
        private double weightField;
        
        private double weightAllField;
        
        private string noteField;
        
        private string techRouteCodeField;
        
        private string codePartOfField;
        
        private string opField;
        
        private string codeField;
        
        private string parentCodeField;
        
        private string nameField;
        
        /// <remarks/>
        public string Designation {
            get {
                return this.designationField;
            }
            set {
                this.designationField = value;
            }
        }
        
        /// <remarks/>
        public string NumberOnSpec {
            get {
                return this.numberOnSpecField;
            }
            set {
                this.numberOnSpecField = value;
            }
        }
        
        /// <remarks/>
        public string Profile {
            get {
                return this.profileField;
            }
            set {
                this.profileField = value;
            }
        }
        
        /// <remarks/>
        public string TypeSize {
            get {
                return this.typeSizeField;
            }
            set {
                this.typeSizeField = value;
            }
        }
        
        /// <remarks/>
        public string Measurement {
            get {
                return this.measurementField;
            }
            set {
                this.measurementField = value;
            }
        }
        
        /// <remarks/>
        public string GostSort {
            get {
                return this.gostSortField;
            }
            set {
                this.gostSortField = value;
            }
        }
        
        /// <remarks/>
        public string MarkSteal {
            get {
                return this.markStealField;
            }
            set {
                this.markStealField = value;
            }
        }
        
        /// <remarks/>
        public string GostMat {
            get {
                return this.gostMatField;
            }
            set {
                this.gostMatField = value;
            }
        }
        
        /// <remarks/>
        public int Length {
            get {
                return this.lengthField;
            }
            set {
                this.lengthField = value;
            }
        }
        
        /// <remarks/>
        public int Width {
            get {
                return this.widthField;
            }
            set {
                this.widthField = value;
            }
        }
        
        /// <remarks/>
        public int Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
        
        /// <remarks/>
        public int CountAll {
            get {
                return this.countAllField;
            }
            set {
                this.countAllField = value;
            }
        }
        
        /// <remarks/>
        public double Weight {
            get {
                return this.weightField;
            }
            set {
                this.weightField = value;
            }
        }
        
        /// <remarks/>
        public double WeightAll {
            get {
                return this.weightAllField;
            }
            set {
                this.weightAllField = value;
            }
        }
        
        /// <remarks/>
        public string Note {
            get {
                return this.noteField;
            }
            set {
                this.noteField = value;
            }
        }
        
        /// <remarks/>
        public string TechRouteCode {
            get {
                return this.techRouteCodeField;
            }
            set {
                this.techRouteCodeField = value;
            }
        }
        
        /// <remarks/>
        public string CodePartOf {
            get {
                return this.codePartOfField;
            }
            set {
                this.codePartOfField = value;
            }
        }
        
        /// <remarks/>
        public string OP {
            get {
                return this.opField;
            }
            set {
                this.opField = value;
            }
        }
        
        /// <remarks/>
        public string Code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        public string ParentCode {
            get {
                return this.parentCodeField;
            }
            set {
                this.parentCodeField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sample-package.org")]
    public partial class Operation {
        
        private string codeField;
        
        private string nameField;
        
        private string fullNameField;
        
        /// <remarks/>
        public string Code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string FullName {
            get {
                return this.fullNameField;
            }
            set {
                this.fullNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sample-package.org")]
    public partial class TechRoute {
        
        private string codeField;
        
        private string nameField;
        
        private string noteField;
        
        private Operation[] listOperationsField;
        
        /// <remarks/>
        public string Code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string Note {
            get {
                return this.noteField;
            }
            set {
                this.noteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public Operation[] ListOperations {
            get {
                return this.listOperationsField;
            }
            set {
                this.listOperationsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.0")]
    public delegate void GetDrawingsCompletedEventHandler(object sender, GetDrawingsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDrawingsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetDrawingsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Drawing[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Drawing[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.0")]
    public delegate void GetTechRoutesCompletedEventHandler(object sender, GetTechRoutesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTechRoutesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTechRoutesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TechRoute[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TechRoute[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.0")]
    public delegate void GetTechOperationsCompletedEventHandler(object sender, GetTechOperationsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTechOperationsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTechOperationsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Operation[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Operation[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591