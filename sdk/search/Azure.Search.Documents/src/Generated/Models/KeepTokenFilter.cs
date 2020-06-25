// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> A token filter that only keeps tokens with text contained in a specified list of words. This token filter is implemented using Apache Lucene. </summary>
    public partial class KeepTokenFilter : TokenFilter
    {
        /// <summary> Initializes a new instance of KeepTokenFilter. </summary>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="keepWords"> The list of words to keep. </param>
        public KeepTokenFilter(string name, IEnumerable<string> keepWords) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (keepWords == null)
            {
                throw new ArgumentNullException(nameof(keepWords));
            }

            KeepWords = keepWords.ToList();
            ODataType = "#Microsoft.Azure.Search.KeepTokenFilter";
        }

        /// <summary> Initializes a new instance of KeepTokenFilter. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the token filter. </param>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="keepWords"> The list of words to keep. </param>
        /// <param name="lowerCaseKeepWords"> A value indicating whether to lower case all words first. Default is false. </param>
        internal KeepTokenFilter(string oDataType, string name, IList<string> keepWords, bool? lowerCaseKeepWords) : base(oDataType, name)
        {
            KeepWords = keepWords ?? new List<string>();
            LowerCaseKeepWords = lowerCaseKeepWords;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.KeepTokenFilter";
        }
        /// <summary> A value indicating whether to lower case all words first. Default is false. </summary>
        public bool? LowerCaseKeepWords { get; set; }
    }
}
