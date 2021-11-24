// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("1BE09788-6894-4089-8586-9A2A6C265AC5")]
[NativeTypeName("struct IMMEndpoint : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMMEndpoint : IMMEndpoint.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMMEndpoint*, Guid*, void**, int>)(lpVtbl[0]))((IMMEndpoint*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMMEndpoint*, uint>)(lpVtbl[1]))((IMMEndpoint*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMMEndpoint*, uint>)(lpVtbl[2]))((IMMEndpoint*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDataFlow(EDataFlow* pDataFlow)
    {
        return ((delegate* unmanaged<IMMEndpoint*, EDataFlow*, int>)(lpVtbl[3]))((IMMEndpoint*)Unsafe.AsPointer(ref this), pDataFlow);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDataFlow(EDataFlow* pDataFlow);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMMEndpoint*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMMEndpoint*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMMEndpoint*, uint> Release;

        [NativeTypeName("HRESULT (EDataFlow *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMMEndpoint*, EDataFlow*, int> GetDataFlow;
    }
}
