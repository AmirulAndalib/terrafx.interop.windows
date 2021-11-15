// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    [Guid("091F7A26-1C1F-4948-904B-E6E3A8A771D5")]
    [NativeTypeName("struct IDxcAssembler : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDxcAssembler : IDxcAssembler.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDxcAssembler*, Guid*, void**, int>)(lpVtbl[0]))((IDxcAssembler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDxcAssembler*, uint>)(lpVtbl[1]))((IDxcAssembler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDxcAssembler*, uint>)(lpVtbl[2]))((IDxcAssembler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AssembleToContainer(IDxcBlob* pShader, IDxcOperationResult** ppResult)
        {
            return ((delegate* unmanaged<IDxcAssembler*, IDxcBlob*, IDxcOperationResult**, int>)(lpVtbl[3]))((IDxcAssembler*)Unsafe.AsPointer(ref this), pShader, ppResult);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT AssembleToContainer(IDxcBlob* pShader, IDxcOperationResult** ppResult);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDxcAssembler*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDxcAssembler*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDxcAssembler*, uint> Release;

            [NativeTypeName("HRESULT (IDxcBlob *, IDxcOperationResult **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDxcAssembler*, IDxcBlob*, IDxcOperationResult**, int> AssembleToContainer;
        }
    }
}