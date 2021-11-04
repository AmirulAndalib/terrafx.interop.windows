// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A005A9D9-B8BB-4594-B5C9-0E633BEC4D37")]
    [NativeTypeName("struct IDxcCompiler2 : IDxcCompiler")]
    [NativeInheritance("IDxcCompiler")]
    public unsafe partial struct IDxcCompiler2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDxcCompiler2*, Guid*, void**, int>)(lpVtbl[0]))((IDxcCompiler2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDxcCompiler2*, uint>)(lpVtbl[1]))((IDxcCompiler2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDxcCompiler2*, uint>)(lpVtbl[2]))((IDxcCompiler2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Compile(IDxcBlob* pSource, [NativeTypeName("LPCWSTR")] ushort* pSourceName, [NativeTypeName("LPCWSTR")] ushort* pEntryPoint, [NativeTypeName("LPCWSTR")] ushort* pTargetProfile, [NativeTypeName("LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount, [NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            return ((delegate* unmanaged<IDxcCompiler2*, IDxcBlob*, ushort*, ushort*, ushort*, ushort**, uint, DxcDefine*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)(lpVtbl[3]))((IDxcCompiler2*)Unsafe.AsPointer(ref this), pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Preprocess(IDxcBlob* pSource, [NativeTypeName("LPCWSTR")] ushort* pSourceName, [NativeTypeName("LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount, [NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            return ((delegate* unmanaged<IDxcCompiler2*, IDxcBlob*, ushort*, ushort**, uint, DxcDefine*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)(lpVtbl[4]))((IDxcCompiler2*)Unsafe.AsPointer(ref this), pSource, pSourceName, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Disassemble(IDxcBlob* pSource, IDxcBlobEncoding** ppDisassembly)
        {
            return ((delegate* unmanaged<IDxcCompiler2*, IDxcBlob*, IDxcBlobEncoding**, int>)(lpVtbl[5]))((IDxcCompiler2*)Unsafe.AsPointer(ref this), pSource, ppDisassembly);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT CompileWithDebug(IDxcBlob* pSource, [NativeTypeName("LPCWSTR")] ushort* pSourceName, [NativeTypeName("LPCWSTR")] ushort* pEntryPoint, [NativeTypeName("LPCWSTR")] ushort* pTargetProfile, [NativeTypeName("LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount, [NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult, [NativeTypeName("LPWSTR *")] ushort** ppDebugBlobName, IDxcBlob** ppDebugBlob)
        {
            return ((delegate* unmanaged<IDxcCompiler2*, IDxcBlob*, ushort*, ushort*, ushort*, ushort**, uint, DxcDefine*, uint, IDxcIncludeHandler*, IDxcOperationResult**, ushort**, IDxcBlob**, int>)(lpVtbl[6]))((IDxcCompiler2*)Unsafe.AsPointer(ref this), pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult, ppDebugBlobName, ppDebugBlob);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDxcCompiler2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDxcCompiler2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDxcCompiler2*, uint> Release;

            [NativeTypeName("HRESULT (IDxcBlob *, LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR *, UINT32, const DxcDefine *, UINT32, IDxcIncludeHandler *, IDxcOperationResult **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDxcCompiler2*, IDxcBlob*, ushort*, ushort*, ushort*, ushort**, uint, DxcDefine*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int> Compile;

            [NativeTypeName("HRESULT (IDxcBlob *, LPCWSTR, LPCWSTR *, UINT32, const DxcDefine *, UINT32, IDxcIncludeHandler *, IDxcOperationResult **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDxcCompiler2*, IDxcBlob*, ushort*, ushort**, uint, DxcDefine*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int> Preprocess;

            [NativeTypeName("HRESULT (IDxcBlob *, IDxcBlobEncoding **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDxcCompiler2*, IDxcBlob*, IDxcBlobEncoding**, int> Disassemble;

            [NativeTypeName("HRESULT (IDxcBlob *, LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR *, UINT32, const DxcDefine *, UINT32, IDxcIncludeHandler *, IDxcOperationResult **, LPWSTR *, IDxcBlob **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDxcCompiler2*, IDxcBlob*, ushort*, ushort*, ushort*, ushort**, uint, DxcDefine*, uint, IDxcIncludeHandler*, IDxcOperationResult**, ushort**, IDxcBlob**, int> CompileWithDebug;
        }
    }
}
