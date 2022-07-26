﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Runtime.Serialization;

namespace Microsoft.IdentityModel.Protocols.SignedHttpRequest
{
    /// <summary>
    /// This exception is thrown when signature of a SignedHttpRequest is not valid. 
    /// </summary>
    [Serializable]
    public class SignedHttpRequestInvalidSignatureException : SignedHttpRequestValidationException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignedHttpRequestInvalidSignatureException"/> class.
        /// </summary>
        public SignedHttpRequestInvalidSignatureException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignedHttpRequestInvalidSignatureException"/> class.
        /// </summary>
        /// <param name="message">Additional information to be included in the exception and displayed to user.</param>
        public SignedHttpRequestInvalidSignatureException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignedHttpRequestInvalidSignatureException"/> class.
        /// </summary>
        /// <param name="message">Additional information to be included in the exception and displayed to user.</param>
        /// <param name="innerException">A <see cref="Exception"/> that represents the root cause of the exception.</param>
        public SignedHttpRequestInvalidSignatureException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignedHttpRequestInvalidSignatureException"/> class.
        /// </summary>
        /// <param name="info">the <see cref="SerializationInfo"/> that holds the serialized object data.</param>
        /// <param name="context">The contextual information about the source or destination.</param>
        protected SignedHttpRequestInvalidSignatureException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
