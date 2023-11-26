// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.611.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS"]/*' />
[Flags]
public enum D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS.D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAG_NOT_SUPPORTED"]/*' />
    D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAG_NOT_SUPPORTED = 0,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS.D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAG_32x32"]/*' />
    D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAG_32x32 = 0x1,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS.D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAG_64x64"]/*' />
    D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAG_64x64 = 0x2,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS.D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAG_128x128"]/*' />
    D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAG_128x128 = 0x4,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS.D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAG_256x256"]/*' />
    D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAG_256x256 = 0x8,
}
