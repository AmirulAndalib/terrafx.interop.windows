// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT"]/*' />
public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT.NodeIndex"]/*' />
    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT.Codec"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC Codec;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT.Profile"]/*' />
    public D3D12_VIDEO_ENCODER_PROFILE_DESC Profile;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT.IsSupported"]/*' />
    public BOOL IsSupported;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT.PictureSupport"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT PictureSupport;
}
