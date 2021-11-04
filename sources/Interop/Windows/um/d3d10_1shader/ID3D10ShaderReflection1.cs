// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10_1shader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct ID3D10ShaderReflection1 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D10ShaderReflection1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, uint>)(lpVtbl[1]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, uint>)(lpVtbl[2]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetDesc(D3D10_SHADER_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, D3D10_SHADER_DESC*, int>)(lpVtbl[3]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public ID3D10ShaderReflectionConstantBuffer* GetConstantBufferByIndex(uint Index)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, uint, ID3D10ShaderReflectionConstantBuffer*>)(lpVtbl[4]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), Index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public ID3D10ShaderReflectionConstantBuffer* GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, sbyte*, ID3D10ShaderReflectionConstantBuffer*>)(lpVtbl[5]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetResourceBindingDesc(uint ResourceIndex, D3D10_SHADER_INPUT_BIND_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, uint, D3D10_SHADER_INPUT_BIND_DESC*, int>)(lpVtbl[6]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), ResourceIndex, pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetInputParameterDesc(uint ParameterIndex, D3D10_SIGNATURE_PARAMETER_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, uint, D3D10_SIGNATURE_PARAMETER_DESC*, int>)(lpVtbl[7]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetOutputParameterDesc(uint ParameterIndex, D3D10_SIGNATURE_PARAMETER_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, uint, D3D10_SIGNATURE_PARAMETER_DESC*, int>)(lpVtbl[8]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public ID3D10ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, sbyte*, ID3D10ShaderReflectionVariable*>)(lpVtbl[9]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetResourceBindingDescByName([NativeTypeName("LPCSTR")] sbyte* Name, D3D10_SHADER_INPUT_BIND_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, sbyte*, D3D10_SHADER_INPUT_BIND_DESC*, int>)(lpVtbl[10]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), Name, pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetMovInstructionCount(uint* pCount)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, uint*, int>)(lpVtbl[11]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), pCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetMovcInstructionCount(uint* pCount)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, uint*, int>)(lpVtbl[12]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), pCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetConversionInstructionCount(uint* pCount)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, uint*, int>)(lpVtbl[13]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), pCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetBitwiseInstructionCount(uint* pCount)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, uint*, int>)(lpVtbl[14]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), pCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetGSInputPrimitive([NativeTypeName("D3D10_PRIMITIVE *")] D3D_PRIMITIVE* pPrim)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, D3D_PRIMITIVE*, int>)(lpVtbl[15]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), pPrim);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT IsLevel9Shader(BOOL* pbLevel9Shader)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, BOOL*, int>)(lpVtbl[16]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), pbLevel9Shader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT IsSampleFrequencyShader(BOOL* pbSampleFrequency)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, BOOL*, int>)(lpVtbl[17]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), pbSampleFrequency);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D10ShaderReflection1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D10ShaderReflection1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D10ShaderReflection1*, uint> Release;

            [NativeTypeName("HRESULT (D3D10_SHADER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D10ShaderReflection1*, D3D10_SHADER_DESC*, int> GetDesc;

            [NativeTypeName("ID3D10ShaderReflectionConstantBuffer *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D10ShaderReflection1*, uint, ID3D10ShaderReflectionConstantBuffer*> GetConstantBufferByIndex;

            [NativeTypeName("ID3D10ShaderReflectionConstantBuffer *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D10ShaderReflection1*, sbyte*, ID3D10ShaderReflectionConstantBuffer*> GetConstantBufferByName;

            [NativeTypeName("HRESULT (UINT, D3D10_SHADER_INPUT_BIND_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D10ShaderReflection1*, uint, D3D10_SHADER_INPUT_BIND_DESC*, int> GetResourceBindingDesc;

            [NativeTypeName("HRESULT (UINT, D3D10_SIGNATURE_PARAMETER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D10ShaderReflection1*, uint, D3D10_SIGNATURE_PARAMETER_DESC*, int> GetInputParameterDesc;

            [NativeTypeName("HRESULT (UINT, D3D10_SIGNATURE_PARAMETER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D10ShaderReflection1*, uint, D3D10_SIGNATURE_PARAMETER_DESC*, int> GetOutputParameterDesc;

            [NativeTypeName("ID3D10ShaderReflectionVariable *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D10ShaderReflection1*, sbyte*, ID3D10ShaderReflectionVariable*> GetVariableByName;

            [NativeTypeName("HRESULT (LPCSTR, D3D10_SHADER_INPUT_BIND_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D10ShaderReflection1*, sbyte*, D3D10_SHADER_INPUT_BIND_DESC*, int> GetResourceBindingDescByName;

            [NativeTypeName("HRESULT (UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D10ShaderReflection1*, uint*, int> GetMovInstructionCount;

            [NativeTypeName("HRESULT (UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D10ShaderReflection1*, uint*, int> GetMovcInstructionCount;

            [NativeTypeName("HRESULT (UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D10ShaderReflection1*, uint*, int> GetConversionInstructionCount;

            [NativeTypeName("HRESULT (UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D10ShaderReflection1*, uint*, int> GetBitwiseInstructionCount;

            [NativeTypeName("HRESULT (D3D10_PRIMITIVE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D10ShaderReflection1*, D3D_PRIMITIVE*, int> GetGSInputPrimitive;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D10ShaderReflection1*, BOOL*, int> IsLevel9Shader;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D10ShaderReflection1*, BOOL*, int> IsSampleFrequencyShader;
        }
    }
}
