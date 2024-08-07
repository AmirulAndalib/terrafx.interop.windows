// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_VIDEO_PROCESSOR_STEREO_FORMAT.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STEREO_FORMAT"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum D3D11_VIDEO_PROCESSOR_STEREO_FORMAT
{
    /// <include file='D3D11_VIDEO_PROCESSOR_STEREO_FORMAT.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STEREO_FORMAT.D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_MONO"]/*' />
    D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_MONO = 0,

    /// <include file='D3D11_VIDEO_PROCESSOR_STEREO_FORMAT.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STEREO_FORMAT.D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_HORIZONTAL"]/*' />
    D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_HORIZONTAL = 1,

    /// <include file='D3D11_VIDEO_PROCESSOR_STEREO_FORMAT.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STEREO_FORMAT.D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_VERTICAL"]/*' />
    D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_VERTICAL = 2,

    /// <include file='D3D11_VIDEO_PROCESSOR_STEREO_FORMAT.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STEREO_FORMAT.D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_SEPARATE"]/*' />
    D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_SEPARATE = 3,

    /// <include file='D3D11_VIDEO_PROCESSOR_STEREO_FORMAT.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STEREO_FORMAT.D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_MONO_OFFSET"]/*' />
    D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_MONO_OFFSET = 4,

    /// <include file='D3D11_VIDEO_PROCESSOR_STEREO_FORMAT.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STEREO_FORMAT.D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_ROW_INTERLEAVED"]/*' />
    D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_ROW_INTERLEAVED = 5,

    /// <include file='D3D11_VIDEO_PROCESSOR_STEREO_FORMAT.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STEREO_FORMAT.D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_COLUMN_INTERLEAVED"]/*' />
    D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_COLUMN_INTERLEAVED = 6,

    /// <include file='D3D11_VIDEO_PROCESSOR_STEREO_FORMAT.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STEREO_FORMAT.D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_CHECKERBOARD"]/*' />
    D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_CHECKERBOARD = 7,
}
