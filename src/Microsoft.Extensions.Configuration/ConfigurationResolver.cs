// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Extensions.Configuration
{
    /// <summary>
    /// A default configuration resolver that basically does nothing.
    /// </summary>
    public class DefaultConfigurationResolver : BaseConfigurationProxy, IConfigurationResolver
    {
        /// <param name="value"></param>
        /// <returns>The given value as is</returns>
        public string Resolve(string value)
        {
            return value;
        }
    }
}