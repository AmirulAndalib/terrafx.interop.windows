// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='DVEXTENTMODE.xml' path='doc/member[@name="DVEXTENTMODE"]/*' />
public enum DVEXTENTMODE
{
    /// <include file='DVEXTENTMODE.xml' path='doc/member[@name="DVEXTENTMODE.DVEXTENT_CONTENT"]/*' />
    DVEXTENT_CONTENT = 0,

    /// <include file='DVEXTENTMODE.xml' path='doc/member[@name="DVEXTENTMODE.DVEXTENT_INTEGRAL"]/*' />
    DVEXTENT_INTEGRAL = (DVEXTENT_CONTENT + 1),
}
