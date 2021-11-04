// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct IDirectDrawClipper : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDirectDrawClipper
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirectDrawClipper*, Guid*, void**, int>)(lpVtbl[0]))((IDirectDrawClipper*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirectDrawClipper*, uint>)(lpVtbl[1]))((IDirectDrawClipper*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirectDrawClipper*, uint>)(lpVtbl[2]))((IDirectDrawClipper*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetClipList([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPRGNDATA")] RGNDATA* param1, [NativeTypeName("LPDWORD")] uint* param2)
        {
            return ((delegate* unmanaged<IDirectDrawClipper*, RECT*, RGNDATA*, uint*, int>)(lpVtbl[3]))((IDirectDrawClipper*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetHWnd(HWND* param0)
        {
            return ((delegate* unmanaged<IDirectDrawClipper*, HWND*, int>)(lpVtbl[4]))((IDirectDrawClipper*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Initialize([NativeTypeName("LPDIRECTDRAW")] IDirectDraw* param0, [NativeTypeName("DWORD")] uint param1)
        {
            return ((delegate* unmanaged<IDirectDrawClipper*, IDirectDraw*, uint, int>)(lpVtbl[5]))((IDirectDrawClipper*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT IsClipListChanged(BOOL* param0)
        {
            return ((delegate* unmanaged<IDirectDrawClipper*, BOOL*, int>)(lpVtbl[6]))((IDirectDrawClipper*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetClipList([NativeTypeName("LPRGNDATA")] RGNDATA* param0, [NativeTypeName("DWORD")] uint param1)
        {
            return ((delegate* unmanaged<IDirectDrawClipper*, RGNDATA*, uint, int>)(lpVtbl[7]))((IDirectDrawClipper*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetHWnd([NativeTypeName("DWORD")] uint param0, HWND param1)
        {
            return ((delegate* unmanaged<IDirectDrawClipper*, uint, HWND, int>)(lpVtbl[8]))((IDirectDrawClipper*)Unsafe.AsPointer(ref this), param0, param1);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDirectDrawClipper*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDirectDrawClipper*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDirectDrawClipper*, uint> Release;

            [NativeTypeName("HRESULT (LPRECT, LPRGNDATA, LPDWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDirectDrawClipper*, RECT*, RGNDATA*, uint*, int> GetClipList;

            [NativeTypeName("HRESULT (HWND *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDirectDrawClipper*, HWND*, int> GetHWnd;

            [NativeTypeName("HRESULT (LPDIRECTDRAW, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDirectDrawClipper*, IDirectDraw*, uint, int> Initialize;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDirectDrawClipper*, BOOL*, int> IsClipListChanged;

            [NativeTypeName("HRESULT (LPRGNDATA, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDirectDrawClipper*, RGNDATA*, uint, int> SetClipList;

            [NativeTypeName("HRESULT (DWORD, HWND) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDirectDrawClipper*, uint, HWND, int> SetHWnd;
        }
    }
}
