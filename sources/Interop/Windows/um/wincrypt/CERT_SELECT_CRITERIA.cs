// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CERT_SELECT_CRITERIA
    {
        [NativeTypeName("DWORD")]
        public uint dwType;

        [NativeTypeName("DWORD")]
        public uint cPara;

        [NativeTypeName("void **")]
        public void** ppPara;
    }
}
