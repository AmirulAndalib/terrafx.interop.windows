// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("EDE80B5C-BAD6-4623-B537-65586C9F8DFD")]
[NativeTypeName("struct IVMRAspectRatioControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IVMRAspectRatioControl : IVMRAspectRatioControl.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVMRAspectRatioControl*, Guid*, void**, int>)(lpVtbl[0]))((IVMRAspectRatioControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IVMRAspectRatioControl*, uint>)(lpVtbl[1]))((IVMRAspectRatioControl*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVMRAspectRatioControl*, uint>)(lpVtbl[2]))((IVMRAspectRatioControl*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAspectRatioMode([NativeTypeName("LPDWORD")] uint* lpdwARMode)
    {
        return ((delegate* unmanaged<IVMRAspectRatioControl*, uint*, int>)(lpVtbl[3]))((IVMRAspectRatioControl*)Unsafe.AsPointer(ref this), lpdwARMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetAspectRatioMode([NativeTypeName("DWORD")] uint dwARMode)
    {
        return ((delegate* unmanaged<IVMRAspectRatioControl*, uint, int>)(lpVtbl[4]))((IVMRAspectRatioControl*)Unsafe.AsPointer(ref this), dwARMode);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetAspectRatioMode([NativeTypeName("LPDWORD")] uint* lpdwARMode);

        [VtblIndex(4)]
        HRESULT SetAspectRatioMode([NativeTypeName("DWORD")] uint dwARMode);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IVMRAspectRatioControl*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IVMRAspectRatioControl*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IVMRAspectRatioControl*, uint> Release;

        [NativeTypeName("HRESULT (LPDWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<IVMRAspectRatioControl*, uint*, int> GetAspectRatioMode;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<IVMRAspectRatioControl*, uint, int> SetAspectRatioMode;
    }
}
