// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CAT_NAMEVALUE.xml' path='doc/member[@name="CAT_NAMEVALUE"]/*' />
public unsafe partial struct CAT_NAMEVALUE
{
    /// <include file='CAT_NAMEVALUE.xml' path='doc/member[@name="CAT_NAMEVALUE.pwszTag"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pwszTag;

    /// <include file='CAT_NAMEVALUE.xml' path='doc/member[@name="CAT_NAMEVALUE.fdwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint fdwFlags;

    /// <include file='CAT_NAMEVALUE.xml' path='doc/member[@name="CAT_NAMEVALUE.Value"]/*' />
    public CRYPT_DATA_BLOB Value;
}
