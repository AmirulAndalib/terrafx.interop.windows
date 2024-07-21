// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SPPROPERTYINFO.xml' path='doc/member[@name="SPPROPERTYINFO"]/*' />
public unsafe partial struct SPPROPERTYINFO
{
    /// <include file='SPPROPERTYINFO.xml' path='doc/member[@name="SPPROPERTYINFO.pszName"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* pszName;

    /// <include file='SPPROPERTYINFO.xml' path='doc/member[@name="SPPROPERTYINFO.ulId"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulId;

    /// <include file='SPPROPERTYINFO.xml' path='doc/member[@name="SPPROPERTYINFO.pszValue"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* pszValue;

    /// <include file='SPPROPERTYINFO.xml' path='doc/member[@name="SPPROPERTYINFO.vValue"]/*' />
    public VARIANT vValue;
}
