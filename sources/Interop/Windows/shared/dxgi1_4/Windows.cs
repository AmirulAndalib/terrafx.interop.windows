// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_4.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGISwapChain3 = new Guid(0x94d99bdb, 0xf1f8, 0x4ab0, 0xb2, 0x36, 0x7d, 0xa0, 0x17, 0x0e, 0xda, 0xb1);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGIOutput4 = new Guid(0xdc7dca35, 0x2196, 0x414d, 0x9F, 0x53, 0x61, 0x78, 0x84, 0x03, 0x2a, 0x60);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGIFactory4 = new Guid(0x1bc6ea02, 0xef36, 0x464f, 0xbf, 0x0c, 0x21, 0xca, 0x39, 0xe5, 0x16, 0x8a);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGIAdapter3 = new Guid(0x645967A4, 0x1392, 0x4310, 0xA7, 0x98, 0x80, 0x53, 0xCE, 0x3E, 0x93, 0xFD);
    }
}
