﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.Auth.Storage {
    using Microsoft.Azure.IIoT.Storage;
    using Microsoft.Identity.Client;

    /// <summary>
    /// Decorates a client with a cache to keep tokens
    /// </summary>
    public class MsalConfidentialClientDecorator :
        MsalClientApplicationDecorator<IConfidentialClientApplication> {

        /// <summary>
        /// Create token cache
        /// </summary>
        /// <param name="client"></param>
        /// <param name="cache"></param>
        /// <param name="applicationKey"></param>
        /// <param name="userKey"></param>
        public MsalConfidentialClientDecorator(IConfidentialClientApplication client,
            ICache cache, string applicationKey, string userKey) : base(client, cache, userKey) {
            _appTokenCache = new MsalTokenCacheDecorator(cache,
                client.AppTokenCache, applicationKey);
        }

        private readonly MsalTokenCacheDecorator _appTokenCache;
    }
}