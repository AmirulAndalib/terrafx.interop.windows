// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/icm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='COLORMATCHSETUPW.xml' path='doc/member[@name="COLORMATCHSETUPW"]/*' />
public unsafe partial struct COLORMATCHSETUPW
{
    /// <include file='COLORMATCHSETUPW.xml' path='doc/member[@name="COLORMATCHSETUPW.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='COLORMATCHSETUPW.xml' path='doc/member[@name="COLORMATCHSETUPW.dwVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVersion;

    /// <include file='COLORMATCHSETUPW.xml' path='doc/member[@name="COLORMATCHSETUPW.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='COLORMATCHSETUPW.xml' path='doc/member[@name="COLORMATCHSETUPW.hwndOwner"]/*' />
    public HWND hwndOwner;

    /// <include file='COLORMATCHSETUPW.xml' path='doc/member[@name="COLORMATCHSETUPW.pSourceName"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* pSourceName;

    /// <include file='COLORMATCHSETUPW.xml' path='doc/member[@name="COLORMATCHSETUPW.pDisplayName"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* pDisplayName;

    /// <include file='COLORMATCHSETUPW.xml' path='doc/member[@name="COLORMATCHSETUPW.pPrinterName"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* pPrinterName;

    /// <include file='COLORMATCHSETUPW.xml' path='doc/member[@name="COLORMATCHSETUPW.dwRenderIntent"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRenderIntent;

    /// <include file='COLORMATCHSETUPW.xml' path='doc/member[@name="COLORMATCHSETUPW.dwProofingIntent"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwProofingIntent;

    /// <include file='COLORMATCHSETUPW.xml' path='doc/member[@name="COLORMATCHSETUPW.pMonitorProfile"]/*' />
    [NativeTypeName("PWSTR")]
    public char* pMonitorProfile;

    /// <include file='COLORMATCHSETUPW.xml' path='doc/member[@name="COLORMATCHSETUPW.ccMonitorProfile"]/*' />
    [NativeTypeName("DWORD")]
    public uint ccMonitorProfile;

    /// <include file='COLORMATCHSETUPW.xml' path='doc/member[@name="COLORMATCHSETUPW.pPrinterProfile"]/*' />
    [NativeTypeName("PWSTR")]
    public char* pPrinterProfile;

    /// <include file='COLORMATCHSETUPW.xml' path='doc/member[@name="COLORMATCHSETUPW.ccPrinterProfile"]/*' />
    [NativeTypeName("DWORD")]
    public uint ccPrinterProfile;

    /// <include file='COLORMATCHSETUPW.xml' path='doc/member[@name="COLORMATCHSETUPW.pTargetProfile"]/*' />
    [NativeTypeName("PWSTR")]
    public char* pTargetProfile;

    /// <include file='COLORMATCHSETUPW.xml' path='doc/member[@name="COLORMATCHSETUPW.ccTargetProfile"]/*' />
    [NativeTypeName("DWORD")]
    public uint ccTargetProfile;

    /// <include file='COLORMATCHSETUPW.xml' path='doc/member[@name="COLORMATCHSETUPW.lpfnHook"]/*' />
    [NativeTypeName("DLGPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpfnHook;

    /// <include file='COLORMATCHSETUPW.xml' path='doc/member[@name="COLORMATCHSETUPW.lParam"]/*' />
    public LPARAM lParam;

    /// <include file='COLORMATCHSETUPW.xml' path='doc/member[@name="COLORMATCHSETUPW.lpfnApplyCallback"]/*' />
    [NativeTypeName("PCMSCALLBACKW")]
    public delegate* unmanaged<COLORMATCHSETUPW*, LPARAM, BOOL> lpfnApplyCallback;

    /// <include file='COLORMATCHSETUPW.xml' path='doc/member[@name="COLORMATCHSETUPW.lParamApplyCallback"]/*' />
    public LPARAM lParamApplyCallback;
}
