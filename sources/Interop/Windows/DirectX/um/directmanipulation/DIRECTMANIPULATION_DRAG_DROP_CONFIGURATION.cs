// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION.xml' path='doc/member[@name="DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION"]/*' />
[Flags]
[SupportedOSPlatform("windows6.3")]
public enum DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION
{
    /// <include file='DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION.xml' path='doc/member[@name="DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION.DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION_VERTICAL"]/*' />
    DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION_VERTICAL = 0x1,

    /// <include file='DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION.xml' path='doc/member[@name="DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION.DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION_HORIZONTAL"]/*' />
    DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION_HORIZONTAL = 0x2,

    /// <include file='DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION.xml' path='doc/member[@name="DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION.DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION_SELECT_ONLY"]/*' />
    DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION_SELECT_ONLY = 0x10,

    /// <include file='DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION.xml' path='doc/member[@name="DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION.DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION_SELECT_DRAG"]/*' />
    DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION_SELECT_DRAG = 0x20,

    /// <include file='DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION.xml' path='doc/member[@name="DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION.DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION_HOLD_DRAG"]/*' />
    DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION_HOLD_DRAG = 0x40,
}
