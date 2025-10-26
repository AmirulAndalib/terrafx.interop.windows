// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2"]/*' />
public unsafe partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.NodeIndex"]/*' />
    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.Codec"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC Codec;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.InputFormat"]/*' />
    public DXGI_FORMAT InputFormat;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.CodecConfiguration"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION CodecConfiguration;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.CodecGopSequence"]/*' />
    public D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE CodecGopSequence;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.RateControl"]/*' />
    public D3D12_VIDEO_ENCODER_RATE_CONTROL RateControl;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.IntraRefresh"]/*' />
    public D3D12_VIDEO_ENCODER_INTRA_REFRESH_MODE IntraRefresh;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.SubregionFrameEncoding"]/*' />
    public D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE SubregionFrameEncoding;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.ResolutionsListCount"]/*' />
    public uint ResolutionsListCount;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.pResolutionList"]/*' />
    [NativeTypeName("const D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC *")]
    public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC* pResolutionList;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.MaxReferenceFramesInDPB"]/*' />
    public uint MaxReferenceFramesInDPB;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.ValidationFlags"]/*' />
    public D3D12_VIDEO_ENCODER_VALIDATION_FLAGS ValidationFlags;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.SupportFlags"]/*' />
    public D3D12_VIDEO_ENCODER_SUPPORT_FLAGS SupportFlags;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.SuggestedProfile"]/*' />
    public D3D12_VIDEO_ENCODER_PROFILE_DESC SuggestedProfile;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.SuggestedLevel"]/*' />
    public D3D12_VIDEO_ENCODER_LEVEL_SETTING SuggestedLevel;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.pResolutionDependentSupport"]/*' />
    public D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_LIMITS1* pResolutionDependentSupport;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.SubregionFrameEncodingData"]/*' />
    public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA SubregionFrameEncodingData;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.MaxQualityVsSpeed"]/*' />
    public uint MaxQualityVsSpeed;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.QPMap"]/*' />
    public D3D12_VIDEO_ENCODER_QPMAP_CONFIGURATION QPMap;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.DirtyRegions"]/*' />
    public D3D12_VIDEO_ENCODER_DIRTY_REGIONS_CONFIGURATION DirtyRegions;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.MotionSearch"]/*' />
    public D3D12_VIDEO_ENCODER_MOTION_SEARCH_CONFIGURATION MotionSearch;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT2.FrameAnalysis"]/*' />
    public D3D12_VIDEO_ENCODER_FRAME_ANALYSIS_CONFIGURATION FrameAnalysis;
}
