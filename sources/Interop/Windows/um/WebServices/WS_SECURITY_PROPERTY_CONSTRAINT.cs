// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct WS_SECURITY_PROPERTY_CONSTRAINT
    {
        public WS_SECURITY_PROPERTY_ID id;

        [NativeTypeName("void *")]
        public void* allowedValues;

        [NativeTypeName("ULONG")]
        public uint allowedValuesSize;

        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/WebServices.h:6281:5)")]
        public _out_e__Struct @out;

        public partial struct _out_e__Struct
        {
            public WS_SECURITY_PROPERTY securityProperty;
        }
    }
}
