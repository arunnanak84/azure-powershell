﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Common.Authentication.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Common.Authentication.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Account needs to be specified.
        /// </summary>
        public static string AccountNeedsToBeSpecified {
            get {
                return ResourceManager.GetString("AccountNeedsToBeSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No account was found for this subscription. Please execute Clear-AzureProfile and then execute Add-AzureAccount..
        /// </summary>
        public static string AccountNotFound {
            get {
                return ResourceManager.GetString("AccountNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Common.Authentication]: Authenticating using configuration values: Domain: &apos;{0}&apos;, Endpoint: &apos;{1}&apos;, ClientId: &apos;{2}&apos;, ClientRedirect: &apos;{3}&apos;, ResourceClientUri: &apos;{4}&apos;, ValidateAuthrity: &apos;{5}&apos;.
        /// </summary>
        public static string AdalAuthConfigurationTrace {
            get {
                return ResourceManager.GetString("AdalAuthConfigurationTrace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Common.Authentication]: Received exception {0}, while authenticating..
        /// </summary>
        public static string AdalAuthException {
            get {
                return ResourceManager.GetString("AdalAuthException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple tokens were found for this user. Please clear your token cache using, Clear-AzureProfile and try this command again..
        /// </summary>
        public static string AdalMultipleTokens {
            get {
                return ResourceManager.GetString("AdalMultipleTokens", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User Interaction is required to authenticate this user. Please authenticate using the log in dialog. In PowerShell, execute Login-AzureRMAccount for Azure Resource Manager cmdlets or Add-AzureAccount for service management cmdlets..
        /// </summary>
        public static string AdalUserInteractionRequired {
            get {
                return ResourceManager.GetString("AdalUserInteractionRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No account found in the context. Please login using Login-AzureRMAccount..
        /// </summary>
        public static string ArmAccountNotFound {
            get {
                return ResourceManager.GetString("ArmAccountNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User Interaction is required to authenticate this user. Please execute Login-AzureRMAccount without parameters and enter your credentials..
        /// </summary>
        public static string ArmUserInteractionRequired {
            get {
                return ResourceManager.GetString("ArmUserInteractionRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Common.Authentication]: Authenticating for account {0} with single tenant {1}.
        /// </summary>
        public static string AuthenticatingForSingleTenant {
            get {
                return ResourceManager.GetString("AuthenticatingForSingleTenant", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Windows Azure Powershell.
        /// </summary>
        public static string AzureDirectoryName {
            get {
                return ResourceManager.GetString("AzureDirectoryName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No certificate was found in the certificate store with thumbprint {0}.
        /// </summary>
        public static string CertificateNotFoundInStore {
            get {
                return ResourceManager.GetString("CertificateNotFoundInStore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Changing public environment is not supported..
        /// </summary>
        public static string ChangingDefaultEnvironmentNotSupported {
            get {
                return ResourceManager.GetString("ChangingDefaultEnvironmentNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -Credential parameter can only be used with Organization ID credentials. For more information, please refer to http://go.microsoft.com/fwlink/?linkid=331007&amp;clcid=0x409 for more information about the difference between an organizational account and a Microsoft account..
        /// </summary>
        public static string CredentialOrganizationIdMessage {
            get {
                return ResourceManager.GetString("CredentialOrganizationIdMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Environment name needs to be specified.
        /// </summary>
        public static string EnvironmentNameNeedsToBeSpecified {
            get {
                return ResourceManager.GetString("EnvironmentNameNeedsToBeSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Environment needs to be specified.
        /// </summary>
        public static string EnvironmentNeedsToBeSpecified {
            get {
                return ResourceManager.GetString("EnvironmentNeedsToBeSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The environment name &apos;{0}&apos; is not found..
        /// </summary>
        public static string EnvironmentNotFound {
            get {
                return ResourceManager.GetString("EnvironmentNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your Microsoft Azure credential in the Windows PowerShell session has expired. Please log in again. In PowerShell, execute Login-AzureRMAccount for Azure Resource Manager cmdlets or Add-AzureAccount for service management cmdlets..
        /// </summary>
        public static string ExpiredRefreshToken {
            get {
                return ResourceManager.GetString("ExpiredRefreshToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File path is not valid.
        /// </summary>
        public static string FilePathIsNotValid {
            get {
                return ResourceManager.GetString("FilePathIsNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Illegal characters in path..
        /// </summary>
        public static string IllegalPath {
            get {
                return ResourceManager.GetString("IllegalPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your Azure credentials have not been set up or have expired, please run Login-AzureRMAccount to set up your Azure credentials..
        /// </summary>
        public static string InvalidArmContext {
            get {
                return ResourceManager.GetString("InvalidArmContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid certificate format. Publish settings may be corrupted. Use Get-AzurePublishSettingsFile to download updated settings.
        /// </summary>
        public static string InvalidCertificate {
            get {
                return ResourceManager.GetString("InvalidCertificate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Credential type invalid, only handles &apos;{0}&apos;.
        /// </summary>
        public static string InvalidCredentialType {
            get {
                return ResourceManager.GetString("InvalidCredentialType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No default subscription has been designated. Use Select-AzureSubscription -Default &lt;subscriptionName&gt; to set the default subscription..
        /// </summary>
        public static string InvalidDefaultSubscription {
            get {
                return ResourceManager.GetString("InvalidDefaultSubscription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;{0}&quot; is an invalid DNS name for {1}.
        /// </summary>
        public static string InvalidDnsName {
            get {
                return ResourceManager.GetString("InvalidDnsName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided file in {0} must be have {1} extension.
        /// </summary>
        public static string InvalidFileExtension {
            get {
                return ResourceManager.GetString("InvalidFileExtension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot create instance of management client type {0}. It does not have the expected constructor..
        /// </summary>
        public static string InvalidManagementClientType {
            get {
                return ResourceManager.GetString("InvalidManagementClientType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is invalid or empty.
        /// </summary>
        public static string InvalidOrEmptyArgumentMessage {
            get {
                return ResourceManager.GetString("InvalidOrEmptyArgumentMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Must specify a non-null subscription name..
        /// </summary>
        public static string InvalidSubscriptionName {
            get {
                return ResourceManager.GetString("InvalidSubscriptionName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your Azure credentials have not been set up or have expired, please run Add-AzureAccount to set up your Azure credentials..
        /// </summary>
        public static string InvalidSubscriptionState {
            get {
                return ResourceManager.GetString("InvalidSubscriptionState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Common.Authentication]: No matching account record for account {0} in subscription {1}.
        /// </summary>
        public static string NoAccountInContext {
            get {
                return ResourceManager.GetString("NoAccountInContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Common.Authentication]: No matching environment record for environment {0} in subscription {1}, using AzureCloud environment instead.
        /// </summary>
        public static string NoEnvironmentInContext {
            get {
                return ResourceManager.GetString("NoEnvironmentInContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please connect to internet before executing this cmdlet.
        /// </summary>
        public static string NoInternetConnection {
            get {
                return ResourceManager.GetString("NoInternetConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No subscription found in the context.  Please ensure that the credentials you provided are authorized to access an Azure subscription, then run Login-AzureRMAccount to login..
        /// </summary>
        public static string NoSubscriptionInContext {
            get {
                return ResourceManager.GetString("NoSubscriptionInContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No tenant found in the context.  Please ensure that the credentials you provided are authorized to access an Azure subscription, then run Login-AzureRMAccount to login..
        /// </summary>
        public static string NoTenantInContext {
            get {
                return ResourceManager.GetString("NoTenantInContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path {0} doesn&apos;t exist..
        /// </summary>
        public static string PathDoesNotExist {
            get {
                return ResourceManager.GetString("PathDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path for {0} doesn&apos;t exist in {1}..
        /// </summary>
        public static string PathDoesNotExistForElement {
            get {
                return ResourceManager.GetString("PathDoesNotExistForElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &amp;whr={0}.
        /// </summary>
        public static string PublishSettingsFileRealmFormat {
            get {
                return ResourceManager.GetString("PublishSettingsFileRealmFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing public environment is not supported..
        /// </summary>
        public static string RemovingDefaultEnvironmentsNotSupported {
            get {
                return ResourceManager.GetString("RemovingDefaultEnvironmentsNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to retrieve service key for ServicePrincipal account {0}. Please log in again to supply the credentials for this service principal. In PowerShell, execute Login-AzureRMAccount for Azure Resource Manager cmdlets or Add-AzureAccount for service management cmdlets..
        /// </summary>
        public static string ServiceKeyNotFound {
            get {
                return ResourceManager.GetString("ServiceKeyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided service name {0} already exists, please pick another name.
        /// </summary>
        public static string ServiceNameExists {
            get {
                return ResourceManager.GetString("ServiceNameExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Common.Authentication]: Renewing token using AppId: &apos;{0}&apos;, AdalConfiguration with ADDomain: &apos;{1}&apos;, AdEndpoint: &apos;{2}&apos;, ClientId: &apos;{3}&apos;, RedirectUri: &apos;{4}&apos;.
        /// </summary>
        public static string SPNRenewTokenTrace {
            get {
                return ResourceManager.GetString("SPNRenewTokenTrace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Common.Authentication]: Checking token expiration, token expires &apos;{0}&apos; Comparing to &apos;{1}&apos; With threshold &apos;{2}&apos;, calculated time until token expiry: &apos;{3}&apos;.
        /// </summary>
        public static string SPNTokenExpirationCheckTrace {
            get {
                return ResourceManager.GetString("SPNTokenExpirationCheckTrace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The subscription id {0} doesn&apos;t exist..
        /// </summary>
        public static string SubscriptionIdNotFoundMessage {
            get {
                return ResourceManager.GetString("SubscriptionIdNotFoundMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Subscription name needs to be specified.
        /// </summary>
        public static string SubscriptionNameNeedsToBeSpecified {
            get {
                return ResourceManager.GetString("SubscriptionNameNeedsToBeSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The subscription name {0} doesn&apos;t exist..
        /// </summary>
        public static string SubscriptionNameNotFoundMessage {
            get {
                return ResourceManager.GetString("SubscriptionNameNotFoundMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Subscription needs to be specified.
        /// </summary>
        public static string SubscriptionNeedsToBeSpecified {
            get {
                return ResourceManager.GetString("SubscriptionNeedsToBeSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No tenant was found for this subscription. Please execute Clear-AzureProfile and then execute Add-AzureAccount..
        /// </summary>
        public static string TenantNotFound {
            get {
                return ResourceManager.GetString("TenantNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to update mismatching Json structured: {0} {1}..
        /// </summary>
        public static string UnableToPatchJson {
            get {
                return ResourceManager.GetString("UnableToPatchJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Illegal credential type.
        /// </summary>
        public static string UnknownCredentialType {
            get {
                return ResourceManager.GetString("UnknownCredentialType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Certificate authentication is not supported for account type {0}..
        /// </summary>
        public static string UnsupportedCredentialType {
            get {
                return ResourceManager.GetString("UnsupportedCredentialType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Common.Authentication]: Acquiring token using AdalConfiguration with Domain: &apos;{0}&apos;, AdEndpoint: &apos;{1}&apos;, ClientId: &apos;{2}&apos;, ClientRedirectUri: {3}.
        /// </summary>
        public static string UPNAcquireTokenConfigTrace {
            get {
                return ResourceManager.GetString("UPNAcquireTokenConfigTrace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Common.Authentication]: Acquiring token using context with Authority &apos;{0}&apos;, CorrelationId: &apos;{1}&apos;, ValidateAuthority: &apos;{2}&apos;.
        /// </summary>
        public static string UPNAcquireTokenContextTrace {
            get {
                return ResourceManager.GetString("UPNAcquireTokenContextTrace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Common.Authentication]: Received token with LoginType &apos;{0}&apos;, Tenant: &apos;{1}&apos;, UserId: &apos;{2}&apos;.
        /// </summary>
        public static string UPNAuthenticationTokenTrace {
            get {
                return ResourceManager.GetString("UPNAuthenticationTokenTrace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Common.Authentication]: Authenticating using Account: &apos;{0}&apos;, environment: &apos;{1}&apos;, tenant: &apos;{2}&apos;.
        /// </summary>
        public static string UPNAuthenticationTrace {
            get {
                return ResourceManager.GetString("UPNAuthenticationTrace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Common.Authentication]: Token is expired.
        /// </summary>
        public static string UPNExpiredTokenTrace {
            get {
                return ResourceManager.GetString("UPNExpiredTokenTrace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Common.Authentication]: Renewing Token with Type: &apos;{0}&apos;, Expiry: &apos;{1}&apos;, Tenant: &apos;{2}&apos;, UserId: &apos;{3}&apos;.
        /// </summary>
        public static string UPNRenewTokenTrace {
            get {
                return ResourceManager.GetString("UPNRenewTokenTrace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Common.Authentication]: User info for token DisplayId: &apos;{0}&apos;, Name: {2} {1}, IdProvider: &apos;{3}&apos;, Uid: &apos;{4}&apos;.
        /// </summary>
        public static string UPNRenewTokenUserInfoTrace {
            get {
                return ResourceManager.GetString("UPNRenewTokenUserInfoTrace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Common.Authentication]: Checking token expiration, token expires &apos;{0}&apos; Comparing to &apos;{1}&apos; With threshold &apos;{2}&apos;, calculated time until token expiry: &apos;{3}&apos;.
        /// </summary>
        public static string UPNTokenExpirationCheckTrace {
            get {
                return ResourceManager.GetString("UPNTokenExpirationCheckTrace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User name is not valid.
        /// </summary>
        public static string UserNameIsNotValid {
            get {
                return ResourceManager.GetString("UserNameIsNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User name needs to be specified.
        /// </summary>
        public static string UserNameNeedsToBeSpecified {
            get {
                return ResourceManager.GetString("UserNameNeedsToBeSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  (x86).
        /// </summary>
        public static string x86InProgramFiles {
            get {
                return ResourceManager.GetString("x86InProgramFiles", resourceCulture);
            }
        }
    }
}
