// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_TIMESPAN.xml' path='doc/member[@name="WS_TIMESPAN"]/*' />
public partial struct WS_TIMESPAN
{
    /// <include file='WS_TIMESPAN.xml' path='doc/member[@name="WS_TIMESPAN.ticks"]/*' />
    [NativeTypeName("long long")]
    public long ticks;
}
