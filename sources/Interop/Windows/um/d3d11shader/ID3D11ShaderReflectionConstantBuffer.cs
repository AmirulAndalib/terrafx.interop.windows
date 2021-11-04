// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EB62D63D-93DD-4318-8AE8-C6F83AD371B8")]
    public unsafe partial struct ID3D11ShaderReflectionConstantBuffer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT GetDesc(D3D11_SHADER_BUFFER_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionConstantBuffer*, D3D11_SHADER_BUFFER_DESC*, int>)(lpVtbl[0]))((ID3D11ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public ID3D11ShaderReflectionVariable* GetVariableByIndex(uint Index)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionConstantBuffer*, uint, ID3D11ShaderReflectionVariable*>)(lpVtbl[1]))((ID3D11ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), Index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public ID3D11ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionConstantBuffer*, sbyte*, ID3D11ShaderReflectionVariable*>)(lpVtbl[2]))((ID3D11ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), Name);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (D3D11_SHADER_BUFFER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11ShaderReflectionConstantBuffer*, D3D11_SHADER_BUFFER_DESC*, int> GetDesc;

            [NativeTypeName("ID3D11ShaderReflectionVariable *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11ShaderReflectionConstantBuffer*, uint, ID3D11ShaderReflectionVariable*> GetVariableByIndex;

            [NativeTypeName("ID3D11ShaderReflectionVariable *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11ShaderReflectionConstantBuffer*, sbyte*, ID3D11ShaderReflectionVariable*> GetVariableByName;
        }
    }
}
