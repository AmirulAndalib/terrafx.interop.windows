// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11on12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("d3d11", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D11On12CreateDevice(IUnknown* pDevice, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("const D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pFeatureLevels, [NativeTypeName("UINT")] uint FeatureLevels, [NativeTypeName("IUnknown *const *")] IUnknown** ppCommandQueues, [NativeTypeName("UINT")] uint NumQueues, [NativeTypeName("UINT")] uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, D3D_FEATURE_LEVEL* pChosenFeatureLevel);

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D11On12Device
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x73, 0x1E, 0x61, 0x85,
                    0xA9, 0x70,
                    0x0E, 0x49,
                    0x96,
                    0x14,
                    0xA9,
                    0xE3,
                    0x02,
                    0x77,
                    0x79,
                    0x04
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D11On12Device1
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF4, 0x4D, 0xB6, 0xBD,
                    0x2F, 0xEA,
                    0x70, 0x4C,
                    0xB8,
                    0x61,
                    0xAA,
                    0xAB,
                    0x12,
                    0x58,
                    0xBB,
                    0x5D
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D11On12Device2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x31, 0xF3, 0x90, 0xDC,
                    0x40, 0x47,
                    0xFA, 0x43,
                    0x86,
                    0x6E,
                    0x67,
                    0xF1,
                    0x2C,
                    0xB5,
                    0x82,
                    0x23
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
