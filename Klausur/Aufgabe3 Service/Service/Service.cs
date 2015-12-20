using System;
using System.Security.Authentication;
using System.Security.Principal;
using System.ServiceModel;
using Aufgabe3_Service.Interfaces;

namespace Aufgabe3_Service.Service
{
    public class Service : IService
    {
        public string WhoAmI()
        {
            var requestedIdentity = ServiceSecurityContext.Current.WindowsIdentity;

            requestedIdentity.Impersonate();

            return requestedIdentity.Name;
        }
    }
}