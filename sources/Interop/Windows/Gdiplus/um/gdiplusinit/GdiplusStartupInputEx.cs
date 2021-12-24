// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusinit.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.Gdiplus;

/// <include file='GdiplusStartupInputEx.xml' path='doc/member[@name="GdiplusStartupInputEx"]/*' />
[NativeTypeName("struct GdiplusStartupInputEx : GdiplusStartupInput")]
[NativeInheritance("GdiplusStartupInput")]
public partial struct GdiplusStartupInputEx
{
    public GdiplusStartupInput Base;

    /// <include file='GdiplusStartupInputEx.xml' path='doc/member[@name="GdiplusStartupInputEx.StartupParameters"]/*' />
    public int StartupParameters;

    public unsafe GdiplusStartupInputEx([Optional] int startupParameters, [NativeTypeName("Gdiplus::DebugEventProc")] [Optional] delegate* unmanaged<DebugEventLevel, sbyte*, void> debugEventCallback, [Optional] BOOL suppressBackgroundThread, [Optional] BOOL suppressExternalCodecs)
    {
        Base.GdiplusVersion = 2;
        Base.DebugEventCallback = debugEventCallback;
        Base.SuppressBackgroundThread = suppressBackgroundThread;
        Base.SuppressExternalCodecs = suppressExternalCodecs;
        StartupParameters = startupParameters;
    }
}
