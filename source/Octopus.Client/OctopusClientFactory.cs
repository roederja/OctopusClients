using System;
using System.Threading.Tasks;

namespace Octopus.Client
{
    /// <summary>
    /// Creates instances of the <see cref="IOctopusAsyncClient" />.
    /// </summary>
    public class OctopusClientFactory : IOctopusClientFactory
    {
        /// <summary>
        /// Creates an instance of the client.
        /// </summary>
        /// <param name="serverEndpoint">The server endpoint.</param>
        /// <param name="octopusClientOptions"></param>
        /// <returns>The <see cref="IOctopusAsyncClient" /> instance.</returns>
        public Task<IOctopusAsyncClient> CreateAsyncClient(OctopusServerEndpoint serverEndpoint, OctopusClientOptions octopusClientOptions = null)
        {
            return OctopusAsyncClient.Create(serverEndpoint, octopusClientOptions);
        }
    }
}