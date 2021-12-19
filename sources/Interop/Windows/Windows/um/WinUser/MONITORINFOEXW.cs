// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MONITORINFOEXW.xml' path='doc/member[@name="MONITORINFOEXW"]/*' />
[NativeTypeName("struct tagMONITORINFOEXW : tagMONITORINFO")]
[NativeInheritance("tagMONITORINFO")]
public unsafe partial struct MONITORINFOEXW
{
    public MONITORINFO __AnonymousBase_WinUser_L13571_C43;

    /// <include file='MONITORINFOEXW.xml' path='doc/member[@name="MONITORINFOEXW.szDevice"]/*' />
    [NativeTypeName("WCHAR [32]")]
    public fixed ushort szDevice[32];
}
