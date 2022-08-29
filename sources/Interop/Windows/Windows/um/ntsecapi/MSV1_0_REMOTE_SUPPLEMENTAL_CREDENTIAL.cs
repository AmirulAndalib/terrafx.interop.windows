// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MSV1_0_REMOTE_SUPPLEMENTAL_CREDENTIAL.xml' path='doc/member[@name="MSV1_0_REMOTE_SUPPLEMENTAL_CREDENTIAL"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct MSV1_0_REMOTE_SUPPLEMENTAL_CREDENTIAL
{
    /// <include file='MSV1_0_REMOTE_SUPPLEMENTAL_CREDENTIAL.xml' path='doc/member[@name="MSV1_0_REMOTE_SUPPLEMENTAL_CREDENTIAL.Version"]/*' />
    [NativeTypeName("ULONG")]
    public uint Version;

    /// <include file='MSV1_0_REMOTE_SUPPLEMENTAL_CREDENTIAL.xml' path='doc/member[@name="MSV1_0_REMOTE_SUPPLEMENTAL_CREDENTIAL.Flags"]/*' />
    [NativeTypeName("ULONG")]
    public uint Flags;

    /// <include file='MSV1_0_REMOTE_SUPPLEMENTAL_CREDENTIAL.xml' path='doc/member[@name="MSV1_0_REMOTE_SUPPLEMENTAL_CREDENTIAL.CredentialKey"]/*' />
    public MSV1_0_CREDENTIAL_KEY CredentialKey;

    /// <include file='MSV1_0_REMOTE_SUPPLEMENTAL_CREDENTIAL.xml' path='doc/member[@name="MSV1_0_REMOTE_SUPPLEMENTAL_CREDENTIAL.CredentialKeyType"]/*' />
    public MSV1_0_CREDENTIAL_KEY_TYPE CredentialKeyType;

    /// <include file='MSV1_0_REMOTE_SUPPLEMENTAL_CREDENTIAL.xml' path='doc/member[@name="MSV1_0_REMOTE_SUPPLEMENTAL_CREDENTIAL.EncryptedCredsSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint EncryptedCredsSize;

    /// <include file='MSV1_0_REMOTE_SUPPLEMENTAL_CREDENTIAL.xml' path='doc/member[@name="MSV1_0_REMOTE_SUPPLEMENTAL_CREDENTIAL.EncryptedCreds"]/*' />
    [NativeTypeName("UCHAR[1]")]
    public fixed byte EncryptedCreds[1];
}
