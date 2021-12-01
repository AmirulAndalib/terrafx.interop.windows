// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CREDENTIAL_ATTRIBUTEA.xml' path='doc/member[@name="CREDENTIAL_ATTRIBUTEA"]/*' />
public unsafe partial struct CREDENTIAL_ATTRIBUTEA
{
    /// <include file='CREDENTIAL_ATTRIBUTEA.xml' path='doc/member[@name="CREDENTIAL_ATTRIBUTEA.Keyword"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* Keyword;

    /// <include file='CREDENTIAL_ATTRIBUTEA.xml' path='doc/member[@name="CREDENTIAL_ATTRIBUTEA.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='CREDENTIAL_ATTRIBUTEA.xml' path='doc/member[@name="CREDENTIAL_ATTRIBUTEA.ValueSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint ValueSize;

    /// <include file='CREDENTIAL_ATTRIBUTEA.xml' path='doc/member[@name="CREDENTIAL_ATTRIBUTEA.Value"]/*' />
    [NativeTypeName("LPBYTE")]
    public byte* Value;
}
