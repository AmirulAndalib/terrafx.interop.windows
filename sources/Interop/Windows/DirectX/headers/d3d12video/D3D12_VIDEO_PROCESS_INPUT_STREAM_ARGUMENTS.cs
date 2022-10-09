// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS"]/*' />
public unsafe partial struct D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS
{
    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS.InputStream"]/*' />
    [NativeTypeName("D3D12_VIDEO_PROCESS_INPUT_STREAM[2]")]
    public _InputStream_e__FixedBuffer InputStream;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS.Transform"]/*' />
    public D3D12_VIDEO_PROCESS_TRANSFORM Transform;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS.Flags"]/*' />
    public D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAGS Flags;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS.RateInfo"]/*' />
    public D3D12_VIDEO_PROCESS_INPUT_STREAM_RATE RateInfo;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS.FilterLevels"]/*' />
    [NativeTypeName("INT[32]")]
    public fixed int FilterLevels[32];

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS.AlphaBlending"]/*' />
    public D3D12_VIDEO_PROCESS_ALPHA_BLENDING AlphaBlending;

    /// <include file='_InputStream_e__FixedBuffer.xml' path='doc/member[@name="_InputStream_e__FixedBuffer"]/*' />
    public partial struct _InputStream_e__FixedBuffer
    {
        public D3D12_VIDEO_PROCESS_INPUT_STREAM e0;
        public D3D12_VIDEO_PROCESS_INPUT_STREAM e1;

        [UnscopedRef]
        public ref D3D12_VIDEO_PROCESS_INPUT_STREAM this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<D3D12_VIDEO_PROCESS_INPUT_STREAM> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 2);
    }
}
