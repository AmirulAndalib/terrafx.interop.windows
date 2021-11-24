// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("19188CB0-ACA9-11D2-AFC5-00105A2799B5")]
[NativeTypeName("struct IEnumTfProperties : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumTfProperties : IEnumTfProperties.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumTfProperties*, Guid*, void**, int>)(lpVtbl[0]))((IEnumTfProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumTfProperties*, uint>)(lpVtbl[1]))((IEnumTfProperties*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumTfProperties*, uint>)(lpVtbl[2]))((IEnumTfProperties*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Clone(IEnumTfProperties** ppEnum)
    {
        return ((delegate* unmanaged<IEnumTfProperties*, IEnumTfProperties**, int>)(lpVtbl[3]))((IEnumTfProperties*)Unsafe.AsPointer(ref this), ppEnum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Next([NativeTypeName("ULONG")] uint ulCount, ITfProperty** ppProp, [NativeTypeName("ULONG *")] uint* pcFetched)
    {
        return ((delegate* unmanaged<IEnumTfProperties*, uint, ITfProperty**, uint*, int>)(lpVtbl[4]))((IEnumTfProperties*)Unsafe.AsPointer(ref this), ulCount, ppProp, pcFetched);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumTfProperties*, int>)(lpVtbl[5]))((IEnumTfProperties*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint ulCount)
    {
        return ((delegate* unmanaged<IEnumTfProperties*, uint, int>)(lpVtbl[6]))((IEnumTfProperties*)Unsafe.AsPointer(ref this), ulCount);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Clone(IEnumTfProperties** ppEnum);

        [VtblIndex(4)]
        HRESULT Next([NativeTypeName("ULONG")] uint ulCount, ITfProperty** ppProp, [NativeTypeName("ULONG *")] uint* pcFetched);

        [VtblIndex(5)]
        HRESULT Reset();

        [VtblIndex(6)]
        HRESULT Skip([NativeTypeName("ULONG")] uint ulCount);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumTfProperties*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumTfProperties*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumTfProperties*, uint> Release;

        [NativeTypeName("HRESULT (IEnumTfProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumTfProperties*, IEnumTfProperties**, int> Clone;

        [NativeTypeName("HRESULT (ULONG, ITfProperty **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumTfProperties*, uint, ITfProperty**, uint*, int> Next;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumTfProperties*, int> Reset;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumTfProperties*, uint, int> Skip;
    }
}
