// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("542612C4-A1B8-4632-B521-DE11EA64A0B0")]
[NativeTypeName("struct IMFTrustedInput : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFTrustedInput : IMFTrustedInput.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFTrustedInput*, Guid*, void**, int>)(lpVtbl[0]))((IMFTrustedInput*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFTrustedInput*, uint>)(lpVtbl[1]))((IMFTrustedInput*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFTrustedInput*, uint>)(lpVtbl[2]))((IMFTrustedInput*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetInputTrustAuthority([NativeTypeName("DWORD")] uint dwStreamID, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunkObject)
    {
        return ((delegate* unmanaged<IMFTrustedInput*, uint, Guid*, IUnknown**, int>)(lpVtbl[3]))((IMFTrustedInput*)Unsafe.AsPointer(ref this), dwStreamID, riid, ppunkObject);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetInputTrustAuthority([NativeTypeName("DWORD")] uint dwStreamID, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunkObject);
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

        [NativeTypeName("HRESULT (DWORD, const IID &, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, IUnknown**, int> GetInputTrustAuthority;
    }
}
