// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct WS_ISSUED_TOKEN_MESSAGE_SECURITY_BINDING_CONSTRAINT
    {
        public WS_SECURITY_BINDING_CONSTRAINT bindingConstraint;

        public WS_MESSAGE_SECURITY_USAGE bindingUsage;

        [NativeTypeName("WS_XML_STRING *")]
        public WS_XML_STRING* claimConstraints;

        [NativeTypeName("ULONG")]
        public uint claimConstraintCount;

        [NativeTypeName("WS_REQUEST_SECURITY_TOKEN_PROPERTY_CONSTRAINT *")]
        public WS_REQUEST_SECURITY_TOKEN_PROPERTY_CONSTRAINT* requestSecurityTokenPropertyConstraints;

        [NativeTypeName("ULONG")]
        public uint requestSecurityTokenPropertyConstraintCount;

        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/WebServices.h:6262:5)")]
        public _out_e__Struct @out;

        public unsafe partial struct _out_e__Struct
        {
            [NativeTypeName("WS_ENDPOINT_ADDRESS *")]
            public WS_ENDPOINT_ADDRESS* issuerAddress;

            [NativeTypeName("WS_XML_BUFFER *")]
            public IntPtr requestSecurityTokenTemplate;
        }
    }
}
