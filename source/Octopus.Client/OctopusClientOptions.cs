﻿using System.Net;
using System.Security.Authentication;

namespace Octopus.Client
{
    /// <summary>
    /// Options used to change the behaviour of <see cref="OctopusAsyncClient" />
    /// </summary>
    public class OctopusClientOptions
    {
        public OctopusClientOptions()
        {
#if HTTP_CLIENT_SUPPORTS_SSL_OPTIONS
            SslProtocols = SslProtocols.Tls
               | SslProtocols.Tls11
               | SslProtocols.Tls12;
#endif
        }
#if HTTP_CLIENT_SUPPORTS_SSL_OPTIONS
        /// <summary>
        /// The allowed SSL Protocols
        /// </summary>
        public SslProtocols SslProtocols { get; set; }

        /// <summary>
        /// If true, SSL certificate errors are ignored
        /// </summary>
        public bool IgnoreSslErrors { get; set; }

#endif
    }
}