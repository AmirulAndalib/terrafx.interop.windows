// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CMC_TAGGED_OTHER_MSG
    {
        [NativeTypeName("DWORD")]
        public uint dwBodyPartID;

        [NativeTypeName("LPSTR")]
        public sbyte* pszObjId;

        [NativeTypeName("CRYPT_OBJID_BLOB")]
        public CRYPTOAPI_BLOB Value;
    }
}
