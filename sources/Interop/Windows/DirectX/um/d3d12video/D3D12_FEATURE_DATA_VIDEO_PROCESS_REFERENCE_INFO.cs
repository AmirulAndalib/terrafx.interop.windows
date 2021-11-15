// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    public partial struct D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO
    {
        public uint NodeIndex;

        public D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS DeinterlaceMode;

        public D3D12_VIDEO_PROCESS_FILTER_FLAGS Filters;

        public D3D12_VIDEO_PROCESS_FEATURE_FLAGS FeatureSupport;

        public DXGI_RATIONAL InputFrameRate;

        public DXGI_RATIONAL OutputFrameRate;

        public BOOL EnableAutoProcessing;

        public uint PastFrames;

        public uint FutureFrames;
    }
}