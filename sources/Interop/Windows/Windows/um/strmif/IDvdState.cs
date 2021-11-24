// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("86303D6D-1C4A-4087-AB42-F711167048EF")]
[NativeTypeName("struct IDvdState : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDvdState : IDvdState.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDvdState*, Guid*, void**, int>)(lpVtbl[0]))((IDvdState*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDvdState*, uint>)(lpVtbl[1]))((IDvdState*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDvdState*, uint>)(lpVtbl[2]))((IDvdState*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDiscID([NativeTypeName("ULONGLONG *")] ulong* pullUniqueID)
    {
        return ((delegate* unmanaged<IDvdState*, ulong*, int>)(lpVtbl[3]))((IDvdState*)Unsafe.AsPointer(ref this), pullUniqueID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetParentalLevel([NativeTypeName("ULONG *")] uint* pulParentalLevel)
    {
        return ((delegate* unmanaged<IDvdState*, uint*, int>)(lpVtbl[4]))((IDvdState*)Unsafe.AsPointer(ref this), pulParentalLevel);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDiscID([NativeTypeName("ULONGLONG *")] ulong* pullUniqueID);

        [VtblIndex(4)]
        HRESULT GetParentalLevel([NativeTypeName("ULONG *")] uint* pulParentalLevel);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDvdState*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDvdState*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDvdState*, uint> Release;

        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<IDvdState*, ulong*, int> GetDiscID;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<IDvdState*, uint*, int> GetParentalLevel;
    }
}
