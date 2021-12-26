// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Gdiplus.QualityMode;

namespace TerraFX.Interop.Gdiplus;

/// <include file='InterpolationMode.xml' path='doc/member[@name="InterpolationMode"]/*' />
public enum InterpolationMode
{
    /// <include file='InterpolationMode.xml' path='doc/member[@name="InterpolationMode.InterpolationModeInvalid"]/*' />
    InterpolationModeInvalid = QualityModeInvalid,

    /// <include file='InterpolationMode.xml' path='doc/member[@name="InterpolationMode.InterpolationModeDefault"]/*' />
    InterpolationModeDefault = QualityModeDefault,

    /// <include file='InterpolationMode.xml' path='doc/member[@name="InterpolationMode.InterpolationModeLowQuality"]/*' />
    InterpolationModeLowQuality = QualityModeLow,

    /// <include file='InterpolationMode.xml' path='doc/member[@name="InterpolationMode.InterpolationModeHighQuality"]/*' />
    InterpolationModeHighQuality = QualityModeHigh,

    /// <include file='InterpolationMode.xml' path='doc/member[@name="InterpolationMode.InterpolationModeBilinear"]/*' />
    InterpolationModeBilinear,

    /// <include file='InterpolationMode.xml' path='doc/member[@name="InterpolationMode.InterpolationModeBicubic"]/*' />
    InterpolationModeBicubic,

    /// <include file='InterpolationMode.xml' path='doc/member[@name="InterpolationMode.InterpolationModeNearestNeighbor"]/*' />
    InterpolationModeNearestNeighbor,

    /// <include file='InterpolationMode.xml' path='doc/member[@name="InterpolationMode.InterpolationModeHighQualityBilinear"]/*' />
    InterpolationModeHighQualityBilinear,

    /// <include file='InterpolationMode.xml' path='doc/member[@name="InterpolationMode.InterpolationModeHighQualityBicubic"]/*' />
    InterpolationModeHighQualityBicubic,
}
