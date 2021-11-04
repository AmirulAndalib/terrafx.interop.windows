// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/HLink.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9C2-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IHlinkSite : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IHlinkSite
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHlinkSite*, Guid*, void**, int>)(lpVtbl[0]))((IHlinkSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHlinkSite*, uint>)(lpVtbl[1]))((IHlinkSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHlinkSite*, uint>)(lpVtbl[2]))((IHlinkSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT QueryService([NativeTypeName("DWORD")] uint dwSiteData, [NativeTypeName("const GUID &")] Guid* guidService, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppiunk)
        {
            return ((delegate* unmanaged<IHlinkSite*, uint, Guid*, Guid*, IUnknown**, int>)(lpVtbl[3]))((IHlinkSite*)Unsafe.AsPointer(ref this), dwSiteData, guidService, riid, ppiunk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetMoniker([NativeTypeName("DWORD")] uint dwSiteData, [NativeTypeName("DWORD")] uint dwAssign, [NativeTypeName("DWORD")] uint dwWhich, IMoniker** ppimk)
        {
            return ((delegate* unmanaged<IHlinkSite*, uint, uint, uint, IMoniker**, int>)(lpVtbl[4]))((IHlinkSite*)Unsafe.AsPointer(ref this), dwSiteData, dwAssign, dwWhich, ppimk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT ReadyToNavigate([NativeTypeName("DWORD")] uint dwSiteData, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<IHlinkSite*, uint, uint, int>)(lpVtbl[5]))((IHlinkSite*)Unsafe.AsPointer(ref this), dwSiteData, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT OnNavigationComplete([NativeTypeName("DWORD")] uint dwSiteData, [NativeTypeName("DWORD")] uint dwreserved, HRESULT hrError, [NativeTypeName("LPCWSTR")] ushort* pwzError)
        {
            return ((delegate* unmanaged<IHlinkSite*, uint, uint, HRESULT, ushort*, int>)(lpVtbl[6]))((IHlinkSite*)Unsafe.AsPointer(ref this), dwSiteData, dwreserved, hrError, pwzError);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHlinkSite*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHlinkSite*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHlinkSite*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, const GUID &, const IID &, IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHlinkSite*, uint, Guid*, Guid*, IUnknown**, int> QueryService;

            [NativeTypeName("HRESULT (DWORD, DWORD, DWORD, IMoniker **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHlinkSite*, uint, uint, uint, IMoniker**, int> GetMoniker;

            [NativeTypeName("HRESULT (DWORD, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IHlinkSite*, uint, uint, int> ReadyToNavigate;

            [NativeTypeName("HRESULT (DWORD, DWORD, HRESULT, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHlinkSite*, uint, uint, HRESULT, ushort*, int> OnNavigationComplete;
        }
    }
}
