// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ITransferDestination.xml' path='doc/member[@name="ITransferDestination"]/*' />
[Guid("48ADDD32-3CA5-4124-ABE3-B5A72531B207")]
[NativeTypeName("struct ITransferDestination : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITransferDestination : ITransferDestination.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITransferDestination));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferDestination*, Guid*, void**, int>)(lpVtbl[0]))((ITransferDestination*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferDestination*, uint>)(lpVtbl[1]))((ITransferDestination*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferDestination*, uint>)(lpVtbl[2]))((ITransferDestination*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITransferDestination.xml' path='doc/member[@name="ITransferDestination.Advise"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Advise(ITransferAdviseSink* psink, [NativeTypeName("DWORD *")] uint* pdwCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferDestination*, ITransferAdviseSink*, uint*, int>)(lpVtbl[3]))((ITransferDestination*)Unsafe.AsPointer(ref this), psink, pdwCookie);
    }

    /// <include file='ITransferDestination.xml' path='doc/member[@name="ITransferDestination.Unadvise"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferDestination*, uint, int>)(lpVtbl[4]))((ITransferDestination*)Unsafe.AsPointer(ref this), dwCookie);
    }

    /// <include file='ITransferDestination.xml' path='doc/member[@name="ITransferDestination.CreateItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateItem([NativeTypeName("LPCWSTR")] char* pszName, [NativeTypeName("DWORD")] uint dwAttributes, [NativeTypeName("ULONGLONG")] ulong ullSize, [NativeTypeName("TRANSFER_SOURCE_FLAGS")] uint flags, [NativeTypeName("const IID &")] Guid* riidItem, void** ppvItem, [NativeTypeName("const IID &")] Guid* riidResources, void** ppvResources)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferDestination*, char*, uint, ulong, uint, Guid*, void**, Guid*, void**, int>)(lpVtbl[5]))((ITransferDestination*)Unsafe.AsPointer(ref this), pszName, dwAttributes, ullSize, flags, riidItem, ppvItem, riidResources, ppvResources);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Advise(ITransferAdviseSink* psink, [NativeTypeName("DWORD *")] uint* pdwCookie);

        [VtblIndex(4)]
        HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie);

        [VtblIndex(5)]
        HRESULT CreateItem([NativeTypeName("LPCWSTR")] char* pszName, [NativeTypeName("DWORD")] uint dwAttributes, [NativeTypeName("ULONGLONG")] ulong ullSize, [NativeTypeName("TRANSFER_SOURCE_FLAGS")] uint flags, [NativeTypeName("const IID &")] Guid* riidItem, void** ppvItem, [NativeTypeName("const IID &")] Guid* riidResources, void** ppvResources);
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

        [NativeTypeName("HRESULT (ITransferAdviseSink *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITransferAdviseSink*, uint*, int> Advise;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> Unadvise;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD, ULONGLONG, TRANSFER_SOURCE_FLAGS, const IID &, void **, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, ulong, uint, Guid*, void**, Guid*, void**, int> CreateItem;
    }
}
