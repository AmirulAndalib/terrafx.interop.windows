// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3D12_VIDEO_PROCESS_ORIENTATION
    {
        D3D12_VIDEO_PROCESS_ORIENTATION_DEFAULT = 0,
        D3D12_VIDEO_PROCESS_ORIENTATION_FLIP_HORIZONTAL = 1,
        D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_90 = 2,
        D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_90_FLIP_HORIZONTAL = 3,
        D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_180 = 4,
        D3D12_VIDEO_PROCESS_ORIENTATION_FLIP_VERTICAL = 5,
        D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_270 = 6,
        D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_270_FLIP_HORIZONTAL = 7,
    }
}
