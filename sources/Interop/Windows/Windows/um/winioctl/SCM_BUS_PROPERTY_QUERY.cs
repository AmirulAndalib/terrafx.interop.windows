// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SCM_BUS_PROPERTY_QUERY.xml' path='doc/member[@name="SCM_BUS_PROPERTY_QUERY"]/*' />
public unsafe partial struct SCM_BUS_PROPERTY_QUERY
{
    /// <include file='SCM_BUS_PROPERTY_QUERY.xml' path='doc/member[@name="SCM_BUS_PROPERTY_QUERY.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='SCM_BUS_PROPERTY_QUERY.xml' path='doc/member[@name="SCM_BUS_PROPERTY_QUERY.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='SCM_BUS_PROPERTY_QUERY.xml' path='doc/member[@name="SCM_BUS_PROPERTY_QUERY.PropertyId"]/*' />
    public SCM_BUS_PROPERTY_ID PropertyId;

    /// <include file='SCM_BUS_PROPERTY_QUERY.xml' path='doc/member[@name="SCM_BUS_PROPERTY_QUERY.QueryType"]/*' />
    public SCM_BUS_QUERY_TYPE QueryType;

    /// <include file='SCM_BUS_PROPERTY_QUERY.xml' path='doc/member[@name="SCM_BUS_PROPERTY_QUERY.AdditionalParameters"]/*' />
    [NativeTypeName("BYTE [1]")]
    public fixed byte AdditionalParameters[1];
}
