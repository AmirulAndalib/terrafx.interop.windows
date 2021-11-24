// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[Guid("7EC4B1BD-43FB-4763-85D2-64FCB5C5F4CB")]
[NativeTypeName("struct IMFContentDecryptorContext : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IMFContentDecryptorContext : IMFContentDecryptorContext.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFContentDecryptorContext*, Guid*, void**, int>)(lpVtbl[0]))((IMFContentDecryptorContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFContentDecryptorContext*, uint>)(lpVtbl[1]))((IMFContentDecryptorContext*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFContentDecryptorContext*, uint>)(lpVtbl[2]))((IMFContentDecryptorContext*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT InitializeHardwareKey(uint InputPrivateDataByteCount, [NativeTypeName("const void *")] void* InputPrivateData, [NativeTypeName("UINT64 *")] ulong* OutputPrivateData)
    {
        return ((delegate* unmanaged<IMFContentDecryptorContext*, uint, void*, ulong*, int>)(lpVtbl[3]))((IMFContentDecryptorContext*)Unsafe.AsPointer(ref this), InputPrivateDataByteCount, InputPrivateData, OutputPrivateData);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT InitializeHardwareKey(uint InputPrivateDataByteCount, [NativeTypeName("const void *")] void* InputPrivateData, [NativeTypeName("UINT64 *")] ulong* OutputPrivateData);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFContentDecryptorContext*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFContentDecryptorContext*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFContentDecryptorContext*, uint> Release;

        [NativeTypeName("HRESULT (UINT, const void *, UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFContentDecryptorContext*, uint, void*, ulong*, int> InitializeHardwareKey;
    }
}
