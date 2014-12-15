// Copyright (c) 2014, Outercurve Foundation.
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
//
// - Redistributions of source code must  retain  the  above copyright notice, this
//   list of conditions and the following disclaimer.
//
// - Redistributions in binary form  must  reproduce the  above  copyright  notice,
//   this list of conditions  and  the  following  disclaimer in  the documentation
//   and/or other materials provided with the distribution.
//
// - Neither  the  name  of  the  Outercurve Foundation  nor   the   names  of  its
//   contributors may be used to endorse or  promote  products  derived  from  this
//   software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING,  BUT  NOT  LIMITED TO, THE IMPLIED
// WARRANTIES  OF  MERCHANTABILITY   AND  FITNESS  FOR  A  PARTICULAR  PURPOSE  ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR
// ANY DIRECT, INDIRECT, INCIDENTAL,  SPECIAL,  EXEMPLARY, OR CONSEQUENTIAL DAMAGES
// (INCLUDING, BUT NOT LIMITED TO,  PROCUREMENT  OF  SUBSTITUTE  GOODS OR SERVICES;
// LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)  HOWEVER  CAUSED AND ON
// ANY  THEORY  OF  LIABILITY,  WHETHER  IN  CONTRACT,  STRICT  LIABILITY,  OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE)  ARISING  IN  ANY WAY OUT OF THE USE OF THIS
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=2.0.50727.42.
// 
namespace WebsitePanel.EnterpriseServer {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    using System.Data;
    using WebsitePanel.Providers;
    using WebsitePanel.Providers.FTP;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="esFtpServersSoap", Namespace="http://smbsaas/websitepanel/enterpriseserver")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceProviderItem))]
    public partial class esFtpServers : Microsoft.Web.Services3.WebServicesClientProtocol {
        
        private System.Threading.SendOrPostCallback GetFtpSitesOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetRawFtpAccountsPagedOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetFtpAccountsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetFtpAccountOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddFtpAccountOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateFtpAccountOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteFtpAccountOperationCompleted;
        
        /// <remarks/>
        public esFtpServers() {
            this.Url = "http://localhost/WebsitePanelEnterpriseServer11/esFtpServers.asmx";
        }
        
        /// <remarks/>
        public event GetFtpSitesCompletedEventHandler GetFtpSitesCompleted;
        
        /// <remarks/>
        public event GetRawFtpAccountsPagedCompletedEventHandler GetRawFtpAccountsPagedCompleted;
        
        /// <remarks/>
        public event GetFtpAccountsCompletedEventHandler GetFtpAccountsCompleted;
        
        /// <remarks/>
        public event GetFtpAccountCompletedEventHandler GetFtpAccountCompleted;
        
        /// <remarks/>
        public event AddFtpAccountCompletedEventHandler AddFtpAccountCompleted;
        
        /// <remarks/>
        public event UpdateFtpAccountCompletedEventHandler UpdateFtpAccountCompleted;
        
        /// <remarks/>
        public event DeleteFtpAccountCompletedEventHandler DeleteFtpAccountCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/enterpriseserver/GetFtpSites", RequestNamespace="http://smbsaas/websitepanel/enterpriseserver", ResponseNamespace="http://smbsaas/websitepanel/enterpriseserver", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public FtpSite[] GetFtpSites(int serviceId) {
            object[] results = this.Invoke("GetFtpSites", new object[] {
                        serviceId});
            return ((FtpSite[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetFtpSites(int serviceId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetFtpSites", new object[] {
                        serviceId}, callback, asyncState);
        }
        
        /// <remarks/>
        public FtpSite[] EndGetFtpSites(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((FtpSite[])(results[0]));
        }
        
        /// <remarks/>
        public void GetFtpSitesAsync(int serviceId) {
            this.GetFtpSitesAsync(serviceId, null);
        }
        
        /// <remarks/>
        public void GetFtpSitesAsync(int serviceId, object userState) {
            if ((this.GetFtpSitesOperationCompleted == null)) {
                this.GetFtpSitesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFtpSitesOperationCompleted);
            }
            this.InvokeAsync("GetFtpSites", new object[] {
                        serviceId}, this.GetFtpSitesOperationCompleted, userState);
        }
        
        private void OnGetFtpSitesOperationCompleted(object arg) {
            if ((this.GetFtpSitesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFtpSitesCompleted(this, new GetFtpSitesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/enterpriseserver/GetRawFtpAccountsPaged", RequestNamespace="http://smbsaas/websitepanel/enterpriseserver", ResponseNamespace="http://smbsaas/websitepanel/enterpriseserver", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetRawFtpAccountsPaged(int packageId, string filterColumn, string filterValue, string sortColumn, int startRow, int maximumRows) {
            object[] results = this.Invoke("GetRawFtpAccountsPaged", new object[] {
                        packageId,
                        filterColumn,
                        filterValue,
                        sortColumn,
                        startRow,
                        maximumRows});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetRawFtpAccountsPaged(int packageId, string filterColumn, string filterValue, string sortColumn, int startRow, int maximumRows, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetRawFtpAccountsPaged", new object[] {
                        packageId,
                        filterColumn,
                        filterValue,
                        sortColumn,
                        startRow,
                        maximumRows}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndGetRawFtpAccountsPaged(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetRawFtpAccountsPagedAsync(int packageId, string filterColumn, string filterValue, string sortColumn, int startRow, int maximumRows) {
            this.GetRawFtpAccountsPagedAsync(packageId, filterColumn, filterValue, sortColumn, startRow, maximumRows, null);
        }
        
        /// <remarks/>
        public void GetRawFtpAccountsPagedAsync(int packageId, string filterColumn, string filterValue, string sortColumn, int startRow, int maximumRows, object userState) {
            if ((this.GetRawFtpAccountsPagedOperationCompleted == null)) {
                this.GetRawFtpAccountsPagedOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetRawFtpAccountsPagedOperationCompleted);
            }
            this.InvokeAsync("GetRawFtpAccountsPaged", new object[] {
                        packageId,
                        filterColumn,
                        filterValue,
                        sortColumn,
                        startRow,
                        maximumRows}, this.GetRawFtpAccountsPagedOperationCompleted, userState);
        }
        
        private void OnGetRawFtpAccountsPagedOperationCompleted(object arg) {
            if ((this.GetRawFtpAccountsPagedCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetRawFtpAccountsPagedCompleted(this, new GetRawFtpAccountsPagedCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/enterpriseserver/GetFtpAccounts", RequestNamespace="http://smbsaas/websitepanel/enterpriseserver", ResponseNamespace="http://smbsaas/websitepanel/enterpriseserver", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public FtpAccount[] GetFtpAccounts(int packageId, bool recursive) {
            object[] results = this.Invoke("GetFtpAccounts", new object[] {
                        packageId,
                        recursive});
            return ((FtpAccount[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetFtpAccounts(int packageId, bool recursive, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetFtpAccounts", new object[] {
                        packageId,
                        recursive}, callback, asyncState);
        }
        
        /// <remarks/>
        public FtpAccount[] EndGetFtpAccounts(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((FtpAccount[])(results[0]));
        }
        
        /// <remarks/>
        public void GetFtpAccountsAsync(int packageId, bool recursive) {
            this.GetFtpAccountsAsync(packageId, recursive, null);
        }
        
        /// <remarks/>
        public void GetFtpAccountsAsync(int packageId, bool recursive, object userState) {
            if ((this.GetFtpAccountsOperationCompleted == null)) {
                this.GetFtpAccountsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFtpAccountsOperationCompleted);
            }
            this.InvokeAsync("GetFtpAccounts", new object[] {
                        packageId,
                        recursive}, this.GetFtpAccountsOperationCompleted, userState);
        }
        
        private void OnGetFtpAccountsOperationCompleted(object arg) {
            if ((this.GetFtpAccountsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFtpAccountsCompleted(this, new GetFtpAccountsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/enterpriseserver/GetFtpAccount", RequestNamespace="http://smbsaas/websitepanel/enterpriseserver", ResponseNamespace="http://smbsaas/websitepanel/enterpriseserver", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public FtpAccount GetFtpAccount(int itemId) {
            object[] results = this.Invoke("GetFtpAccount", new object[] {
                        itemId});
            return ((FtpAccount)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetFtpAccount(int itemId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetFtpAccount", new object[] {
                        itemId}, callback, asyncState);
        }
        
        /// <remarks/>
        public FtpAccount EndGetFtpAccount(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((FtpAccount)(results[0]));
        }
        
        /// <remarks/>
        public void GetFtpAccountAsync(int itemId) {
            this.GetFtpAccountAsync(itemId, null);
        }
        
        /// <remarks/>
        public void GetFtpAccountAsync(int itemId, object userState) {
            if ((this.GetFtpAccountOperationCompleted == null)) {
                this.GetFtpAccountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFtpAccountOperationCompleted);
            }
            this.InvokeAsync("GetFtpAccount", new object[] {
                        itemId}, this.GetFtpAccountOperationCompleted, userState);
        }
        
        private void OnGetFtpAccountOperationCompleted(object arg) {
            if ((this.GetFtpAccountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFtpAccountCompleted(this, new GetFtpAccountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/enterpriseserver/AddFtpAccount", RequestNamespace="http://smbsaas/websitepanel/enterpriseserver", ResponseNamespace="http://smbsaas/websitepanel/enterpriseserver", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int AddFtpAccount(FtpAccount item) {
            object[] results = this.Invoke("AddFtpAccount", new object[] {
                        item});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginAddFtpAccount(FtpAccount item, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("AddFtpAccount", new object[] {
                        item}, callback, asyncState);
        }
        
        /// <remarks/>
        public int EndAddFtpAccount(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void AddFtpAccountAsync(FtpAccount item) {
            this.AddFtpAccountAsync(item, null);
        }
        
        /// <remarks/>
        public void AddFtpAccountAsync(FtpAccount item, object userState) {
            if ((this.AddFtpAccountOperationCompleted == null)) {
                this.AddFtpAccountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddFtpAccountOperationCompleted);
            }
            this.InvokeAsync("AddFtpAccount", new object[] {
                        item}, this.AddFtpAccountOperationCompleted, userState);
        }
        
        private void OnAddFtpAccountOperationCompleted(object arg) {
            if ((this.AddFtpAccountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddFtpAccountCompleted(this, new AddFtpAccountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/enterpriseserver/UpdateFtpAccount", RequestNamespace="http://smbsaas/websitepanel/enterpriseserver", ResponseNamespace="http://smbsaas/websitepanel/enterpriseserver", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int UpdateFtpAccount(FtpAccount item) {
            object[] results = this.Invoke("UpdateFtpAccount", new object[] {
                        item});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginUpdateFtpAccount(FtpAccount item, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("UpdateFtpAccount", new object[] {
                        item}, callback, asyncState);
        }
        
        /// <remarks/>
        public int EndUpdateFtpAccount(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void UpdateFtpAccountAsync(FtpAccount item) {
            this.UpdateFtpAccountAsync(item, null);
        }
        
        /// <remarks/>
        public void UpdateFtpAccountAsync(FtpAccount item, object userState) {
            if ((this.UpdateFtpAccountOperationCompleted == null)) {
                this.UpdateFtpAccountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateFtpAccountOperationCompleted);
            }
            this.InvokeAsync("UpdateFtpAccount", new object[] {
                        item}, this.UpdateFtpAccountOperationCompleted, userState);
        }
        
        private void OnUpdateFtpAccountOperationCompleted(object arg) {
            if ((this.UpdateFtpAccountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateFtpAccountCompleted(this, new UpdateFtpAccountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/enterpriseserver/DeleteFtpAccount", RequestNamespace="http://smbsaas/websitepanel/enterpriseserver", ResponseNamespace="http://smbsaas/websitepanel/enterpriseserver", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int DeleteFtpAccount(int itemId) {
            object[] results = this.Invoke("DeleteFtpAccount", new object[] {
                        itemId});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginDeleteFtpAccount(int itemId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("DeleteFtpAccount", new object[] {
                        itemId}, callback, asyncState);
        }
        
        /// <remarks/>
        public int EndDeleteFtpAccount(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void DeleteFtpAccountAsync(int itemId) {
            this.DeleteFtpAccountAsync(itemId, null);
        }
        
        /// <remarks/>
        public void DeleteFtpAccountAsync(int itemId, object userState) {
            if ((this.DeleteFtpAccountOperationCompleted == null)) {
                this.DeleteFtpAccountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteFtpAccountOperationCompleted);
            }
            this.InvokeAsync("DeleteFtpAccount", new object[] {
                        itemId}, this.DeleteFtpAccountOperationCompleted, userState);
        }
        
        private void OnDeleteFtpAccountOperationCompleted(object arg) {
            if ((this.DeleteFtpAccountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteFtpAccountCompleted(this, new DeleteFtpAccountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void GetFtpSitesCompletedEventHandler(object sender, GetFtpSitesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFtpSitesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetFtpSitesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public FtpSite[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((FtpSite[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void GetRawFtpAccountsPagedCompletedEventHandler(object sender, GetRawFtpAccountsPagedCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetRawFtpAccountsPagedCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetRawFtpAccountsPagedCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void GetFtpAccountsCompletedEventHandler(object sender, GetFtpAccountsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFtpAccountsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetFtpAccountsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public FtpAccount[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((FtpAccount[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void GetFtpAccountCompletedEventHandler(object sender, GetFtpAccountCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFtpAccountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetFtpAccountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public FtpAccount Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((FtpAccount)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void AddFtpAccountCompletedEventHandler(object sender, AddFtpAccountCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddFtpAccountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddFtpAccountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void UpdateFtpAccountCompletedEventHandler(object sender, UpdateFtpAccountCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdateFtpAccountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpdateFtpAccountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void DeleteFtpAccountCompletedEventHandler(object sender, DeleteFtpAccountCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteFtpAccountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeleteFtpAccountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
}
