// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("C1646BC4-F298-4F91-A204-EB2DD1709D1A")]
[NativeTypeName("struct IDesktopGadget : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDesktopGadget : IDesktopGadget.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDesktopGadget*, Guid*, void**, int>)(lpVtbl[0]))((IDesktopGadget*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDesktopGadget*, uint>)(lpVtbl[1]))((IDesktopGadget*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDesktopGadget*, uint>)(lpVtbl[2]))((IDesktopGadget*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RunGadget([NativeTypeName("LPCWSTR")] ushort* gadgetPath)
    {
        return ((delegate* unmanaged<IDesktopGadget*, ushort*, int>)(lpVtbl[3]))((IDesktopGadget*)Unsafe.AsPointer(ref this), gadgetPath);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RunGadget([NativeTypeName("LPCWSTR")] ushort* gadgetPath);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDesktopGadget*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDesktopGadget*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDesktopGadget*, uint> Release;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IDesktopGadget*, ushort*, int> RunGadget;
    }
}
