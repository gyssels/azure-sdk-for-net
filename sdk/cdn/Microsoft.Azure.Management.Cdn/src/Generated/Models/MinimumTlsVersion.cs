// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for MinimumTlsVersion.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MinimumTlsVersion
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "TLS10")]
        TLS10,
        [EnumMember(Value = "TLS12")]
        TLS12
    }
    internal static class MinimumTlsVersionEnumExtension
    {
        internal static string ToSerializedValue(this MinimumTlsVersion? value)
        {
            return value == null ? null : ((MinimumTlsVersion)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this MinimumTlsVersion value)
        {
            switch( value )
            {
                case MinimumTlsVersion.None:
                    return "None";
                case MinimumTlsVersion.TLS10:
                    return "TLS10";
                case MinimumTlsVersion.TLS12:
                    return "TLS12";
            }
            return null;
        }

        internal static MinimumTlsVersion? ParseMinimumTlsVersion(this string value)
        {
            switch( value )
            {
                case "None":
                    return MinimumTlsVersion.None;
                case "TLS10":
                    return MinimumTlsVersion.TLS10;
                case "TLS12":
                    return MinimumTlsVersion.TLS12;
            }
            return null;
        }
    }
}