// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[Guid("A2F05A09-27A2-42B5-BC0E-AC163EF49D9B")]
[NativeTypeName("struct IApartmentShutdown : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows8.0")]
public unsafe partial struct IApartmentShutdown : IApartmentShutdown.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IApartmentShutdown*, Guid*, void**, int>)(lpVtbl[0]))((IApartmentShutdown*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IApartmentShutdown*, uint>)(lpVtbl[1]))((IApartmentShutdown*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IApartmentShutdown*, uint>)(lpVtbl[2]))((IApartmentShutdown*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void OnUninitialize([NativeTypeName("UINT64")] ulong ui64ApartmentIdentifier)
    {
        ((delegate* unmanaged<IApartmentShutdown*, ulong, void>)(lpVtbl[3]))((IApartmentShutdown*)Unsafe.AsPointer(ref this), ui64ApartmentIdentifier);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void OnUninitialize([NativeTypeName("UINT64")] ulong ui64ApartmentIdentifier);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IApartmentShutdown*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IApartmentShutdown*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IApartmentShutdown*, uint> Release;

        [NativeTypeName("void (UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<IApartmentShutdown*, ulong, void> OnUninitialize;
    }
}
