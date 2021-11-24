// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("3AF280B6-CB3F-11D0-891E-00C04FB6BFC4")]
[NativeTypeName("struct IInternetHostSecurityManager : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IInternetHostSecurityManager : IInternetHostSecurityManager.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInternetHostSecurityManager*, Guid*, void**, int>)(lpVtbl[0]))((IInternetHostSecurityManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IInternetHostSecurityManager*, uint>)(lpVtbl[1]))((IInternetHostSecurityManager*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInternetHostSecurityManager*, uint>)(lpVtbl[2]))((IInternetHostSecurityManager*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSecurityId(byte* pbSecurityId, [NativeTypeName("DWORD *")] uint* pcbSecurityId, [NativeTypeName("DWORD_PTR")] nuint dwReserved)
    {
        return ((delegate* unmanaged<IInternetHostSecurityManager*, byte*, uint*, nuint, int>)(lpVtbl[3]))((IInternetHostSecurityManager*)Unsafe.AsPointer(ref this), pbSecurityId, pcbSecurityId, dwReserved);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ProcessUrlAction([NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwReserved)
    {
        return ((delegate* unmanaged<IInternetHostSecurityManager*, uint, byte*, uint, byte*, uint, uint, uint, int>)(lpVtbl[4]))((IInternetHostSecurityManager*)Unsafe.AsPointer(ref this), dwAction, pPolicy, cbPolicy, pContext, cbContext, dwFlags, dwReserved);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT QueryCustomPolicy([NativeTypeName("const GUID &")] Guid* guidKey, byte** ppPolicy, [NativeTypeName("DWORD *")] uint* pcbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwReserved)
    {
        return ((delegate* unmanaged<IInternetHostSecurityManager*, Guid*, byte**, uint*, byte*, uint, uint, int>)(lpVtbl[5]))((IInternetHostSecurityManager*)Unsafe.AsPointer(ref this), guidKey, ppPolicy, pcbPolicy, pContext, cbContext, dwReserved);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetSecurityId(byte* pbSecurityId, [NativeTypeName("DWORD *")] uint* pcbSecurityId, [NativeTypeName("DWORD_PTR")] nuint dwReserved);

        [VtblIndex(4)]
        HRESULT ProcessUrlAction([NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwReserved);

        [VtblIndex(5)]
        HRESULT QueryCustomPolicy([NativeTypeName("const GUID &")] Guid* guidKey, byte** ppPolicy, [NativeTypeName("DWORD *")] uint* pcbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwReserved);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IInternetHostSecurityManager*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IInternetHostSecurityManager*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IInternetHostSecurityManager*, uint> Release;

        [NativeTypeName("HRESULT (BYTE *, DWORD *, DWORD_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IInternetHostSecurityManager*, byte*, uint*, nuint, int> GetSecurityId;

        [NativeTypeName("HRESULT (DWORD, BYTE *, DWORD, BYTE *, DWORD, DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<IInternetHostSecurityManager*, uint, byte*, uint, byte*, uint, uint, uint, int> ProcessUrlAction;

        [NativeTypeName("HRESULT (const GUID &, BYTE **, DWORD *, BYTE *, DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<IInternetHostSecurityManager*, Guid*, byte**, uint*, byte*, uint, uint, int> QueryCustomPolicy;
    }
}
