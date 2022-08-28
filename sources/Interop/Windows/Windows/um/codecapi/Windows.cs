// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows.eAVEncH264VProfile;

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    [NativeTypeName("#define STATIC_CODECAPI_AVEncProgressiveUpdateTime 0x649faf66")]
    public const int STATIC_CODECAPI_AVEncProgressiveUpdateTime = 0x649faf66;

    [NativeTypeName("#define STATIC_CODECAPI_AVEncChromaUpdateTime 0x4b4fd998")]
    public const int STATIC_CODECAPI_AVEncChromaUpdateTime = 0x4b4fd998;

    [NativeTypeName("#define eAVEncH264VProfile_ConstrainedHigh eAVEncH264VProfile_UCConstrainedHigh")]
    public const eAVEncH264VProfile eAVEncH264VProfile_ConstrainedHigh = eAVEncH264VProfile_UCConstrainedHigh;

    [NativeTypeName("#define AVENC_H263V_LEVELCOUNT 8")]
    public const int AVENC_H263V_LEVELCOUNT = 8;

    [NativeTypeName("#define AVENC_H264V_LEVELCOUNT 16")]
    public const int AVENC_H264V_LEVELCOUNT = 16;

    [NativeTypeName("#define AVENC_H264V_MAX_MBBITS 3200")]
    public const int AVENC_H264V_MAX_MBBITS = 3200;
}
