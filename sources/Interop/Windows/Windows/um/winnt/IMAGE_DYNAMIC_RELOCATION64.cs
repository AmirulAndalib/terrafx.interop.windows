// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='IMAGE_DYNAMIC_RELOCATION64.xml' path='doc/member[@name="IMAGE_DYNAMIC_RELOCATION64"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct IMAGE_DYNAMIC_RELOCATION64
{
    /// <include file='IMAGE_DYNAMIC_RELOCATION64.xml' path='doc/member[@name="IMAGE_DYNAMIC_RELOCATION64.Symbol"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong Symbol;

    /// <include file='IMAGE_DYNAMIC_RELOCATION64.xml' path='doc/member[@name="IMAGE_DYNAMIC_RELOCATION64.BaseRelocSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint BaseRelocSize;
}
