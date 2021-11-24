// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[Guid("4D645ACE-26AA-4688-9BE1-DF3516990B93")]
[NativeTypeName("struct IMFMediaEngineClassFactory : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows8.0")]
public unsafe partial struct IMFMediaEngineClassFactory : IMFMediaEngineClassFactory.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactory*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineClassFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactory*, uint>)(lpVtbl[1]))((IMFMediaEngineClassFactory*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactory*, uint>)(lpVtbl[2]))((IMFMediaEngineClassFactory*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateInstance([NativeTypeName("DWORD")] uint dwFlags, IMFAttributes* pAttr, IMFMediaEngine** ppPlayer)
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactory*, uint, IMFAttributes*, IMFMediaEngine**, int>)(lpVtbl[3]))((IMFMediaEngineClassFactory*)Unsafe.AsPointer(ref this), dwFlags, pAttr, ppPlayer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateTimeRange(IMFMediaTimeRange** ppTimeRange)
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactory*, IMFMediaTimeRange**, int>)(lpVtbl[4]))((IMFMediaEngineClassFactory*)Unsafe.AsPointer(ref this), ppTimeRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateError(IMFMediaError** ppError)
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactory*, IMFMediaError**, int>)(lpVtbl[5]))((IMFMediaEngineClassFactory*)Unsafe.AsPointer(ref this), ppError);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateInstance([NativeTypeName("DWORD")] uint dwFlags, IMFAttributes* pAttr, IMFMediaEngine** ppPlayer);

        [VtblIndex(4)]
        HRESULT CreateTimeRange(IMFMediaTimeRange** ppTimeRange);

        [VtblIndex(5)]
        HRESULT CreateError(IMFMediaError** ppError);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaEngineClassFactory*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaEngineClassFactory*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaEngineClassFactory*, uint> Release;

        [NativeTypeName("HRESULT (DWORD, IMFAttributes *, IMFMediaEngine **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaEngineClassFactory*, uint, IMFAttributes*, IMFMediaEngine**, int> CreateInstance;

        [NativeTypeName("HRESULT (IMFMediaTimeRange **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaEngineClassFactory*, IMFMediaTimeRange**, int> CreateTimeRange;

        [NativeTypeName("HRESULT (IMFMediaError **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaEngineClassFactory*, IMFMediaError**, int> CreateError;
    }
}
