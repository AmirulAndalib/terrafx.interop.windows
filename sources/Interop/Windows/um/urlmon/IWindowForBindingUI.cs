// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9D5-BAFA-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IWindowForBindingUI : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWindowForBindingUI
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWindowForBindingUI*, Guid*, void**, int>)(lpVtbl[0]))((IWindowForBindingUI*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWindowForBindingUI*, uint>)(lpVtbl[1]))((IWindowForBindingUI*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWindowForBindingUI*, uint>)(lpVtbl[2]))((IWindowForBindingUI*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetWindow([NativeTypeName("const GUID &")] Guid* rguidReason, HWND* phwnd)
        {
            return ((delegate* unmanaged<IWindowForBindingUI*, Guid*, HWND*, int>)(lpVtbl[3]))((IWindowForBindingUI*)Unsafe.AsPointer(ref this), rguidReason, phwnd);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWindowForBindingUI*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWindowForBindingUI*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWindowForBindingUI*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, HWND *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWindowForBindingUI*, Guid*, HWND*, int> GetWindow;
        }
    }
}
