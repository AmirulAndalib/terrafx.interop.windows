// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11sdklayers.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    [Guid("1EF337E3-58E7-4F83-A692-DB221F5ED47E")]
    [NativeTypeName("struct ID3D11SwitchToRef : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D11SwitchToRef : ID3D11SwitchToRef.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11SwitchToRef*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11SwitchToRef*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11SwitchToRef*, uint>)(lpVtbl[1]))((ID3D11SwitchToRef*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11SwitchToRef*, uint>)(lpVtbl[2]))((ID3D11SwitchToRef*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public BOOL SetUseRef(BOOL UseRef)
        {
            return ((delegate* unmanaged<ID3D11SwitchToRef*, BOOL, int>)(lpVtbl[3]))((ID3D11SwitchToRef*)Unsafe.AsPointer(ref this), UseRef);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public BOOL GetUseRef()
        {
            return ((delegate* unmanaged<ID3D11SwitchToRef*, int>)(lpVtbl[4]))((ID3D11SwitchToRef*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            BOOL SetUseRef(BOOL UseRef);

            [VtblIndex(4)]
            BOOL GetUseRef();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11SwitchToRef*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11SwitchToRef*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11SwitchToRef*, uint> Release;

            [NativeTypeName("BOOL (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11SwitchToRef*, BOOL, int> SetUseRef;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11SwitchToRef*, int> GetUseRef;
        }
    }
}
