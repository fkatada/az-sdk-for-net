// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.DigitalTwins.Core
{
    /// <summary> A more specific error description than was provided by the containing error. </summary>
    public partial class InnerError
    {
        /// <summary> Initializes a new instance of <see cref="InnerError"/>. </summary>
        public InnerError()
        {
        }

        /// <summary> Initializes a new instance of <see cref="InnerError"/>. </summary>
        /// <param name="code"> A more specific error code than was provided by the containing error. </param>
        /// <param name="innererror"> An object containing more specific information than the current object about the error. </param>
        internal InnerError(string code, InnerError innererror)
        {
            Code = code;
            Innererror = innererror;
        }

        /// <summary> A more specific error code than was provided by the containing error. </summary>
        public string Code { get; set; }
        /// <summary> An object containing more specific information than the current object about the error. </summary>
        public InnerError Innererror { get; set; }
    }
}
