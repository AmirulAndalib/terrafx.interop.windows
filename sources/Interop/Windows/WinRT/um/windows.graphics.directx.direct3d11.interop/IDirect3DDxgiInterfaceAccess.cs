// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.graphics.directx.direct3d11.interop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT
{
    [Guid("A9B3D012-3DF2-4EE3-B8D1-8695F457D3C1")]
    [NativeTypeName("struct IDirect3DDxgiInterfaceAccess : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDirect3DDxgiInterfaceAccess : IDirect3DDxgiInterfaceAccess.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DDxgiInterfaceAccess*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DDxgiInterfaceAccess*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DDxgiInterfaceAccess*, uint>)(lpVtbl[1]))((IDirect3DDxgiInterfaceAccess*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirect3DDxgiInterfaceAccess*, uint>)(lpVtbl[2]))((IDirect3DDxgiInterfaceAccess*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetInterface([NativeTypeName("const IID &")] Guid* iid, void** p)
        {
            return ((delegate* unmanaged<IDirect3DDxgiInterfaceAccess*, Guid*, void**, int>)(lpVtbl[3]))((IDirect3DDxgiInterfaceAccess*)Unsafe.AsPointer(ref this), iid, p);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetInterface([NativeTypeName("const IID &")] Guid* iid, void** p);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDirect3DDxgiInterfaceAccess*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDirect3DDxgiInterfaceAccess*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDirect3DDxgiInterfaceAccess*, uint> Release;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDirect3DDxgiInterfaceAccess*, Guid*, void**, int> GetInterface;
        }
    }
}
