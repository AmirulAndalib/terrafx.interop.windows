// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='FS_BPIO_INFO.xml' path='doc/member[@name="FS_BPIO_INFO"]/*' />
public unsafe partial struct FS_BPIO_INFO
{
    /// <include file='FS_BPIO_INFO.xml' path='doc/member[@name="FS_BPIO_INFO.ActiveBypassIoCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint ActiveBypassIoCount;

    /// <include file='FS_BPIO_INFO.xml' path='doc/member[@name="FS_BPIO_INFO.StorageDriverNameLen"]/*' />
    [NativeTypeName("WORD")]
    public ushort StorageDriverNameLen;

    /// <include file='FS_BPIO_INFO.xml' path='doc/member[@name="FS_BPIO_INFO.StorageDriverName"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public fixed ushort StorageDriverName[32];
}
