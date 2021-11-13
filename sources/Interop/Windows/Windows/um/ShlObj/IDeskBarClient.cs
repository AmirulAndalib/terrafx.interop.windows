// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("EB0FE175-1A3A-11D0-89B3-00A0C90A90AC")]
    [NativeTypeName("struct IDeskBarClient : IOleWindow")]
    [NativeInheritance("IOleWindow")]
    public unsafe partial struct IDeskBarClient : IDeskBarClient.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDeskBarClient*, Guid*, void**, int>)(lpVtbl[0]))((IDeskBarClient*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDeskBarClient*, uint>)(lpVtbl[1]))((IDeskBarClient*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDeskBarClient*, uint>)(lpVtbl[2]))((IDeskBarClient*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetWindow(HWND* phwnd)
        {
            return ((delegate* unmanaged<IDeskBarClient*, HWND*, int>)(lpVtbl[3]))((IDeskBarClient*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
        {
            return ((delegate* unmanaged<IDeskBarClient*, BOOL, int>)(lpVtbl[4]))((IDeskBarClient*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetDeskBarSite(IUnknown* punkSite)
        {
            return ((delegate* unmanaged<IDeskBarClient*, IUnknown*, int>)(lpVtbl[5]))((IDeskBarClient*)Unsafe.AsPointer(ref this), punkSite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetModeDBC([NativeTypeName("DWORD")] uint dwMode)
        {
            return ((delegate* unmanaged<IDeskBarClient*, uint, int>)(lpVtbl[6]))((IDeskBarClient*)Unsafe.AsPointer(ref this), dwMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT UIActivateDBC([NativeTypeName("DWORD")] uint dwState)
        {
            return ((delegate* unmanaged<IDeskBarClient*, uint, int>)(lpVtbl[7]))((IDeskBarClient*)Unsafe.AsPointer(ref this), dwState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetSize([NativeTypeName("DWORD")] uint dwWhich, [NativeTypeName("LPRECT")] RECT* prc)
        {
            return ((delegate* unmanaged<IDeskBarClient*, uint, RECT*, int>)(lpVtbl[8]))((IDeskBarClient*)Unsafe.AsPointer(ref this), dwWhich, prc);
        }

        public interface Interface : IOleWindow.Interface
        {
            [VtblIndex(5)]
            HRESULT SetDeskBarSite(IUnknown* punkSite);

            [VtblIndex(6)]
            HRESULT SetModeDBC([NativeTypeName("DWORD")] uint dwMode);

            [VtblIndex(7)]
            HRESULT UIActivateDBC([NativeTypeName("DWORD")] uint dwState);

            [VtblIndex(8)]
            HRESULT GetSize([NativeTypeName("DWORD")] uint dwWhich, [NativeTypeName("LPRECT")] RECT* prc);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDeskBarClient*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDeskBarClient*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDeskBarClient*, uint> Release;

            [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDeskBarClient*, HWND*, int> GetWindow;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IDeskBarClient*, BOOL, int> ContextSensitiveHelp;

            [NativeTypeName("HRESULT (IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDeskBarClient*, IUnknown*, int> SetDeskBarSite;

            [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDeskBarClient*, uint, int> SetModeDBC;

            [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDeskBarClient*, uint, int> UIActivateDBC;

            [NativeTypeName("HRESULT (DWORD, LPRECT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDeskBarClient*, uint, RECT*, int> GetSize;
        }
    }
}
