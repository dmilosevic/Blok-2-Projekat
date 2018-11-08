﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Security.Cryptography.X509Certificates;
using System.Security;

namespace Contract
{
    [ServiceContract]
    public interface ICertificateManager
    {
        [OperationContract]
        X509Certificate2 GenerateCertificate(string root);

        [OperationContract]
        [FaultContract(typeof(SecurityException))]
        [FaultContract(typeof(ArgumentNullException))]
        void RevokeCertificate(X509Certificate2 certificate);


    }
}
