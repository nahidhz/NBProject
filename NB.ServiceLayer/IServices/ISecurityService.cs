using System;
using System.Collections.Generic;
using System.Text;

namespace NB.ServiceLayer.IServices
{
   public interface ISecurityService
    {
        string GetSha256Hash(string input);
        Guid CreateCryptographicallySecureGuid();
    }
}
