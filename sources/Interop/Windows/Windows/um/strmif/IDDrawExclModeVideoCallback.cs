// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='IDDrawExclModeVideoCallback.xml' path='doc/member[@name="IDDrawExclModeVideoCallback"]/*' />
[Guid("913C24A0-20AB-11D2-9038-00A0C9697298")]
[NativeTypeName("struct IDDrawExclModeVideoCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDDrawExclModeVideoCallback : IDDrawExclModeVideoCallback.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDDrawExclModeVideoCallback*, Guid*, void**, int>)(lpVtbl[0]))((IDDrawExclModeVideoCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDDrawExclModeVideoCallback*, uint>)(lpVtbl[1]))((IDDrawExclModeVideoCallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDDrawExclModeVideoCallback*, uint>)(lpVtbl[2]))((IDDrawExclModeVideoCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDDrawExclModeVideoCallback.xml' path='doc/member[@name="IDDrawExclModeVideoCallback.OnUpdateOverlay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnUpdateOverlay(BOOL bBefore, [NativeTypeName("DWORD")] uint dwFlags, BOOL bOldVisible, [NativeTypeName("const RECT *")] RECT* prcOldSrc, [NativeTypeName("const RECT *")] RECT* prcOldDest, BOOL bNewVisible, [NativeTypeName("const RECT *")] RECT* prcNewSrc, [NativeTypeName("const RECT *")] RECT* prcNewDest)
    {
        return ((delegate* unmanaged<IDDrawExclModeVideoCallback*, BOOL, uint, BOOL, RECT*, RECT*, BOOL, RECT*, RECT*, int>)(lpVtbl[3]))((IDDrawExclModeVideoCallback*)Unsafe.AsPointer(ref this), bBefore, dwFlags, bOldVisible, prcOldSrc, prcOldDest, bNewVisible, prcNewSrc, prcNewDest);
    }

    /// <include file='IDDrawExclModeVideoCallback.xml' path='doc/member[@name="IDDrawExclModeVideoCallback.OnUpdateColorKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnUpdateColorKey([NativeTypeName("const COLORKEY *")] COLORKEY* pKey, [NativeTypeName("DWORD")] uint dwColor)
    {
        return ((delegate* unmanaged<IDDrawExclModeVideoCallback*, COLORKEY*, uint, int>)(lpVtbl[4]))((IDDrawExclModeVideoCallback*)Unsafe.AsPointer(ref this), pKey, dwColor);
    }

    /// <include file='IDDrawExclModeVideoCallback.xml' path='doc/member[@name="IDDrawExclModeVideoCallback.OnUpdateSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnUpdateSize([NativeTypeName("DWORD")] uint dwWidth, [NativeTypeName("DWORD")] uint dwHeight, [NativeTypeName("DWORD")] uint dwARWidth, [NativeTypeName("DWORD")] uint dwARHeight)
    {
        return ((delegate* unmanaged<IDDrawExclModeVideoCallback*, uint, uint, uint, uint, int>)(lpVtbl[5]))((IDDrawExclModeVideoCallback*)Unsafe.AsPointer(ref this), dwWidth, dwHeight, dwARWidth, dwARHeight);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnUpdateOverlay(BOOL bBefore, [NativeTypeName("DWORD")] uint dwFlags, BOOL bOldVisible, [NativeTypeName("const RECT *")] RECT* prcOldSrc, [NativeTypeName("const RECT *")] RECT* prcOldDest, BOOL bNewVisible, [NativeTypeName("const RECT *")] RECT* prcNewSrc, [NativeTypeName("const RECT *")] RECT* prcNewDest);

        [VtblIndex(4)]
        HRESULT OnUpdateColorKey([NativeTypeName("const COLORKEY *")] COLORKEY* pKey, [NativeTypeName("DWORD")] uint dwColor);

        [VtblIndex(5)]
        HRESULT OnUpdateSize([NativeTypeName("DWORD")] uint dwWidth, [NativeTypeName("DWORD")] uint dwHeight, [NativeTypeName("DWORD")] uint dwARWidth, [NativeTypeName("DWORD")] uint dwARHeight);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (BOOL, DWORD, BOOL, const RECT *, const RECT *, BOOL, const RECT *, const RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, uint, BOOL, RECT*, RECT*, BOOL, RECT*, RECT*, int> OnUpdateOverlay;

        [NativeTypeName("HRESULT (const COLORKEY *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, COLORKEY*, uint, int> OnUpdateColorKey;

        [NativeTypeName("HRESULT (DWORD, DWORD, DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, uint, int> OnUpdateSize;
    }
}
