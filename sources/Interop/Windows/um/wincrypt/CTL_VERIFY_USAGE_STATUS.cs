// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CTL_VERIFY_USAGE_STATUS
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwError;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("PCCTL_CONTEXT *")]
        public CTL_CONTEXT** ppCtl;

        [NativeTypeName("DWORD")]
        public uint dwCtlEntryIndex;

        [NativeTypeName("PCCERT_CONTEXT *")]
        public CERT_CONTEXT** ppSigner;

        [NativeTypeName("DWORD")]
        public uint dwSignerIndex;
    }
}
