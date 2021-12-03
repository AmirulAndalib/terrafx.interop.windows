// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxgidebug.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DXGIGetDebugInterface"]/*' />
    [DllImport("dxgidebug", ExactSpelling = true)]
    [SupportedOSPlatform("windows8.0")]
    public static extern HRESULT DXGIGetDebugInterface([NativeTypeName("const IID &")] Guid* riid, void** ppDebug);
}
