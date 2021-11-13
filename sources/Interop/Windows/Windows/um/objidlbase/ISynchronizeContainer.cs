// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("00000033-0000-0000-C000-000000000046")]
    [NativeTypeName("struct ISynchronizeContainer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISynchronizeContainer : ISynchronizeContainer.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISynchronizeContainer*, Guid*, void**, int>)(lpVtbl[0]))((ISynchronizeContainer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISynchronizeContainer*, uint>)(lpVtbl[1]))((ISynchronizeContainer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISynchronizeContainer*, uint>)(lpVtbl[2]))((ISynchronizeContainer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AddSynchronize(ISynchronize* pSync)
        {
            return ((delegate* unmanaged<ISynchronizeContainer*, ISynchronize*, int>)(lpVtbl[3]))((ISynchronizeContainer*)Unsafe.AsPointer(ref this), pSync);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT WaitMultiple([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwTimeOut, ISynchronize** ppSync)
        {
            return ((delegate* unmanaged<ISynchronizeContainer*, uint, uint, ISynchronize**, int>)(lpVtbl[4]))((ISynchronizeContainer*)Unsafe.AsPointer(ref this), dwFlags, dwTimeOut, ppSync);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT AddSynchronize(ISynchronize* pSync);

            [VtblIndex(4)]
            HRESULT WaitMultiple([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwTimeOut, ISynchronize** ppSync);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISynchronizeContainer*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISynchronizeContainer*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISynchronizeContainer*, uint> Release;

            [NativeTypeName("HRESULT (ISynchronize *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISynchronizeContainer*, ISynchronize*, int> AddSynchronize;

            [NativeTypeName("HRESULT (DWORD, DWORD, ISynchronize **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISynchronizeContainer*, uint, uint, ISynchronize**, int> WaitMultiple;
        }
    }
}
