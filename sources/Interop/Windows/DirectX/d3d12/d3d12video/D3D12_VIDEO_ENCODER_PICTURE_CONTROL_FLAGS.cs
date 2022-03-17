// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAGS"]/*' />
public enum D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAGS
{
    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAGS.D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAG_NONE"]/*' />
    D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAG_NONE = 0,

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAGS.D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAG_USED_AS_REFERENCE_PICTURE"]/*' />
    D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAG_USED_AS_REFERENCE_PICTURE = 0x1,
}
