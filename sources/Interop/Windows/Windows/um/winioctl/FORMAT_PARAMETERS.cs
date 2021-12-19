// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='FORMAT_PARAMETERS.xml' path='doc/member[@name="FORMAT_PARAMETERS"]/*' />
public partial struct FORMAT_PARAMETERS
{
    /// <include file='FORMAT_PARAMETERS.xml' path='doc/member[@name="FORMAT_PARAMETERS.MediaType"]/*' />
    public MEDIA_TYPE MediaType;

    /// <include file='FORMAT_PARAMETERS.xml' path='doc/member[@name="FORMAT_PARAMETERS.StartCylinderNumber"]/*' />
    [NativeTypeName("DWORD")]
    public uint StartCylinderNumber;

    /// <include file='FORMAT_PARAMETERS.xml' path='doc/member[@name="FORMAT_PARAMETERS.EndCylinderNumber"]/*' />
    [NativeTypeName("DWORD")]
    public uint EndCylinderNumber;

    /// <include file='FORMAT_PARAMETERS.xml' path='doc/member[@name="FORMAT_PARAMETERS.StartHeadNumber"]/*' />
    [NativeTypeName("DWORD")]
    public uint StartHeadNumber;

    /// <include file='FORMAT_PARAMETERS.xml' path='doc/member[@name="FORMAT_PARAMETERS.EndHeadNumber"]/*' />
    [NativeTypeName("DWORD")]
    public uint EndHeadNumber;
}
