// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3D12_VIDEO_PROCESS_FILTER
    {
        D3D12_VIDEO_PROCESS_FILTER_BRIGHTNESS = 0,
        D3D12_VIDEO_PROCESS_FILTER_CONTRAST = 1,
        D3D12_VIDEO_PROCESS_FILTER_HUE = 2,
        D3D12_VIDEO_PROCESS_FILTER_SATURATION = 3,
        D3D12_VIDEO_PROCESS_FILTER_NOISE_REDUCTION = 4,
        D3D12_VIDEO_PROCESS_FILTER_EDGE_ENHANCEMENT = 5,
        D3D12_VIDEO_PROCESS_FILTER_ANAMORPHIC_SCALING = 6,
        D3D12_VIDEO_PROCESS_FILTER_STEREO_ADJUSTMENT = 7,
    }
}
