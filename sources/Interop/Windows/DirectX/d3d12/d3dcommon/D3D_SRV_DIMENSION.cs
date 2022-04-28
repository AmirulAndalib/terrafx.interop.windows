// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dcommon.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION"]/*' />
public enum D3D_SRV_DIMENSION
{
    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_UNKNOWN"]/*' />
    D3D_SRV_DIMENSION_UNKNOWN = 0,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_BUFFER"]/*' />
    D3D_SRV_DIMENSION_BUFFER = 1,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_TEXTURE1D"]/*' />
    D3D_SRV_DIMENSION_TEXTURE1D = 2,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_TEXTURE1DARRAY"]/*' />
    D3D_SRV_DIMENSION_TEXTURE1DARRAY = 3,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_TEXTURE2D"]/*' />
    D3D_SRV_DIMENSION_TEXTURE2D = 4,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_TEXTURE2DARRAY"]/*' />
    D3D_SRV_DIMENSION_TEXTURE2DARRAY = 5,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_TEXTURE2DMS"]/*' />
    D3D_SRV_DIMENSION_TEXTURE2DMS = 6,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_TEXTURE2DMSARRAY"]/*' />
    D3D_SRV_DIMENSION_TEXTURE2DMSARRAY = 7,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_TEXTURE3D"]/*' />
    D3D_SRV_DIMENSION_TEXTURE3D = 8,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_TEXTURECUBE"]/*' />
    D3D_SRV_DIMENSION_TEXTURECUBE = 9,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_TEXTURECUBEARRAY"]/*' />
    D3D_SRV_DIMENSION_TEXTURECUBEARRAY = 10,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_BUFFEREX"]/*' />
    D3D_SRV_DIMENSION_BUFFEREX = 11,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_SRV_DIMENSION_UNKNOWN"]/*' />
    D3D10_SRV_DIMENSION_UNKNOWN = D3D_SRV_DIMENSION_UNKNOWN,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_SRV_DIMENSION_BUFFER"]/*' />
    D3D10_SRV_DIMENSION_BUFFER = D3D_SRV_DIMENSION_BUFFER,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_SRV_DIMENSION_TEXTURE1D"]/*' />
    D3D10_SRV_DIMENSION_TEXTURE1D = D3D_SRV_DIMENSION_TEXTURE1D,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_SRV_DIMENSION_TEXTURE1DARRAY"]/*' />
    D3D10_SRV_DIMENSION_TEXTURE1DARRAY = D3D_SRV_DIMENSION_TEXTURE1DARRAY,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_SRV_DIMENSION_TEXTURE2D"]/*' />
    D3D10_SRV_DIMENSION_TEXTURE2D = D3D_SRV_DIMENSION_TEXTURE2D,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_SRV_DIMENSION_TEXTURE2DARRAY"]/*' />
    D3D10_SRV_DIMENSION_TEXTURE2DARRAY = D3D_SRV_DIMENSION_TEXTURE2DARRAY,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_SRV_DIMENSION_TEXTURE2DMS"]/*' />
    D3D10_SRV_DIMENSION_TEXTURE2DMS = D3D_SRV_DIMENSION_TEXTURE2DMS,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_SRV_DIMENSION_TEXTURE2DMSARRAY"]/*' />
    D3D10_SRV_DIMENSION_TEXTURE2DMSARRAY = D3D_SRV_DIMENSION_TEXTURE2DMSARRAY,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_SRV_DIMENSION_TEXTURE3D"]/*' />
    D3D10_SRV_DIMENSION_TEXTURE3D = D3D_SRV_DIMENSION_TEXTURE3D,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_SRV_DIMENSION_TEXTURECUBE"]/*' />
    D3D10_SRV_DIMENSION_TEXTURECUBE = D3D_SRV_DIMENSION_TEXTURECUBE,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_UNKNOWN"]/*' />
    D3D10_1_SRV_DIMENSION_UNKNOWN = D3D_SRV_DIMENSION_UNKNOWN,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_BUFFER"]/*' />
    D3D10_1_SRV_DIMENSION_BUFFER = D3D_SRV_DIMENSION_BUFFER,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_TEXTURE1D"]/*' />
    D3D10_1_SRV_DIMENSION_TEXTURE1D = D3D_SRV_DIMENSION_TEXTURE1D,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_TEXTURE1DARRAY"]/*' />
    D3D10_1_SRV_DIMENSION_TEXTURE1DARRAY = D3D_SRV_DIMENSION_TEXTURE1DARRAY,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_TEXTURE2D"]/*' />
    D3D10_1_SRV_DIMENSION_TEXTURE2D = D3D_SRV_DIMENSION_TEXTURE2D,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_TEXTURE2DARRAY"]/*' />
    D3D10_1_SRV_DIMENSION_TEXTURE2DARRAY = D3D_SRV_DIMENSION_TEXTURE2DARRAY,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_TEXTURE2DMS"]/*' />
    D3D10_1_SRV_DIMENSION_TEXTURE2DMS = D3D_SRV_DIMENSION_TEXTURE2DMS,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_TEXTURE2DMSARRAY"]/*' />
    D3D10_1_SRV_DIMENSION_TEXTURE2DMSARRAY = D3D_SRV_DIMENSION_TEXTURE2DMSARRAY,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_TEXTURE3D"]/*' />
    D3D10_1_SRV_DIMENSION_TEXTURE3D = D3D_SRV_DIMENSION_TEXTURE3D,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_TEXTURECUBE"]/*' />
    D3D10_1_SRV_DIMENSION_TEXTURECUBE = D3D_SRV_DIMENSION_TEXTURECUBE,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_TEXTURECUBEARRAY"]/*' />
    D3D10_1_SRV_DIMENSION_TEXTURECUBEARRAY = D3D_SRV_DIMENSION_TEXTURECUBEARRAY,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_UNKNOWN"]/*' />
    D3D11_SRV_DIMENSION_UNKNOWN = D3D_SRV_DIMENSION_UNKNOWN,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_BUFFER"]/*' />
    D3D11_SRV_DIMENSION_BUFFER = D3D_SRV_DIMENSION_BUFFER,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_TEXTURE1D"]/*' />
    D3D11_SRV_DIMENSION_TEXTURE1D = D3D_SRV_DIMENSION_TEXTURE1D,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_TEXTURE1DARRAY"]/*' />
    D3D11_SRV_DIMENSION_TEXTURE1DARRAY = D3D_SRV_DIMENSION_TEXTURE1DARRAY,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_TEXTURE2D"]/*' />
    D3D11_SRV_DIMENSION_TEXTURE2D = D3D_SRV_DIMENSION_TEXTURE2D,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_TEXTURE2DARRAY"]/*' />
    D3D11_SRV_DIMENSION_TEXTURE2DARRAY = D3D_SRV_DIMENSION_TEXTURE2DARRAY,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_TEXTURE2DMS"]/*' />
    D3D11_SRV_DIMENSION_TEXTURE2DMS = D3D_SRV_DIMENSION_TEXTURE2DMS,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_TEXTURE2DMSARRAY"]/*' />
    D3D11_SRV_DIMENSION_TEXTURE2DMSARRAY = D3D_SRV_DIMENSION_TEXTURE2DMSARRAY,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_TEXTURE3D"]/*' />
    D3D11_SRV_DIMENSION_TEXTURE3D = D3D_SRV_DIMENSION_TEXTURE3D,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_TEXTURECUBE"]/*' />
    D3D11_SRV_DIMENSION_TEXTURECUBE = D3D_SRV_DIMENSION_TEXTURECUBE,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_TEXTURECUBEARRAY"]/*' />
    D3D11_SRV_DIMENSION_TEXTURECUBEARRAY = D3D_SRV_DIMENSION_TEXTURECUBEARRAY,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_BUFFEREX"]/*' />
    D3D11_SRV_DIMENSION_BUFFEREX = D3D_SRV_DIMENSION_BUFFEREX,
}