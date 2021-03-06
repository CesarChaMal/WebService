﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión del motor en tiempo de ejecución:2.0.50727.3074
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=2.0.50727.3074.
// 
#pragma warning disable 1591

namespace WebService.WebserviceClass {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="TimeServiceSoap", Namespace="http://www.Nanonull.com/TimeService/")]
    public partial class TimeService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getUTCTimeOperationCompleted;
        
        private System.Threading.SendOrPostCallback getOffesetUTCTimeOperationCompleted;
        
        private System.Threading.SendOrPostCallback getServerTimeOperationCompleted;
        
        private System.Threading.SendOrPostCallback getServerTimeZoneOperationCompleted;
        
        private System.Threading.SendOrPostCallback getServerCityOperationCompleted;
        
        private System.Threading.SendOrPostCallback getTimeZoneTimeOperationCompleted;
        
        private System.Threading.SendOrPostCallback getCityTimeOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public TimeService() {
            this.Url = global::WebService.Properties.Settings.Default.WebService_WebserviceClass_TimeService;
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
        public event getUTCTimeCompletedEventHandler getUTCTimeCompleted;
        
        /// <remarks/>
        public event getOffesetUTCTimeCompletedEventHandler getOffesetUTCTimeCompleted;
        
        /// <remarks/>
        public event getServerTimeCompletedEventHandler getServerTimeCompleted;
        
        /// <remarks/>
        public event getServerTimeZoneCompletedEventHandler getServerTimeZoneCompleted;
        
        /// <remarks/>
        public event getServerCityCompletedEventHandler getServerCityCompleted;
        
        /// <remarks/>
        public event getTimeZoneTimeCompletedEventHandler getTimeZoneTimeCompleted;
        
        /// <remarks/>
        public event getCityTimeCompletedEventHandler getCityTimeCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.Nanonull.com/TimeService/getUTCTime", RequestNamespace="http://www.Nanonull.com/TimeService/", ResponseNamespace="http://www.Nanonull.com/TimeService/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getUTCTime() {
            object[] results = this.Invoke("getUTCTime", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getUTCTimeAsync() {
            this.getUTCTimeAsync(null);
        }
        
        /// <remarks/>
        public void getUTCTimeAsync(object userState) {
            if ((this.getUTCTimeOperationCompleted == null)) {
                this.getUTCTimeOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetUTCTimeOperationCompleted);
            }
            this.InvokeAsync("getUTCTime", new object[0], this.getUTCTimeOperationCompleted, userState);
        }
        
        private void OngetUTCTimeOperationCompleted(object arg) {
            if ((this.getUTCTimeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getUTCTimeCompleted(this, new getUTCTimeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.Nanonull.com/TimeService/getOffesetUTCTime", RequestNamespace="http://www.Nanonull.com/TimeService/", ResponseNamespace="http://www.Nanonull.com/TimeService/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getOffesetUTCTime(double hoursOffset) {
            object[] results = this.Invoke("getOffesetUTCTime", new object[] {
                        hoursOffset});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getOffesetUTCTimeAsync(double hoursOffset) {
            this.getOffesetUTCTimeAsync(hoursOffset, null);
        }
        
        /// <remarks/>
        public void getOffesetUTCTimeAsync(double hoursOffset, object userState) {
            if ((this.getOffesetUTCTimeOperationCompleted == null)) {
                this.getOffesetUTCTimeOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetOffesetUTCTimeOperationCompleted);
            }
            this.InvokeAsync("getOffesetUTCTime", new object[] {
                        hoursOffset}, this.getOffesetUTCTimeOperationCompleted, userState);
        }
        
        private void OngetOffesetUTCTimeOperationCompleted(object arg) {
            if ((this.getOffesetUTCTimeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getOffesetUTCTimeCompleted(this, new getOffesetUTCTimeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.Nanonull.com/TimeService/getServerTime", RequestNamespace="http://www.Nanonull.com/TimeService/", ResponseNamespace="http://www.Nanonull.com/TimeService/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getServerTime() {
            object[] results = this.Invoke("getServerTime", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getServerTimeAsync() {
            this.getServerTimeAsync(null);
        }
        
        /// <remarks/>
        public void getServerTimeAsync(object userState) {
            if ((this.getServerTimeOperationCompleted == null)) {
                this.getServerTimeOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetServerTimeOperationCompleted);
            }
            this.InvokeAsync("getServerTime", new object[0], this.getServerTimeOperationCompleted, userState);
        }
        
        private void OngetServerTimeOperationCompleted(object arg) {
            if ((this.getServerTimeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getServerTimeCompleted(this, new getServerTimeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.Nanonull.com/TimeService/getServerTimeZone", RequestNamespace="http://www.Nanonull.com/TimeService/", ResponseNamespace="http://www.Nanonull.com/TimeService/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getServerTimeZone() {
            object[] results = this.Invoke("getServerTimeZone", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getServerTimeZoneAsync() {
            this.getServerTimeZoneAsync(null);
        }
        
        /// <remarks/>
        public void getServerTimeZoneAsync(object userState) {
            if ((this.getServerTimeZoneOperationCompleted == null)) {
                this.getServerTimeZoneOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetServerTimeZoneOperationCompleted);
            }
            this.InvokeAsync("getServerTimeZone", new object[0], this.getServerTimeZoneOperationCompleted, userState);
        }
        
        private void OngetServerTimeZoneOperationCompleted(object arg) {
            if ((this.getServerTimeZoneCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getServerTimeZoneCompleted(this, new getServerTimeZoneCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.Nanonull.com/TimeService/getServerCity", RequestNamespace="http://www.Nanonull.com/TimeService/", ResponseNamespace="http://www.Nanonull.com/TimeService/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getServerCity() {
            object[] results = this.Invoke("getServerCity", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getServerCityAsync() {
            this.getServerCityAsync(null);
        }
        
        /// <remarks/>
        public void getServerCityAsync(object userState) {
            if ((this.getServerCityOperationCompleted == null)) {
                this.getServerCityOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetServerCityOperationCompleted);
            }
            this.InvokeAsync("getServerCity", new object[0], this.getServerCityOperationCompleted, userState);
        }
        
        private void OngetServerCityOperationCompleted(object arg) {
            if ((this.getServerCityCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getServerCityCompleted(this, new getServerCityCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.Nanonull.com/TimeService/getTimeZoneTime", RequestNamespace="http://www.Nanonull.com/TimeService/", ResponseNamespace="http://www.Nanonull.com/TimeService/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getTimeZoneTime(string timezone) {
            object[] results = this.Invoke("getTimeZoneTime", new object[] {
                        timezone});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getTimeZoneTimeAsync(string timezone) {
            this.getTimeZoneTimeAsync(timezone, null);
        }
        
        /// <remarks/>
        public void getTimeZoneTimeAsync(string timezone, object userState) {
            if ((this.getTimeZoneTimeOperationCompleted == null)) {
                this.getTimeZoneTimeOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetTimeZoneTimeOperationCompleted);
            }
            this.InvokeAsync("getTimeZoneTime", new object[] {
                        timezone}, this.getTimeZoneTimeOperationCompleted, userState);
        }
        
        private void OngetTimeZoneTimeOperationCompleted(object arg) {
            if ((this.getTimeZoneTimeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getTimeZoneTimeCompleted(this, new getTimeZoneTimeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.Nanonull.com/TimeService/getCityTime", RequestNamespace="http://www.Nanonull.com/TimeService/", ResponseNamespace="http://www.Nanonull.com/TimeService/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getCityTime(string city) {
            object[] results = this.Invoke("getCityTime", new object[] {
                        city});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getCityTimeAsync(string city) {
            this.getCityTimeAsync(city, null);
        }
        
        /// <remarks/>
        public void getCityTimeAsync(string city, object userState) {
            if ((this.getCityTimeOperationCompleted == null)) {
                this.getCityTimeOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetCityTimeOperationCompleted);
            }
            this.InvokeAsync("getCityTime", new object[] {
                        city}, this.getCityTimeOperationCompleted, userState);
        }
        
        private void OngetCityTimeOperationCompleted(object arg) {
            if ((this.getCityTimeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getCityTimeCompleted(this, new getCityTimeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void getUTCTimeCompletedEventHandler(object sender, getUTCTimeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getUTCTimeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getUTCTimeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void getOffesetUTCTimeCompletedEventHandler(object sender, getOffesetUTCTimeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getOffesetUTCTimeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getOffesetUTCTimeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void getServerTimeCompletedEventHandler(object sender, getServerTimeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getServerTimeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getServerTimeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void getServerTimeZoneCompletedEventHandler(object sender, getServerTimeZoneCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getServerTimeZoneCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getServerTimeZoneCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void getServerCityCompletedEventHandler(object sender, getServerCityCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getServerCityCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getServerCityCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void getTimeZoneTimeCompletedEventHandler(object sender, getTimeZoneTimeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getTimeZoneTimeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getTimeZoneTimeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void getCityTimeCompletedEventHandler(object sender, getCityTimeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getCityTimeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getCityTimeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591