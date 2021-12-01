// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/devpropdef.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='DEVPROPSTORE.xml' path='doc/member[@name="DEVPROPSTORE"]/*' />
public enum DEVPROPSTORE
{
    /// <include file='DEVPROPSTORE.xml' path='doc/member[@name="DEVPROPSTORE.DEVPROP_STORE_SYSTEM"]/*' />
    DEVPROP_STORE_SYSTEM,

    /// <include file='DEVPROPSTORE.xml' path='doc/member[@name="DEVPROPSTORE.DEVPROP_STORE_USER"]/*' />
    DEVPROP_STORE_USER,
}
