using Microsoft.Extensions.Primitives;

namespace Microsoft.Extensions.Configuration
{
    /// <summary>
    /// Resolves a given configuration value. For example, an Azure KeyVault resolver could resolve
    /// the value $KeyVault(foo) to a secret where the key is foo.
    /// </summary>
    public interface IConfigurationResolver : IConfigurationProxy
    {
        /// <summary>
        /// Resolves a given configuration value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>The new value if the input value was resolved, otherwise, the input value is returned as is</returns>
        string Resolve(string value);
    }
}