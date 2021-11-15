// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT
{
    [Guid("35DBF59E-E3F9-45B0-81E7-FE75F4145DC9")]
    [NativeTypeName("struct IDesktopWindowTargetInterop : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDesktopWindowTargetInterop : IDesktopWindowTargetInterop.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDesktopWindowTargetInterop*, Guid*, void**, int>)(lpVtbl[0]))((IDesktopWindowTargetInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDesktopWindowTargetInterop*, uint>)(lpVtbl[1]))((IDesktopWindowTargetInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDesktopWindowTargetInterop*, uint>)(lpVtbl[2]))((IDesktopWindowTargetInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT get_Hwnd(HWND* value)
        {
            return ((delegate* unmanaged<IDesktopWindowTargetInterop*, HWND*, int>)(lpVtbl[3]))((IDesktopWindowTargetInterop*)Unsafe.AsPointer(ref this), value);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT get_Hwnd(HWND* value);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDesktopWindowTargetInterop*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDesktopWindowTargetInterop*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDesktopWindowTargetInterop*, uint> Release;

            [NativeTypeName("HRESULT (HWND *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDesktopWindowTargetInterop*, HWND*, int> get_Hwnd;
        }
    }
}