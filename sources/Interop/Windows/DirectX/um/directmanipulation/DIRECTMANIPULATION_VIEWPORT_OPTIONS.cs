// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='DIRECTMANIPULATION_VIEWPORT_OPTIONS.xml' path='doc/member[@name="DIRECTMANIPULATION_VIEWPORT_OPTIONS"]/*' />
[Flags]
[SupportedOSPlatform("windows6.2")]
public enum DIRECTMANIPULATION_VIEWPORT_OPTIONS
{
    /// <include file='DIRECTMANIPULATION_VIEWPORT_OPTIONS.xml' path='doc/member[@name="DIRECTMANIPULATION_VIEWPORT_OPTIONS.DIRECTMANIPULATION_VIEWPORT_OPTIONS_DEFAULT"]/*' />
    DIRECTMANIPULATION_VIEWPORT_OPTIONS_DEFAULT = 0,

    /// <include file='DIRECTMANIPULATION_VIEWPORT_OPTIONS.xml' path='doc/member[@name="DIRECTMANIPULATION_VIEWPORT_OPTIONS.DIRECTMANIPULATION_VIEWPORT_OPTIONS_AUTODISABLE"]/*' />
    DIRECTMANIPULATION_VIEWPORT_OPTIONS_AUTODISABLE = 0x1,

    /// <include file='DIRECTMANIPULATION_VIEWPORT_OPTIONS.xml' path='doc/member[@name="DIRECTMANIPULATION_VIEWPORT_OPTIONS.DIRECTMANIPULATION_VIEWPORT_OPTIONS_MANUALUPDATE"]/*' />
    DIRECTMANIPULATION_VIEWPORT_OPTIONS_MANUALUPDATE = 0x2,

    /// <include file='DIRECTMANIPULATION_VIEWPORT_OPTIONS.xml' path='doc/member[@name="DIRECTMANIPULATION_VIEWPORT_OPTIONS.DIRECTMANIPULATION_VIEWPORT_OPTIONS_INPUT"]/*' />
    DIRECTMANIPULATION_VIEWPORT_OPTIONS_INPUT = 0x4,

    /// <include file='DIRECTMANIPULATION_VIEWPORT_OPTIONS.xml' path='doc/member[@name="DIRECTMANIPULATION_VIEWPORT_OPTIONS.DIRECTMANIPULATION_VIEWPORT_OPTIONS_EXPLICITHITTEST"]/*' />
    DIRECTMANIPULATION_VIEWPORT_OPTIONS_EXPLICITHITTEST = 0x8,

    /// <include file='DIRECTMANIPULATION_VIEWPORT_OPTIONS.xml' path='doc/member[@name="DIRECTMANIPULATION_VIEWPORT_OPTIONS.DIRECTMANIPULATION_VIEWPORT_OPTIONS_DISABLEPIXELSNAPPING"]/*' />
    DIRECTMANIPULATION_VIEWPORT_OPTIONS_DISABLEPIXELSNAPPING = 0x10,
}
