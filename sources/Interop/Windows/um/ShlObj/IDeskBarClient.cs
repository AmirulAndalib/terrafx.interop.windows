// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EB0FE175-1A3A-11D0-89B3-00A0C90A90AC")]
    [NativeTypeName("struct IDeskBarClient : IOleWindow")]
    [NativeInheritance("IOleWindow")]
    public unsafe partial struct IDeskBarClient
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* unmanaged<IDeskBarClient*, IntPtr*, int>)(lpVtbl[3]))((IDeskBarClient*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int ContextSensitiveHelp([NativeTypeName("BOOL")] int fEnterMode)
        {
            return ((delegate* unmanaged<IDeskBarClient*, int, int>)(lpVtbl[4]))((IDeskBarClient*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetDeskBarSite(IUnknown* punkSite)
        {
            return ((delegate* unmanaged<IDeskBarClient*, IUnknown*, int>)(lpVtbl[5]))((IDeskBarClient*)Unsafe.AsPointer(ref this), punkSite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetModeDBC([NativeTypeName("DWORD")] uint dwMode)
        {
            return ((delegate* unmanaged<IDeskBarClient*, uint, int>)(lpVtbl[6]))((IDeskBarClient*)Unsafe.AsPointer(ref this), dwMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int UIActivateDBC([NativeTypeName("DWORD")] uint dwState)
        {
            return ((delegate* unmanaged<IDeskBarClient*, uint, int>)(lpVtbl[7]))((IDeskBarClient*)Unsafe.AsPointer(ref this), dwState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("DWORD")] uint dwWhich, [NativeTypeName("LPRECT")] RECT* prc)
        {
            return ((delegate* unmanaged<IDeskBarClient*, uint, RECT*, int>)(lpVtbl[8]))((IDeskBarClient*)Unsafe.AsPointer(ref this), dwWhich, prc);
        }
    }
}