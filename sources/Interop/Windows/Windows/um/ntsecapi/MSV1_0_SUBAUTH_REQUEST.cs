// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MSV1_0_SUBAUTH_REQUEST.xml' path='doc/member[@name="MSV1_0_SUBAUTH_REQUEST"]/*' />
public unsafe partial struct MSV1_0_SUBAUTH_REQUEST
{
    /// <include file='MSV1_0_SUBAUTH_REQUEST.xml' path='doc/member[@name="MSV1_0_SUBAUTH_REQUEST.MessageType"]/*' />
    public MSV1_0_PROTOCOL_MESSAGE_TYPE MessageType;

    /// <include file='MSV1_0_SUBAUTH_REQUEST.xml' path='doc/member[@name="MSV1_0_SUBAUTH_REQUEST.SubAuthPackageId"]/*' />
    [NativeTypeName("ULONG")]
    public uint SubAuthPackageId;

    /// <include file='MSV1_0_SUBAUTH_REQUEST.xml' path='doc/member[@name="MSV1_0_SUBAUTH_REQUEST.SubAuthInfoLength"]/*' />
    [NativeTypeName("ULONG")]
    public uint SubAuthInfoLength;

    /// <include file='MSV1_0_SUBAUTH_REQUEST.xml' path='doc/member[@name="MSV1_0_SUBAUTH_REQUEST.SubAuthSubmitBuffer"]/*' />
    [NativeTypeName("PUCHAR")]
    public byte* SubAuthSubmitBuffer;
}
