// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IElementNamespaceTable.xml' path='doc/member[@name="IElementNamespaceTable"]/*' />
[Guid("3050F670-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IElementNamespaceTable : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IElementNamespaceTable : IElementNamespaceTable.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IElementNamespaceTable));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IElementNamespaceTable*, Guid*, void**, int>)(lpVtbl[0]))((IElementNamespaceTable*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IElementNamespaceTable*, uint>)(lpVtbl[1]))((IElementNamespaceTable*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IElementNamespaceTable*, uint>)(lpVtbl[2]))((IElementNamespaceTable*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IElementNamespaceTable.xml' path='doc/member[@name="IElementNamespaceTable.AddNamespace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddNamespace([NativeTypeName("BSTR")] char* bstrNamespace, [NativeTypeName("BSTR")] char* bstrUrn, [NativeTypeName("LONG")] int lFlags, VARIANT* pvarFactory)
    {
        return ((delegate* unmanaged<IElementNamespaceTable*, char*, char*, int, VARIANT*, int>)(lpVtbl[3]))((IElementNamespaceTable*)Unsafe.AsPointer(ref this), bstrNamespace, bstrUrn, lFlags, pvarFactory);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddNamespace([NativeTypeName("BSTR")] char* bstrNamespace, [NativeTypeName("BSTR")] char* bstrUrn, [NativeTypeName("LONG")] int lFlags, VARIANT* pvarFactory);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (BSTR, BSTR, LONG, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, char*, char*, int, VARIANT*, int> AddNamespace;
    }
}
