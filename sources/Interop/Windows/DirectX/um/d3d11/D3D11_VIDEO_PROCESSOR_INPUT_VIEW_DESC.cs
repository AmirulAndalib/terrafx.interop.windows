// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC
{
    /// <include file='D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC.FourCC"]/*' />
    public uint FourCC;

    /// <include file='D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC.ViewDimension"]/*' />
    public D3D11_VPIV_DIMENSION ViewDimension;

    /// <include file='D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_d3d11_L11842_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2D"]/*' />
    [UnscopedRef]
    public ref D3D11_TEX2D_VPIV Texture2D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Texture2D;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2D"]/*' />
        [FieldOffset(0)]
        public D3D11_TEX2D_VPIV Texture2D;
    }
}
