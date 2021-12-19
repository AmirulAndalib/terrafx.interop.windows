// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='CSV_QUERY_VOLUME_ID.xml' path='doc/member[@name="CSV_QUERY_VOLUME_ID"]/*' />
public partial struct CSV_QUERY_VOLUME_ID
{
    /// <include file='CSV_QUERY_VOLUME_ID.xml' path='doc/member[@name="CSV_QUERY_VOLUME_ID.VolumeId"]/*' />
    public Guid VolumeId;
}
