// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_DEPTH_STENCIL_VIEW_DESC.xml' path='doc/member[@name="D3D11_DEPTH_STENCIL_VIEW_DESC"]/*' />
public partial struct D3D11_DEPTH_STENCIL_VIEW_DESC
{
    /// <include file='D3D11_DEPTH_STENCIL_VIEW_DESC.xml' path='doc/member[@name="D3D11_DEPTH_STENCIL_VIEW_DESC.Format"]/*' />
    public DXGI_FORMAT Format;

    /// <include file='D3D11_DEPTH_STENCIL_VIEW_DESC.xml' path='doc/member[@name="D3D11_DEPTH_STENCIL_VIEW_DESC.ViewDimension"]/*' />
    public D3D11_DSV_DIMENSION ViewDimension;

    /// <include file='D3D11_DEPTH_STENCIL_VIEW_DESC.xml' path='doc/member[@name="D3D11_DEPTH_STENCIL_VIEW_DESC.Flags"]/*' />
    public uint Flags;

    /// <include file='D3D11_DEPTH_STENCIL_VIEW_DESC.xml' path='doc/member[@name="D3D11_DEPTH_STENCIL_VIEW_DESC.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_d3d11_L4430_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture1D"]/*' />
    [UnscopedRef]
    public ref D3D11_TEX1D_DSV Texture1D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Texture1D;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture1DArray"]/*' />
    [UnscopedRef]
    public ref D3D11_TEX1D_ARRAY_DSV Texture1DArray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Texture1DArray;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2D"]/*' />
    [UnscopedRef]
    public ref D3D11_TEX2D_DSV Texture2D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Texture2D;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2DArray"]/*' />
    [UnscopedRef]
    public ref D3D11_TEX2D_ARRAY_DSV Texture2DArray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Texture2DArray;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2DMS"]/*' />
    [UnscopedRef]
    public ref D3D11_TEX2DMS_DSV Texture2DMS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Texture2DMS;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2DMSArray"]/*' />
    [UnscopedRef]
    public ref D3D11_TEX2DMS_ARRAY_DSV Texture2DMSArray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Texture2DMSArray;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture1D"]/*' />
        [FieldOffset(0)]
        public D3D11_TEX1D_DSV Texture1D;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture1DArray"]/*' />
        [FieldOffset(0)]
        public D3D11_TEX1D_ARRAY_DSV Texture1DArray;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2D"]/*' />
        [FieldOffset(0)]
        public D3D11_TEX2D_DSV Texture2D;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2DArray"]/*' />
        [FieldOffset(0)]
        public D3D11_TEX2D_ARRAY_DSV Texture2DArray;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2DMS"]/*' />
        [FieldOffset(0)]
        public D3D11_TEX2DMS_DSV Texture2DMS;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2DMSArray"]/*' />
        [FieldOffset(0)]
        public D3D11_TEX2DMS_ARRAY_DSV Texture2DMSArray;
    }
}
