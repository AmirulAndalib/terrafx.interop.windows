// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("7F73BE3F-FB79-493C-A6C7-7EE14E245841")]
[NativeTypeName("struct IInitializeWithItem : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IInitializeWithItem : IInitializeWithItem.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInitializeWithItem*, Guid*, void**, int>)(lpVtbl[0]))((IInitializeWithItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IInitializeWithItem*, uint>)(lpVtbl[1]))((IInitializeWithItem*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInitializeWithItem*, uint>)(lpVtbl[2]))((IInitializeWithItem*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(IShellItem* psi, [NativeTypeName("DWORD")] uint grfMode)
    {
        return ((delegate* unmanaged<IInitializeWithItem*, IShellItem*, uint, int>)(lpVtbl[3]))((IInitializeWithItem*)Unsafe.AsPointer(ref this), psi, grfMode);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize(IShellItem* psi, [NativeTypeName("DWORD")] uint grfMode);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IInitializeWithItem*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IInitializeWithItem*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IInitializeWithItem*, uint> Release;

        [NativeTypeName("HRESULT (IShellItem *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<IInitializeWithItem*, IShellItem*, uint, int> Initialize;
    }
}
