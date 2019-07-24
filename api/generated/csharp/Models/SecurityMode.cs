// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.IIoT.Opc.History.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SecurityMode.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SecurityMode
    {
        [EnumMember(Value = "Best")]
        Best,
        [EnumMember(Value = "Sign")]
        Sign,
        [EnumMember(Value = "SignAndEncrypt")]
        SignAndEncrypt,
        [EnumMember(Value = "None")]
        None
    }
    internal static class SecurityModeEnumExtension
    {
        internal static string ToSerializedValue(this SecurityMode? value)
        {
            return value == null ? null : ((SecurityMode)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SecurityMode value)
        {
            switch( value )
            {
                case SecurityMode.Best:
                    return "Best";
                case SecurityMode.Sign:
                    return "Sign";
                case SecurityMode.SignAndEncrypt:
                    return "SignAndEncrypt";
                case SecurityMode.None:
                    return "None";
            }
            return null;
        }

        internal static SecurityMode? ParseSecurityMode(this string value)
        {
            switch( value )
            {
                case "Best":
                    return SecurityMode.Best;
                case "Sign":
                    return SecurityMode.Sign;
                case "SignAndEncrypt":
                    return SecurityMode.SignAndEncrypt;
                case "None":
                    return SecurityMode.None;
            }
            return null;
        }
    }
}