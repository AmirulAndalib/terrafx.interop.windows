// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SPINITF.xml' path='doc/member[@name="SPINITF"]/*' />
public enum SPINITF
{
    /// <include file='SPINITF.xml' path='doc/member[@name="SPINITF.SPINITF_NORMAL"]/*' />
    SPINITF_NORMAL = 0,

    /// <include file='SPINITF.xml' path='doc/member[@name="SPINITF.SPINITF_MODAL"]/*' />
    SPINITF_MODAL = 0x1,

    /// <include file='SPINITF.xml' path='doc/member[@name="SPINITF.SPINITF_NOMINIMIZE"]/*' />
    SPINITF_NOMINIMIZE = 0x8,
}
