// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mssip.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MS_ADDINFO_DETACHEDSIG.xml' path='doc/member[@name="MS_ADDINFO_DETACHEDSIG"]/*' />
public unsafe partial struct MS_ADDINFO_DETACHEDSIG
{
    /// <include file='MS_ADDINFO_DETACHEDSIG.xml' path='doc/member[@name="MS_ADDINFO_DETACHEDSIG.cbStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    /// <include file='MS_ADDINFO_DETACHEDSIG.xml' path='doc/member[@name="MS_ADDINFO_DETACHEDSIG.hSignatureFile"]/*' />
    public HANDLE hSignatureFile;

    /// <include file='MS_ADDINFO_DETACHEDSIG.xml' path='doc/member[@name="MS_ADDINFO_DETACHEDSIG.cbSignatureObject"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSignatureObject;

    /// <include file='MS_ADDINFO_DETACHEDSIG.xml' path='doc/member[@name="MS_ADDINFO_DETACHEDSIG.pbSignatureObject"]/*' />
    public byte* pbSignatureObject;
}
