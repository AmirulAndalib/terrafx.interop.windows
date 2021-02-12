// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum DECIMATION_USAGE
    {
        DECIMATION_LEGACY = 0,
        DECIMATION_USE_DECODER_ONLY = (DECIMATION_LEGACY + 1),
        DECIMATION_USE_VIDEOPORT_ONLY = (DECIMATION_USE_DECODER_ONLY + 1),
        DECIMATION_USE_OVERLAY_ONLY = (DECIMATION_USE_VIDEOPORT_ONLY + 1),
        DECIMATION_DEFAULT = (DECIMATION_USE_OVERLAY_ONLY + 1),
    }
}
