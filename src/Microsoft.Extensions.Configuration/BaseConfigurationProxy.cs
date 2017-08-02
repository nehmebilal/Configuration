using System.Threading;
using Microsoft.Extensions.Primitives;

namespace Microsoft.Extensions.Configuration
{
    /// <summary>
    /// Base helper class for implementation a <see cref="IConfigurationProxy"/>
    /// </summary>
    public class BaseConfigurationProxy : IConfigurationProxy
    {
        private ConfigurationReloadToken _reloadToken = new ConfigurationReloadToken();

        /// <summary>
        /// Returns a <see cref="IChangeToken"/> that can be used to listen when this proxy is reloaded.
        /// </summary>
        /// <returns></returns>
        public IChangeToken GetReloadToken()
        {
            return _reloadToken;
        }

        /// <summary>
        /// Loads (or reloads) the data for this resolver.
        /// </summary>
        public virtual void Load()
        {
        }

        /// <summary>
        /// Triggers the reload change token and creates a new one.
        /// </summary>
        protected void OnReload()
        {
            var previousToken = Interlocked.Exchange<ConfigurationReloadToken>(ref _reloadToken, new ConfigurationReloadToken());
            previousToken.OnReload();
        }
    }
}