// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("79EAC9EB-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IInternetPriority : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IInternetPriority : IInternetPriority.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInternetPriority*, Guid*, void**, int>)(lpVtbl[0]))((IInternetPriority*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IInternetPriority*, uint>)(lpVtbl[1]))((IInternetPriority*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInternetPriority*, uint>)(lpVtbl[2]))((IInternetPriority*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPriority([NativeTypeName("LONG")] int nPriority)
    {
        return ((delegate* unmanaged<IInternetPriority*, int, int>)(lpVtbl[3]))((IInternetPriority*)Unsafe.AsPointer(ref this), nPriority);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPriority([NativeTypeName("LONG *")] int* pnPriority)
    {
        return ((delegate* unmanaged<IInternetPriority*, int*, int>)(lpVtbl[4]))((IInternetPriority*)Unsafe.AsPointer(ref this), pnPriority);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetPriority([NativeTypeName("LONG")] int nPriority);

        [VtblIndex(4)]
        HRESULT GetPriority([NativeTypeName("LONG *")] int* pnPriority);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IInternetPriority*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IInternetPriority*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IInternetPriority*, uint> Release;

        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<IInternetPriority*, int, int> SetPriority;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<IInternetPriority*, int*, int> GetPriority;
    }
}
