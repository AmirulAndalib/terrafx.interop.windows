// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxdiag.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_DxDiagProvider = new Guid(0xA65B8071, 0x3BFE, 0x4213, 0x9A, 0x5B, 0x49, 0x1D, 0xA4, 0x46, 0x1C, 0xA7);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDxDiagProvider = new Guid(0x9C6B4CB0, 0x23F8, 0x49CC, 0xA3, 0xED, 0x45, 0xA5, 0x50, 0x00, 0xA6, 0xD2);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDxDiagContainer = new Guid(0x7D0F462F, 0x4064, 0x4862, 0xBC, 0x7F, 0x93, 0x3E, 0x50, 0x58, 0xC1, 0x0F);

        [NativeTypeName("#define DXDIAG_DX9_SDK_VERSION 111")]
        public const int DXDIAG_DX9_SDK_VERSION = 111;

        [NativeTypeName("#define DXDIAG_E_INSUFFICIENT_BUFFER ((HRESULT)0x8007007AL)")]
        public const int DXDIAG_E_INSUFFICIENT_BUFFER = unchecked((int)(0x8007007A));
    }
}
