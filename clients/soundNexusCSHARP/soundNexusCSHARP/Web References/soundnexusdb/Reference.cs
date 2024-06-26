﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace soundNexusCSHARP.soundnexusdb {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="soundNexusBinding", Namespace="urn:soundNexusWS")]
    public partial class soundNexus : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getAllAlbumOperationCompleted;
        
        private System.Threading.SendOrPostCallback getAllAlbumSongsOperationCompleted;
        
        private System.Threading.SendOrPostCallback searchAlbumOperationCompleted;
        
        private System.Threading.SendOrPostCallback searchAlbumSongsOperationCompleted;
        
        private System.Threading.SendOrPostCallback addAlbumSongsOperationCompleted;
        
        private System.Threading.SendOrPostCallback addAlbumsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public soundNexus() {
            this.Url = global::soundNexusCSHARP.Properties.Settings.Default.soundNexusCSHARP_soundnexusdb_soundNexus;
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
        public event getAllAlbumCompletedEventHandler getAllAlbumCompleted;
        
        /// <remarks/>
        public event getAllAlbumSongsCompletedEventHandler getAllAlbumSongsCompleted;
        
        /// <remarks/>
        public event searchAlbumCompletedEventHandler searchAlbumCompleted;
        
        /// <remarks/>
        public event searchAlbumSongsCompletedEventHandler searchAlbumSongsCompleted;
        
        /// <remarks/>
        public event addAlbumSongsCompletedEventHandler addAlbumSongsCompleted;
        
        /// <remarks/>
        public event addAlbumsCompletedEventHandler addAlbumsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://localhost/IPT/soundNexus/services/webService.php/getAllAlbum", RequestNamespace="", ResponseNamespace="")]
        [return: System.Xml.Serialization.SoapElementAttribute("response")]
        public string getAllAlbum() {
            object[] results = this.Invoke("getAllAlbum", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getAllAlbumAsync() {
            this.getAllAlbumAsync(null);
        }
        
        /// <remarks/>
        public void getAllAlbumAsync(object userState) {
            if ((this.getAllAlbumOperationCompleted == null)) {
                this.getAllAlbumOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetAllAlbumOperationCompleted);
            }
            this.InvokeAsync("getAllAlbum", new object[0], this.getAllAlbumOperationCompleted, userState);
        }
        
        private void OngetAllAlbumOperationCompleted(object arg) {
            if ((this.getAllAlbumCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getAllAlbumCompleted(this, new getAllAlbumCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://localhost/IPT/soundNexus/services/webService.php/getAllAlbumSongs", RequestNamespace="", ResponseNamespace="")]
        [return: System.Xml.Serialization.SoapElementAttribute("response")]
        public string getAllAlbumSongs() {
            object[] results = this.Invoke("getAllAlbumSongs", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getAllAlbumSongsAsync() {
            this.getAllAlbumSongsAsync(null);
        }
        
        /// <remarks/>
        public void getAllAlbumSongsAsync(object userState) {
            if ((this.getAllAlbumSongsOperationCompleted == null)) {
                this.getAllAlbumSongsOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetAllAlbumSongsOperationCompleted);
            }
            this.InvokeAsync("getAllAlbumSongs", new object[0], this.getAllAlbumSongsOperationCompleted, userState);
        }
        
        private void OngetAllAlbumSongsOperationCompleted(object arg) {
            if ((this.getAllAlbumSongsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getAllAlbumSongsCompleted(this, new getAllAlbumSongsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://localhost/IPT/soundNexus/services/webService.php/searchAlbum", RequestNamespace="", ResponseNamespace="")]
        [return: System.Xml.Serialization.SoapElementAttribute("response")]
        public string searchAlbum(string searchalbums, string searchtype) {
            object[] results = this.Invoke("searchAlbum", new object[] {
                        searchalbums,
                        searchtype});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void searchAlbumAsync(string searchalbums, string searchtype) {
            this.searchAlbumAsync(searchalbums, searchtype, null);
        }
        
        /// <remarks/>
        public void searchAlbumAsync(string searchalbums, string searchtype, object userState) {
            if ((this.searchAlbumOperationCompleted == null)) {
                this.searchAlbumOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsearchAlbumOperationCompleted);
            }
            this.InvokeAsync("searchAlbum", new object[] {
                        searchalbums,
                        searchtype}, this.searchAlbumOperationCompleted, userState);
        }
        
        private void OnsearchAlbumOperationCompleted(object arg) {
            if ((this.searchAlbumCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.searchAlbumCompleted(this, new searchAlbumCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://localhost/IPT/soundNexus/services/webService.php/searchAlbumSongs", RequestNamespace="", ResponseNamespace="")]
        [return: System.Xml.Serialization.SoapElementAttribute("response")]
        public string searchAlbumSongs(string searchsong) {
            object[] results = this.Invoke("searchAlbumSongs", new object[] {
                        searchsong});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void searchAlbumSongsAsync(string searchsong) {
            this.searchAlbumSongsAsync(searchsong, null);
        }
        
        /// <remarks/>
        public void searchAlbumSongsAsync(string searchsong, object userState) {
            if ((this.searchAlbumSongsOperationCompleted == null)) {
                this.searchAlbumSongsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsearchAlbumSongsOperationCompleted);
            }
            this.InvokeAsync("searchAlbumSongs", new object[] {
                        searchsong}, this.searchAlbumSongsOperationCompleted, userState);
        }
        
        private void OnsearchAlbumSongsOperationCompleted(object arg) {
            if ((this.searchAlbumSongsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.searchAlbumSongsCompleted(this, new searchAlbumSongsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://localhost/IPT/soundNexus/services/webService.php/addAlbumSongs", RequestNamespace="", ResponseNamespace="")]
        [return: System.Xml.Serialization.SoapElementAttribute("response")]
        public string addAlbumSongs(string addtitle, string addfile, string addalbum) {
            object[] results = this.Invoke("addAlbumSongs", new object[] {
                        addtitle,
                        addfile,
                        addalbum});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void addAlbumSongsAsync(string addtitle, string addfile, string addalbum) {
            this.addAlbumSongsAsync(addtitle, addfile, addalbum, null);
        }
        
        /// <remarks/>
        public void addAlbumSongsAsync(string addtitle, string addfile, string addalbum, object userState) {
            if ((this.addAlbumSongsOperationCompleted == null)) {
                this.addAlbumSongsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnaddAlbumSongsOperationCompleted);
            }
            this.InvokeAsync("addAlbumSongs", new object[] {
                        addtitle,
                        addfile,
                        addalbum}, this.addAlbumSongsOperationCompleted, userState);
        }
        
        private void OnaddAlbumSongsOperationCompleted(object arg) {
            if ((this.addAlbumSongsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.addAlbumSongsCompleted(this, new addAlbumSongsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://localhost/IPT/soundNexus/services/webService.php/addAlbums", RequestNamespace="", ResponseNamespace="")]
        [return: System.Xml.Serialization.SoapElementAttribute("response")]
        public string addAlbums(string addtitle, string addartist, string addgenre, [System.Xml.Serialization.SoapElementAttribute(DataType="date")] System.DateTime adddate) {
            object[] results = this.Invoke("addAlbums", new object[] {
                        addtitle,
                        addartist,
                        addgenre,
                        adddate});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void addAlbumsAsync(string addtitle, string addartist, string addgenre, System.DateTime adddate) {
            this.addAlbumsAsync(addtitle, addartist, addgenre, adddate, null);
        }
        
        /// <remarks/>
        public void addAlbumsAsync(string addtitle, string addartist, string addgenre, System.DateTime adddate, object userState) {
            if ((this.addAlbumsOperationCompleted == null)) {
                this.addAlbumsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnaddAlbumsOperationCompleted);
            }
            this.InvokeAsync("addAlbums", new object[] {
                        addtitle,
                        addartist,
                        addgenre,
                        adddate}, this.addAlbumsOperationCompleted, userState);
        }
        
        private void OnaddAlbumsOperationCompleted(object arg) {
            if ((this.addAlbumsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.addAlbumsCompleted(this, new addAlbumsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void getAllAlbumCompletedEventHandler(object sender, getAllAlbumCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getAllAlbumCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getAllAlbumCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void getAllAlbumSongsCompletedEventHandler(object sender, getAllAlbumSongsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getAllAlbumSongsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getAllAlbumSongsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void searchAlbumCompletedEventHandler(object sender, searchAlbumCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class searchAlbumCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal searchAlbumCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void searchAlbumSongsCompletedEventHandler(object sender, searchAlbumSongsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class searchAlbumSongsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal searchAlbumSongsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void addAlbumSongsCompletedEventHandler(object sender, addAlbumSongsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class addAlbumSongsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal addAlbumSongsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void addAlbumsCompletedEventHandler(object sender, addAlbumsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class addAlbumsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal addAlbumsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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