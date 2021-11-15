// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct CERT_CREATE_CONTEXT_PARA
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("PFN_CRYPT_FREE")]
        public delegate* unmanaged<void*, void> pfnFree;

        public void* pvFree;

        [NativeTypeName("PFN_CERT_CREATE_CONTEXT_SORT_FUNC")]
        public delegate* unmanaged<uint, uint, uint, void*, BOOL> pfnSort;

        public void* pvSort;
    }
}