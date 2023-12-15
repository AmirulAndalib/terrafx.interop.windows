// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='OSVERSIONINFOA.xml' path='doc/member[@name="OSVERSIONINFOA"]/*' />
public partial struct OSVERSIONINFOA
{
    /// <include file='OSVERSIONINFOA.xml' path='doc/member[@name="OSVERSIONINFOA.dwOSVersionInfoSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwOSVersionInfoSize;

    /// <include file='OSVERSIONINFOA.xml' path='doc/member[@name="OSVERSIONINFOA.dwMajorVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMajorVersion;

    /// <include file='OSVERSIONINFOA.xml' path='doc/member[@name="OSVERSIONINFOA.dwMinorVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMinorVersion;

    /// <include file='OSVERSIONINFOA.xml' path='doc/member[@name="OSVERSIONINFOA.dwBuildNumber"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwBuildNumber;

    /// <include file='OSVERSIONINFOA.xml' path='doc/member[@name="OSVERSIONINFOA.dwPlatformId"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwPlatformId;

    /// <include file='OSVERSIONINFOA.xml' path='doc/member[@name="OSVERSIONINFOA.szCSDVersion"]/*' />
    [NativeTypeName("CHAR[128]")]
    public _szCSDVersion_e__FixedBuffer szCSDVersion;

    /// <include file='_szCSDVersion_e__FixedBuffer.xml' path='doc/member[@name="_szCSDVersion_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    public partial struct _szCSDVersion_e__FixedBuffer
    {
        public sbyte e0;
    }
}
