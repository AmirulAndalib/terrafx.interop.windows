// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("F5B0BF81-8CB5-4B1B-9449-1A159E0C733C")]
    [NativeTypeName("struct IIOCancelInformation : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IIOCancelInformation : IIOCancelInformation.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IIOCancelInformation*, Guid*, void**, int>)(lpVtbl[0]))((IIOCancelInformation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IIOCancelInformation*, uint>)(lpVtbl[1]))((IIOCancelInformation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IIOCancelInformation*, uint>)(lpVtbl[2]))((IIOCancelInformation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetCancelInformation([NativeTypeName("DWORD")] uint dwThreadID, uint uMsgCancel)
        {
            return ((delegate* unmanaged<IIOCancelInformation*, uint, uint, int>)(lpVtbl[3]))((IIOCancelInformation*)Unsafe.AsPointer(ref this), dwThreadID, uMsgCancel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetCancelInformation([NativeTypeName("DWORD *")] uint* pdwThreadID, uint* puMsgCancel)
        {
            return ((delegate* unmanaged<IIOCancelInformation*, uint*, uint*, int>)(lpVtbl[4]))((IIOCancelInformation*)Unsafe.AsPointer(ref this), pdwThreadID, puMsgCancel);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetCancelInformation([NativeTypeName("DWORD")] uint dwThreadID, uint uMsgCancel);

            [VtblIndex(4)]
            HRESULT GetCancelInformation([NativeTypeName("DWORD *")] uint* pdwThreadID, uint* puMsgCancel);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IIOCancelInformation*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IIOCancelInformation*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IIOCancelInformation*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<IIOCancelInformation*, uint, uint, int> SetCancelInformation;

            [NativeTypeName("HRESULT (DWORD *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IIOCancelInformation*, uint*, uint*, int> GetCancelInformation;
        }
    }
}
