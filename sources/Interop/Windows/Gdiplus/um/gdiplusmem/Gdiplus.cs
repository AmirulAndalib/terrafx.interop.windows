// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusmem.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Gdiplus;

public static unsafe partial class Gdiplus
{
    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.GdipAlloc"]/*' />
    [DllImport("gdiplus", ExactSpelling = true)]
    public static extern void* GdipAlloc([NativeTypeName("size_t")] nuint size);

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.GdipFree"]/*' />
    [DllImport("gdiplus", ExactSpelling = true)]
    public static extern void GdipFree(void* ptr);
}
