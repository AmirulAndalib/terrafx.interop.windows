// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[Guid("72A22D78-CDE4-431D-B8CC-843A71199B6D")]
[NativeTypeName("struct IActivateAudioInterfaceAsyncOperation : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows8.0")]
public unsafe partial struct IActivateAudioInterfaceAsyncOperation : IActivateAudioInterfaceAsyncOperation.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IActivateAudioInterfaceAsyncOperation*, Guid*, void**, int>)(lpVtbl[0]))((IActivateAudioInterfaceAsyncOperation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IActivateAudioInterfaceAsyncOperation*, uint>)(lpVtbl[1]))((IActivateAudioInterfaceAsyncOperation*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IActivateAudioInterfaceAsyncOperation*, uint>)(lpVtbl[2]))((IActivateAudioInterfaceAsyncOperation*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetActivateResult(HRESULT* activateResult, IUnknown** activatedInterface)
    {
        return ((delegate* unmanaged<IActivateAudioInterfaceAsyncOperation*, HRESULT*, IUnknown**, int>)(lpVtbl[3]))((IActivateAudioInterfaceAsyncOperation*)Unsafe.AsPointer(ref this), activateResult, activatedInterface);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetActivateResult(HRESULT* activateResult, IUnknown** activatedInterface);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IActivateAudioInterfaceAsyncOperation*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IActivateAudioInterfaceAsyncOperation*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IActivateAudioInterfaceAsyncOperation*, uint> Release;

        [NativeTypeName("HRESULT (HRESULT *, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<IActivateAudioInterfaceAsyncOperation*, HRESULT*, IUnknown**, int> GetActivateResult;
    }
}
