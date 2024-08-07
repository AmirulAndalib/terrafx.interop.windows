// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.DirectX.D3D11_UAV_DIMENSION;
using static TerraFX.Interop.DirectX.DXGI_FORMAT;

namespace TerraFX.Interop.DirectX;

public unsafe partial struct D3D11_UNORDERED_ACCESS_VIEW_DESC
{
    public D3D11_UNORDERED_ACCESS_VIEW_DESC(D3D11_UAV_DIMENSION viewDimension, DXGI_FORMAT format = DXGI_FORMAT_UNKNOWN, uint mipSlice = 0, uint firstArraySlice = 0, uint arraySize = unchecked((uint)-1), uint flags = 0)
    {
        Format = format;
        ViewDimension = viewDimension;
        Anonymous = default;

        switch (viewDimension)
        {
            case D3D11_UAV_DIMENSION_BUFFER:
            {
                Anonymous.Buffer.FirstElement = mipSlice;
                Anonymous.Buffer.NumElements = firstArraySlice;
                Anonymous.Buffer.Flags = flags;
                break;
            }

            case D3D11_UAV_DIMENSION_TEXTURE1D:
            {
                Anonymous.Texture1D.MipSlice = mipSlice;
                break;
            }

            case D3D11_UAV_DIMENSION_TEXTURE1DARRAY:
            {
                Anonymous.Texture1DArray.MipSlice = mipSlice;
                Anonymous.Texture1DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture1DArray.ArraySize = arraySize;
                break;
            }

            case D3D11_UAV_DIMENSION_TEXTURE2D:
            {
                Anonymous.Texture2D.MipSlice = mipSlice;
                break;
            }

            case D3D11_UAV_DIMENSION_TEXTURE2DARRAY:
            {
                Anonymous.Texture2DArray.MipSlice = mipSlice;
                Anonymous.Texture2DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DArray.ArraySize = arraySize;
                break;
            }

            case D3D11_UAV_DIMENSION_TEXTURE3D:
            {
                Anonymous.Texture3D.MipSlice = mipSlice;
                Anonymous.Texture3D.FirstWSlice = firstArraySlice;
                Anonymous.Texture3D.WSize = arraySize;
                break;
            }

            default:
            {
                break;
            }
        }
    }

    public D3D11_UNORDERED_ACCESS_VIEW_DESC(ID3D11Buffer* param0, DXGI_FORMAT format, uint firstElement, uint numElements, uint flags = 0)
    {
        Format = format;
        ViewDimension = D3D11_UAV_DIMENSION_BUFFER;
        Anonymous = default;

        Anonymous.Buffer.FirstElement = firstElement;
        Anonymous.Buffer.NumElements = numElements;
        Anonymous.Buffer.Flags = flags;
    }

    public D3D11_UNORDERED_ACCESS_VIEW_DESC(ID3D11Texture1D* pTex1D, D3D11_UAV_DIMENSION viewDimension, DXGI_FORMAT format = DXGI_FORMAT_UNKNOWN, uint mipSlice = 0, uint firstArraySlice = 0, uint arraySize = unchecked((uint)-1))
    {
        ViewDimension = viewDimension;
        if ((DXGI_FORMAT_UNKNOWN == format) || ((unchecked((uint)-1) == arraySize) && (D3D11_UAV_DIMENSION_TEXTURE1DARRAY == viewDimension)))
        {
            D3D11_TEXTURE1D_DESC TexDesc;
            pTex1D->GetDesc(&TexDesc);

            if (DXGI_FORMAT_UNKNOWN == format)
            {
                format = TexDesc.Format;
            }

            if (unchecked((uint)-1) == arraySize)
            {
                arraySize = TexDesc.ArraySize - firstArraySlice;
            }
        }

        Format = format;
        Anonymous = default;

        switch (viewDimension)
        {
            case D3D11_UAV_DIMENSION_TEXTURE1D:
            {
                Anonymous.Texture1D.MipSlice = mipSlice;
                break;
            }

            case D3D11_UAV_DIMENSION_TEXTURE1DARRAY:
            {
                Anonymous.Texture1DArray.MipSlice = mipSlice;
                Anonymous.Texture1DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture1DArray.ArraySize = arraySize;
                break;
            }

            default:
            {
                break;
            }
        }
    }

    public D3D11_UNORDERED_ACCESS_VIEW_DESC(ID3D11Texture2D* pTex2D, D3D11_UAV_DIMENSION viewDimension, DXGI_FORMAT format = DXGI_FORMAT_UNKNOWN, uint mipSlice = 0, uint firstArraySlice = 0, uint arraySize = unchecked((uint)-1))
    {
        ViewDimension = viewDimension;

        if ((DXGI_FORMAT_UNKNOWN == format) || ((unchecked((uint)-1) == arraySize) && (D3D11_UAV_DIMENSION_TEXTURE2DARRAY == viewDimension)))
        {
            D3D11_TEXTURE2D_DESC TexDesc;
            pTex2D->GetDesc(&TexDesc);

            if (DXGI_FORMAT_UNKNOWN == format)
            {
                format = TexDesc.Format;
            }

            if (unchecked((uint)-1) == arraySize)
            {
                arraySize = TexDesc.ArraySize - firstArraySlice;
            }
        }

        Format = format;
        Anonymous = default;

        switch (viewDimension)
        {
            case D3D11_UAV_DIMENSION_TEXTURE2D:
            {
                Anonymous.Texture2D.MipSlice = mipSlice;
                break;
            }

            case D3D11_UAV_DIMENSION_TEXTURE2DARRAY:
            {
                Anonymous.Texture2DArray.MipSlice = mipSlice;
                Anonymous.Texture2DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DArray.ArraySize = arraySize;
                break;
            }

            default:
            {
                break;
            }
        }
    }

    public D3D11_UNORDERED_ACCESS_VIEW_DESC(ID3D11Texture3D* pTex3D, DXGI_FORMAT format = DXGI_FORMAT_UNKNOWN, uint mipSlice = 0, uint firstWSlice = 0, uint wSize = unchecked((uint)-1))
    {
        ViewDimension = D3D11_UAV_DIMENSION_TEXTURE3D;

        if ((DXGI_FORMAT_UNKNOWN == format) || (unchecked((uint)-1) == wSize))
        {
            D3D11_TEXTURE3D_DESC TexDesc;
            pTex3D->GetDesc(&TexDesc);

            if (DXGI_FORMAT_UNKNOWN == format)
            {
                format = TexDesc.Format;
            }

            if (unchecked((uint)-1) == wSize)
            {
                wSize = TexDesc.Depth - firstWSlice;
            }
        }

        Format = format;
        Anonymous = default;

        Anonymous.Texture3D.MipSlice = mipSlice;
        Anonymous.Texture3D.FirstWSlice = firstWSlice;
        Anonymous.Texture3D.WSize = wSize;
    }
}
