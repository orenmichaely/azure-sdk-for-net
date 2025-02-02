// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the parameters for the Url Signing action. </summary>
    public partial class UriSigningActionDefinition
    {
        /// <summary> Initializes a new instance of UriSigningActionDefinition. </summary>
        /// <param name="typeDefinition"></param>
        public UriSigningActionDefinition(UriSigningActionType typeDefinition)
        {
            TypeDefinition = typeDefinition;
            ParameterNameOverride = new ChangeTrackingList<UriSigningParamIdentifier>();
        }

        /// <summary> Initializes a new instance of UriSigningActionDefinition. </summary>
        /// <param name="typeDefinition"></param>
        /// <param name="algorithm"> Algorithm to use for URL signing. </param>
        /// <param name="parameterNameOverride"> Defines which query string parameters in the url to be considered for expires, key id etc. </param>
        internal UriSigningActionDefinition(UriSigningActionType typeDefinition, UriSigningAlgorithm? algorithm, IList<UriSigningParamIdentifier> parameterNameOverride)
        {
            TypeDefinition = typeDefinition;
            Algorithm = algorithm;
            ParameterNameOverride = parameterNameOverride;
        }

        /// <summary> Gets or sets the type definition. </summary>
        public UriSigningActionType TypeDefinition { get; set; }
        /// <summary> Algorithm to use for URL signing. </summary>
        public UriSigningAlgorithm? Algorithm { get; set; }
        /// <summary> Defines which query string parameters in the url to be considered for expires, key id etc. </summary>
        public IList<UriSigningParamIdentifier> ParameterNameOverride { get; }
    }
}
