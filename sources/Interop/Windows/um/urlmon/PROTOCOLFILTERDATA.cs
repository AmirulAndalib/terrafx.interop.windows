// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct PROTOCOLFILTERDATA
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("IInternetProtocolSink *")]
        public IInternetProtocolSink* pProtocolSink;

        [NativeTypeName("IInternetProtocol *")]
        public IInternetProtocol* pProtocol;

        [NativeTypeName("IUnknown *")]
        public IUnknown* pUnk;

        [NativeTypeName("DWORD")]
        public uint dwFilterFlags;
    }
}
