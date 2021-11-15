// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcommon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    public unsafe partial struct ID3DInclude : ID3DInclude.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT Open(D3D_INCLUDE_TYPE IncludeType, [NativeTypeName("LPCSTR")] sbyte* pFileName, [NativeTypeName("LPCVOID")] void* pParentData, [NativeTypeName("LPCVOID *")] void** ppData, uint* pBytes)
        {
            return ((delegate* unmanaged<ID3DInclude*, D3D_INCLUDE_TYPE, sbyte*, void*, void**, uint*, int>)(lpVtbl[0]))((ID3DInclude*)Unsafe.AsPointer(ref this), IncludeType, pFileName, pParentData, ppData, pBytes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public HRESULT Close([NativeTypeName("LPCVOID")] void* pData)
        {
            return ((delegate* unmanaged<ID3DInclude*, void*, int>)(lpVtbl[1]))((ID3DInclude*)Unsafe.AsPointer(ref this), pData);
        }

        public interface Interface
        {
            [VtblIndex(0)]
            HRESULT Open(D3D_INCLUDE_TYPE IncludeType, [NativeTypeName("LPCSTR")] sbyte* pFileName, [NativeTypeName("LPCVOID")] void* pParentData, [NativeTypeName("LPCVOID *")] void** ppData, uint* pBytes);

            [VtblIndex(1)]
            HRESULT Close([NativeTypeName("LPCVOID")] void* pData);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (D3D_INCLUDE_TYPE, LPCSTR, LPCVOID, LPCVOID *, UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3DInclude*, D3D_INCLUDE_TYPE, sbyte*, void*, void**, uint*, int> Open;

            [NativeTypeName("HRESULT (LPCVOID) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3DInclude*, void*, int> Close;
        }
    }
}