// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[Guid("2CF5C4FD-E54C-4EA5-BA4E-F8C4B105A8C8")]
[NativeTypeName("struct IAppxPackageWriter2 : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IAppxPackageWriter2 : IAppxPackageWriter2.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxPackageWriter2*, Guid*, void**, int>)(lpVtbl[0]))((IAppxPackageWriter2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxPackageWriter2*, uint>)(lpVtbl[1]))((IAppxPackageWriter2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxPackageWriter2*, uint>)(lpVtbl[2]))((IAppxPackageWriter2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Close(IStream* manifest, IStream* contentGroupMap)
    {
        return ((delegate* unmanaged<IAppxPackageWriter2*, IStream*, IStream*, int>)(lpVtbl[3]))((IAppxPackageWriter2*)Unsafe.AsPointer(ref this), manifest, contentGroupMap);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Close(IStream* manifest, IStream* contentGroupMap);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxPackageWriter2*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxPackageWriter2*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxPackageWriter2*, uint> Release;

        [NativeTypeName("HRESULT (IStream *, IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxPackageWriter2*, IStream*, IStream*, int> Close;
    }
}
