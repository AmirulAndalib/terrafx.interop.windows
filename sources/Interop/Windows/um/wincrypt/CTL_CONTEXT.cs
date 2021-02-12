// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CTL_CONTEXT
    {
        [NativeTypeName("DWORD")]
        public uint dwMsgAndCertEncodingType;

        [NativeTypeName("BYTE *")]
        public byte* pbCtlEncoded;

        [NativeTypeName("DWORD")]
        public uint cbCtlEncoded;

        [NativeTypeName("PCTL_INFO")]
        public CTL_INFO* pCtlInfo;

        [NativeTypeName("HCERTSTORE")]
        public void* hCertStore;

        [NativeTypeName("HCRYPTMSG")]
        public void* hCryptMsg;

        [NativeTypeName("BYTE *")]
        public byte* pbCtlContent;

        [NativeTypeName("DWORD")]
        public uint cbCtlContent;
    }
}
