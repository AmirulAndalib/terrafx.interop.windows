// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapofx.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.CreateFX"]/*' />
    [DllImport("xaudio2_9", ExactSpelling = true)]
    public static extern HRESULT CreateFX([NativeTypeName("const IID &")] Guid* clsid, IUnknown** pEffect, [NativeTypeName("const void *")] void* pInitDat = null, [NativeTypeName("UINT32")] uint InitDataByteSize = 0);
}
