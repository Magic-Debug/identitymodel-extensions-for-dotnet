﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using Microsoft.IdentityModel.Tokens;

namespace Microsoft.IdentityModel.JsonWebTokens
{
    /// <summary>
    /// Represents the parameters needed to decrypt a JSON Web Token
    /// </summary>
    internal class JwtTokenDecryptionParameters
    {
        /// <summary>
        /// Gets or sets signature algorithm that was used to create the signature.
        /// </summary>
        public string Alg { get; set; }

        /// <summary>
        /// Gets or sets the AuthenticationTag from the original raw data of this instance when it was created.
        /// </summary>
        public string AuthenticationTag { get; set; }

        /// <summary>
        /// Gets or sets the Ciphertext from the original raw data of this instance when it was created.
        /// </summary>
        public string Ciphertext { get; set; }

        /// <summary>
        /// Gets or sets the function used to attempt decompression with.
        /// </summary>
        public Func<byte[], string, string> DecompressionFunction { get; set; }

        /// <summary>
        /// Gets or sets the encryption algorithm (Enc) of the token.
        /// </summary>
        public string Enc { get; set; }

        /// <summary>
        /// Gets the EncodedHeader from the original raw data of this instance when it was created.
        /// </summary>
        public string EncodedHeader { get; set; }

        /// <summary>
        /// Gets or sets the EncodedHeader from the original raw data of this instance when it was created.
        /// </summary>
        public string EncodedToken { get; set; }

        /// <summary>
        /// Gets or sets the InitializationVector from the original raw data of this instance when it was created.
        /// </summary>
        public string InitializationVector { get; set; }

        /// <summary>
        /// Gets or sets the collection of <see cref="SecurityKey"/>s to attempt to decrypt with.
        /// </summary>
        public IEnumerable<SecurityKey> Keys { get; set; }

        /// <summary>
        /// Gets or sets the 'value' of the 'zip' claim.
        /// </summary>
        public string Zip { get; set; }
    }
}
