// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_DATETIME_DESCRIPTION.xml' path='doc/member[@name="WS_DATETIME_DESCRIPTION"]/*' />
public partial struct WS_DATETIME_DESCRIPTION
{
    /// <include file='WS_DATETIME_DESCRIPTION.xml' path='doc/member[@name="WS_DATETIME_DESCRIPTION.minValue"]/*' />
    public WS_DATETIME minValue;

    /// <include file='WS_DATETIME_DESCRIPTION.xml' path='doc/member[@name="WS_DATETIME_DESCRIPTION.maxValue"]/*' />
    public WS_DATETIME maxValue;
}
