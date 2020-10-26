// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace WatchdogServiceTests.Mocks
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Fabric;
    using System.Fabric.Description;
    using System.Fabric.Health;

    public class MockCodePackageActivationContext : ICodePackageActivationContext
    {
        public MockCodePackageActivationContext(
            string ApplicationName,
            string ApplicationTypeName,
            string CodePackageName,
            string CodePackageVersion,
            string Context,
            string LogDirectory,
            string TempDirectory,
            string WorkDirectory,
            string ServiceManifestName,
            string ServiceManifestVersion)
        {
            this.ApplicationName = ApplicationName;
            this.ApplicationTypeName = ApplicationTypeName;
            this.CodePackageName = CodePackageName;
            this.CodePackageVersion = CodePackageVersion;
            this.ContextId = Context;
            this.LogDirectory = LogDirectory;
            this.TempDirectory = TempDirectory;
            this.WorkDirectory = WorkDirectory;
        }

        event EventHandler<PackageAddedEventArgs<CodePackage>> ICodePackageActivationContext.CodePackageAddedEvent
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        event EventHandler<PackageRemovedEventArgs<CodePackage>> ICodePackageActivationContext.CodePackageRemovedEvent
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        event EventHandler<PackageModifiedEventArgs<CodePackage>> ICodePackageActivationContext.CodePackageModifiedEvent
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        event EventHandler<PackageAddedEventArgs<ConfigurationPackage>> ICodePackageActivationContext.ConfigurationPackageAddedEvent
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        event EventHandler<PackageRemovedEventArgs<ConfigurationPackage>> ICodePackageActivationContext.ConfigurationPackageRemovedEvent
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        event EventHandler<PackageModifiedEventArgs<ConfigurationPackage>> ICodePackageActivationContext.ConfigurationPackageModifiedEvent
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        event EventHandler<PackageAddedEventArgs<DataPackage>> ICodePackageActivationContext.DataPackageAddedEvent
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        event EventHandler<PackageRemovedEventArgs<DataPackage>> ICodePackageActivationContext.DataPackageRemovedEvent
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        event EventHandler<PackageModifiedEventArgs<DataPackage>> ICodePackageActivationContext.DataPackageModifiedEvent
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        private string ServiceManifetName { get; set; }

        private string ServiceManifestVersion { get; set; }

        public string ApplicationName { get; private set; }

        public string ApplicationTypeName { get; private set; }

        public string CodePackageName { get; private set; }

        public string CodePackageVersion { get; private set; }

        public string ContextId { get; private set; }

        public string LogDirectory { get; private set; }

        public string TempDirectory { get; private set; }

        public string WorkDirectory { get; private set; }

        string ICodePackageActivationContext.WorkDirectory => throw new NotImplementedException();

        string ICodePackageActivationContext.LogDirectory => throw new NotImplementedException();

        string ICodePackageActivationContext.TempDirectory => throw new NotImplementedException();

        string ICodePackageActivationContext.ContextId => throw new NotImplementedException();

        string ICodePackageActivationContext.CodePackageName => throw new NotImplementedException();

        string ICodePackageActivationContext.CodePackageVersion => throw new NotImplementedException();

        string ICodePackageActivationContext.ApplicationName => throw new NotImplementedException();

        string ICodePackageActivationContext.ApplicationTypeName => throw new NotImplementedException();

        public event EventHandler<PackageAddedEventArgs<CodePackage>> CodePackageAddedEvent;

        public event EventHandler<PackageModifiedEventArgs<CodePackage>> CodePackageModifiedEvent;

        public event EventHandler<PackageRemovedEventArgs<CodePackage>> CodePackageRemovedEvent;

        public event EventHandler<PackageAddedEventArgs<ConfigurationPackage>> ConfigurationPackageAddedEvent;

        public event EventHandler<PackageModifiedEventArgs<ConfigurationPackage>> ConfigurationPackageModifiedEvent;

        public event EventHandler<PackageRemovedEventArgs<ConfigurationPackage>> ConfigurationPackageRemovedEvent;

        public event EventHandler<PackageAddedEventArgs<DataPackage>> DataPackageAddedEvent;

        public event EventHandler<PackageModifiedEventArgs<DataPackage>> DataPackageModifiedEvent;

        public event EventHandler<PackageRemovedEventArgs<DataPackage>> DataPackageRemovedEvent;

        public ApplicationPrincipalsDescription GetApplicationPrincipals()
        {
            throw new NotImplementedException();
        }

        public IList<string> GetCodePackageNames()
        {
            return new List<string>() {this.CodePackageName};
        }

        public CodePackage GetCodePackageObject(string packageName)
        {
            throw new NotImplementedException();
        }

        public IList<string> GetConfigurationPackageNames()
        {
            return new List<string>() {""};
        }

        public ConfigurationPackage GetConfigurationPackageObject(string packageName)
        {
            throw new NotImplementedException();
        }

        public IList<string> GetDataPackageNames()
        {
            return new List<string>() {""};
        }

        public DataPackage GetDataPackageObject(string packageName)
        {
            throw new NotImplementedException();
        }

        public EndpointResourceDescription GetEndpoint(string endpointName)
        {
            throw new NotImplementedException();
        }

        public KeyedCollection<string, EndpointResourceDescription> GetEndpoints()
        {
            throw new NotImplementedException();
        }

        public KeyedCollection<string, ServiceGroupTypeDescription> GetServiceGroupTypes()
        {
            throw new NotImplementedException();
        }

        public string GetServiceManifestName()
        {
            return this.ServiceManifetName;
        }

        public string GetServiceManifestVersion()
        {
            return this.ServiceManifestVersion;
        }

        public KeyedCollection<string, ServiceTypeDescription> GetServiceTypes()
        {
            throw new NotImplementedException();
        }

        public void ReportApplicationHealth(HealthInformation healthInformation)
        {
            throw new NotImplementedException();
        }

        public void ReportDeployedServicePackageHealth(HealthInformation healthInformation)
        {
            throw new NotImplementedException();
        }

        public void ReportDeployedApplicationHealth(HealthInformation healthInformation)
        {
            throw new NotImplementedException();
        }

        #region IDisposable Support

        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                this.disposedValue = true;
            }
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            this.Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }

        KeyedCollection<string, ServiceTypeDescription> ICodePackageActivationContext.GetServiceTypes()
        {
            throw new NotImplementedException();
        }

        KeyedCollection<string, ServiceGroupTypeDescription> ICodePackageActivationContext.GetServiceGroupTypes()
        {
            throw new NotImplementedException();
        }

        ApplicationPrincipalsDescription ICodePackageActivationContext.GetApplicationPrincipals()
        {
            throw new NotImplementedException();
        }

        KeyedCollection<string, EndpointResourceDescription> ICodePackageActivationContext.GetEndpoints()
        {
            throw new NotImplementedException();
        }

        EndpointResourceDescription ICodePackageActivationContext.GetEndpoint(string endpointName)
        {
            throw new NotImplementedException();
        }

        IList<string> ICodePackageActivationContext.GetCodePackageNames()
        {
            throw new NotImplementedException();
        }

        IList<string> ICodePackageActivationContext.GetConfigurationPackageNames()
        {
            throw new NotImplementedException();
        }

        IList<string> ICodePackageActivationContext.GetDataPackageNames()
        {
            throw new NotImplementedException();
        }

        CodePackage ICodePackageActivationContext.GetCodePackageObject(string packageName)
        {
            throw new NotImplementedException();
        }

        ConfigurationPackage ICodePackageActivationContext.GetConfigurationPackageObject(string packageName)
        {
            throw new NotImplementedException();
        }

        DataPackage ICodePackageActivationContext.GetDataPackageObject(string packageName)
        {
            throw new NotImplementedException();
        }

        string ICodePackageActivationContext.GetServiceManifestName()
        {
            throw new NotImplementedException();
        }

        string ICodePackageActivationContext.GetServiceManifestVersion()
        {
            throw new NotImplementedException();
        }

        void ICodePackageActivationContext.ReportApplicationHealth(HealthInformation healthInfo)
        {
            throw new NotImplementedException();
        }

        void ICodePackageActivationContext.ReportApplicationHealth(HealthInformation healthInfo, HealthReportSendOptions sendOptions)
        {
            throw new NotImplementedException();
        }

        void ICodePackageActivationContext.ReportDeployedApplicationHealth(HealthInformation healthInfo)
        {
            throw new NotImplementedException();
        }

        void ICodePackageActivationContext.ReportDeployedApplicationHealth(HealthInformation healthInfo, HealthReportSendOptions sendOptions)
        {
            throw new NotImplementedException();
        }

        void ICodePackageActivationContext.ReportDeployedServicePackageHealth(HealthInformation healthInfo)
        {
            throw new NotImplementedException();
        }

        void ICodePackageActivationContext.ReportDeployedServicePackageHealth(HealthInformation healthInfo, HealthReportSendOptions sendOptions)
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}