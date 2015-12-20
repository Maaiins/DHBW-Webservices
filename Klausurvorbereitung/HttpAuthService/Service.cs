using System;
using System.Security.Authentication;
using System.Security.Principal;
using System.ServiceModel;
using Contracts.Interfaces;

namespace HttpAuthService
{
    public class Service : IService
    {
        public int AddOne(int value)
        {
            //Aus AppConfig hole ich Identität, die eingetragen ist
            var requestedIdentity = ServiceSecurityContext.Current.WindowsIdentity;
            var threadIdentity = WindowsIdentity.GetCurrent();


            //Authenthisierung
            //Überprüft Eingetragenen mit aktuellem User
            if (!requestedIdentity.Name.Contains(Environment.UserName))
            {
                throw new AuthenticationException("User is not authorized.");
            }

            requestedIdentity.Impersonate();

            //Code, der durchgeführt werden soll
            return value + 1;
        }
    }
}