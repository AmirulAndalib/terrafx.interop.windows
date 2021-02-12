// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3D12_VIDEO_FRAME_STEREO_FORMAT
    {
        D3D12_VIDEO_FRAME_STEREO_FORMAT_NONE = 0,
        D3D12_VIDEO_FRAME_STEREO_FORMAT_MONO = 1,
        D3D12_VIDEO_FRAME_STEREO_FORMAT_HORIZONTAL = 2,
        D3D12_VIDEO_FRAME_STEREO_FORMAT_VERTICAL = 3,
        D3D12_VIDEO_FRAME_STEREO_FORMAT_SEPARATE = 4,
    }
}
