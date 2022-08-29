// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='RefreshConstants.xml' path='doc/member[@name="RefreshConstants"]/*' />
public enum RefreshConstants
{
    /// <include file='RefreshConstants.xml' path='doc/member[@name="RefreshConstants.REFRESH_NORMAL"]/*' />
    REFRESH_NORMAL = 0,

    /// <include file='RefreshConstants.xml' path='doc/member[@name="RefreshConstants.REFRESH_IFEXPIRED"]/*' />
    REFRESH_IFEXPIRED = 1,

    /// <include file='RefreshConstants.xml' path='doc/member[@name="RefreshConstants.REFRESH_COMPLETELY"]/*' />
    REFRESH_COMPLETELY = 3,
}
