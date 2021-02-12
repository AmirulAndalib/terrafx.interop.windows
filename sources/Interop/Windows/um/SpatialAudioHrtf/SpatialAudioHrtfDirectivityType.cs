// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioHrtf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum SpatialAudioHrtfDirectivityType
    {
        SpatialAudioHrtfDirectivity_OmniDirectional = 0,
        SpatialAudioHrtfDirectivity_Cardioid = (SpatialAudioHrtfDirectivity_OmniDirectional + 1),
        SpatialAudioHrtfDirectivity_Cone = (SpatialAudioHrtfDirectivity_Cardioid + 1),
    }
}
