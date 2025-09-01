// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dxcore.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license


using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DXCoreCreateAdapterFactory"]/*' />
    [DllImport("dxcore", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19041.0")]
    public static extern HRESULT DXCoreCreateAdapterFactory([NativeTypeName("const IID &")] Guid* riid, void** ppvFactory);
}
