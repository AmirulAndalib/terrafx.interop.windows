// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IShellExtInit.xml' path='doc/member[@name="IShellExtInit"]/*' />
[Guid("000214E8-0000-0000-C000-000000000046")]
[NativeTypeName("struct IShellExtInit : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IShellExtInit : IShellExtInit.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellExtInit));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellExtInit*, Guid*, void**, int>)(lpVtbl[0]))((IShellExtInit*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellExtInit*, uint>)(lpVtbl[1]))((IShellExtInit*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellExtInit*, uint>)(lpVtbl[2]))((IShellExtInit*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellExtInit.xml' path='doc/member[@name="IShellExtInit.Initialize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder, IDataObject* pdtobj, HKEY hkeyProgID)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellExtInit*, ITEMIDLIST*, IDataObject*, HKEY, int>)(lpVtbl[3]))((IShellExtInit*)Unsafe.AsPointer(ref this), pidlFolder, pdtobj, hkeyProgID);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder, IDataObject* pdtobj, HKEY hkeyProgID);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (LPCITEMIDLIST, IDataObject *, HKEY) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITEMIDLIST*, IDataObject*, HKEY, int> Initialize;
    }
}
