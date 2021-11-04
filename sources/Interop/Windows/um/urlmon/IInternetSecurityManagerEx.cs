// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F164EDF1-CC7C-4F0D-9A94-34222625C393")]
    [NativeTypeName("struct IInternetSecurityManagerEx : IInternetSecurityManager")]
    [NativeInheritance("IInternetSecurityManager")]
    public unsafe partial struct IInternetSecurityManagerEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInternetSecurityManagerEx*, Guid*, void**, int>)(lpVtbl[0]))((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInternetSecurityManagerEx*, uint>)(lpVtbl[1]))((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInternetSecurityManagerEx*, uint>)(lpVtbl[2]))((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetSecuritySite(IInternetSecurityMgrSite* pSite)
        {
            return ((delegate* unmanaged<IInternetSecurityManagerEx*, IInternetSecurityMgrSite*, int>)(lpVtbl[3]))((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), pSite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetSecuritySite(IInternetSecurityMgrSite** ppSite)
        {
            return ((delegate* unmanaged<IInternetSecurityManagerEx*, IInternetSecurityMgrSite**, int>)(lpVtbl[4]))((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), ppSite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT MapUrlToZone([NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("DWORD *")] uint* pdwZone, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IInternetSecurityManagerEx*, ushort*, uint*, uint, int>)(lpVtbl[5]))((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), pwszUrl, pdwZone, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetSecurityId([NativeTypeName("LPCWSTR")] ushort* pwszUrl, byte* pbSecurityId, [NativeTypeName("DWORD *")] uint* pcbSecurityId, [NativeTypeName("DWORD_PTR")] nuint dwReserved)
        {
            return ((delegate* unmanaged<IInternetSecurityManagerEx*, ushort*, byte*, uint*, nuint, int>)(lpVtbl[6]))((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), pwszUrl, pbSecurityId, pcbSecurityId, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT ProcessUrlAction([NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<IInternetSecurityManagerEx*, ushort*, uint, byte*, uint, byte*, uint, uint, uint, int>)(lpVtbl[7]))((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), pwszUrl, dwAction, pPolicy, cbPolicy, pContext, cbContext, dwFlags, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT QueryCustomPolicy([NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("const GUID &")] Guid* guidKey, byte** ppPolicy, [NativeTypeName("DWORD *")] uint* pcbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<IInternetSecurityManagerEx*, ushort*, Guid*, byte**, uint*, byte*, uint, uint, int>)(lpVtbl[8]))((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), pwszUrl, guidKey, ppPolicy, pcbPolicy, pContext, cbContext, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetZoneMapping([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("LPCWSTR")] ushort* lpszPattern, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IInternetSecurityManagerEx*, uint, ushort*, uint, int>)(lpVtbl[9]))((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), dwZone, lpszPattern, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetZoneMappings([NativeTypeName("DWORD")] uint dwZone, IEnumString** ppenumString, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IInternetSecurityManagerEx*, uint, IEnumString**, uint, int>)(lpVtbl[10]))((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), dwZone, ppenumString, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT ProcessUrlActionEx([NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD *")] uint* pdwOutFlags)
        {
            return ((delegate* unmanaged<IInternetSecurityManagerEx*, ushort*, uint, byte*, uint, byte*, uint, uint, uint, uint*, int>)(lpVtbl[11]))((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), pwszUrl, dwAction, pPolicy, cbPolicy, pContext, cbContext, dwFlags, dwReserved, pdwOutFlags);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetSecurityManagerEx*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetSecurityManagerEx*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetSecurityManagerEx*, uint> Release;

            [NativeTypeName("HRESULT (IInternetSecurityMgrSite *) __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetSecurityManagerEx*, IInternetSecurityMgrSite*, int> SetSecuritySite;

            [NativeTypeName("HRESULT (IInternetSecurityMgrSite **) __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetSecurityManagerEx*, IInternetSecurityMgrSite**, int> GetSecuritySite;

            [NativeTypeName("HRESULT (LPCWSTR, DWORD *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetSecurityManagerEx*, ushort*, uint*, uint, int> MapUrlToZone;

            [NativeTypeName("HRESULT (LPCWSTR, BYTE *, DWORD *, DWORD_PTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetSecurityManagerEx*, ushort*, byte*, uint*, nuint, int> GetSecurityId;

            [NativeTypeName("HRESULT (LPCWSTR, DWORD, BYTE *, DWORD, BYTE *, DWORD, DWORD, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetSecurityManagerEx*, ushort*, uint, byte*, uint, byte*, uint, uint, uint, int> ProcessUrlAction;

            [NativeTypeName("HRESULT (LPCWSTR, const GUID &, BYTE **, DWORD *, BYTE *, DWORD, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetSecurityManagerEx*, ushort*, Guid*, byte**, uint*, byte*, uint, uint, int> QueryCustomPolicy;

            [NativeTypeName("HRESULT (DWORD, LPCWSTR, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetSecurityManagerEx*, uint, ushort*, uint, int> SetZoneMapping;

            [NativeTypeName("HRESULT (DWORD, IEnumString **, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetSecurityManagerEx*, uint, IEnumString**, uint, int> GetZoneMappings;

            [NativeTypeName("HRESULT (LPCWSTR, DWORD, BYTE *, DWORD, BYTE *, DWORD, DWORD, DWORD, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetSecurityManagerEx*, ushort*, uint, byte*, uint, byte*, uint, uint, uint, uint*, int> ProcessUrlActionEx;
        }
    }
}
