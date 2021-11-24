// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

[Guid("53DD9855-A3B0-4D5B-82E1-26E25C5E5797")]
[NativeTypeName("struct ID2D1LookupTable3D : ID2D1Resource")]
[NativeInheritance("ID2D1Resource")]
public unsafe partial struct ID2D1LookupTable3D : ID2D1LookupTable3D.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1LookupTable3D*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1LookupTable3D*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1LookupTable3D*, uint>)(lpVtbl[1]))((ID2D1LookupTable3D*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1LookupTable3D*, uint>)(lpVtbl[2]))((ID2D1LookupTable3D*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory** factory)
    {
        ((delegate* unmanaged<ID2D1LookupTable3D*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1LookupTable3D*)Unsafe.AsPointer(ref this), factory);
    }

    public interface Interface : ID2D1Resource.Interface
    {
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1LookupTable3D*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1LookupTable3D*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1LookupTable3D*, uint> Release;

        [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1LookupTable3D*, ID2D1Factory**, void> GetFactory;
    }
}
