// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='DWRITE_PANOSE_CHARACTER_RANGES.xml' path='doc/member[@name="DWRITE_PANOSE_CHARACTER_RANGES"]/*' />
public enum DWRITE_PANOSE_CHARACTER_RANGES
{
    /// <include file='DWRITE_PANOSE_CHARACTER_RANGES.xml' path='doc/member[@name="DWRITE_PANOSE_CHARACTER_RANGES.DWRITE_PANOSE_CHARACTER_RANGES_ANY"]/*' />
    DWRITE_PANOSE_CHARACTER_RANGES_ANY = 0,

    /// <include file='DWRITE_PANOSE_CHARACTER_RANGES.xml' path='doc/member[@name="DWRITE_PANOSE_CHARACTER_RANGES.DWRITE_PANOSE_CHARACTER_RANGES_NO_FIT"]/*' />
    DWRITE_PANOSE_CHARACTER_RANGES_NO_FIT = 1,

    /// <include file='DWRITE_PANOSE_CHARACTER_RANGES.xml' path='doc/member[@name="DWRITE_PANOSE_CHARACTER_RANGES.DWRITE_PANOSE_CHARACTER_RANGES_EXTENDED_COLLECTION"]/*' />
    DWRITE_PANOSE_CHARACTER_RANGES_EXTENDED_COLLECTION = 2,

    /// <include file='DWRITE_PANOSE_CHARACTER_RANGES.xml' path='doc/member[@name="DWRITE_PANOSE_CHARACTER_RANGES.DWRITE_PANOSE_CHARACTER_RANGES_LITERALS"]/*' />
    DWRITE_PANOSE_CHARACTER_RANGES_LITERALS = 3,

    /// <include file='DWRITE_PANOSE_CHARACTER_RANGES.xml' path='doc/member[@name="DWRITE_PANOSE_CHARACTER_RANGES.DWRITE_PANOSE_CHARACTER_RANGES_NO_LOWER_CASE"]/*' />
    DWRITE_PANOSE_CHARACTER_RANGES_NO_LOWER_CASE = 4,

    /// <include file='DWRITE_PANOSE_CHARACTER_RANGES.xml' path='doc/member[@name="DWRITE_PANOSE_CHARACTER_RANGES.DWRITE_PANOSE_CHARACTER_RANGES_SMALL_CAPS"]/*' />
    DWRITE_PANOSE_CHARACTER_RANGES_SMALL_CAPS = 5,
}
