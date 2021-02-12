// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CERT_POLICY_QUALIFIER_NOTICE_REFERENCE
    {
        [NativeTypeName("LPSTR")]
        public sbyte* pszOrganization;

        [NativeTypeName("DWORD")]
        public uint cNoticeNumbers;

        [NativeTypeName("int *")]
        public int* rgNoticeNumbers;
    }
}
