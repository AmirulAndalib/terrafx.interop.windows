// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='IDocumentTraversal.xml' path='doc/member[@name="IDocumentTraversal"]/*' />
[Guid("30510744-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IDocumentTraversal : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IDocumentTraversal : IDocumentTraversal.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDocumentTraversal*, Guid*, void**, int>)(lpVtbl[0]))((IDocumentTraversal*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDocumentTraversal*, uint>)(lpVtbl[1]))((IDocumentTraversal*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDocumentTraversal*, uint>)(lpVtbl[2]))((IDocumentTraversal*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IDocumentTraversal*, uint*, int>)(lpVtbl[3]))((IDocumentTraversal*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IDocumentTraversal*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IDocumentTraversal*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IDocumentTraversal*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IDocumentTraversal*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IDocumentTraversal*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IDocumentTraversal*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IDocumentTraversal.xml' path='doc/member[@name="IDocumentTraversal.createNodeIterator"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT createNodeIterator(IDispatch* pRootNode, [NativeTypeName("long")] int ulWhatToShow, VARIANT* pFilter, [NativeTypeName("VARIANT_BOOL")] short fEntityReferenceExpansion, IDOMNodeIterator** ppNodeIterator)
    {
        return ((delegate* unmanaged<IDocumentTraversal*, IDispatch*, int, VARIANT*, short, IDOMNodeIterator**, int>)(lpVtbl[7]))((IDocumentTraversal*)Unsafe.AsPointer(ref this), pRootNode, ulWhatToShow, pFilter, fEntityReferenceExpansion, ppNodeIterator);
    }

    /// <include file='IDocumentTraversal.xml' path='doc/member[@name="IDocumentTraversal.createTreeWalker"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT createTreeWalker(IDispatch* pRootNode, [NativeTypeName("long")] int ulWhatToShow, VARIANT* pFilter, [NativeTypeName("VARIANT_BOOL")] short fEntityReferenceExpansion, IDOMTreeWalker** ppTreeWalker)
    {
        return ((delegate* unmanaged<IDocumentTraversal*, IDispatch*, int, VARIANT*, short, IDOMTreeWalker**, int>)(lpVtbl[8]))((IDocumentTraversal*)Unsafe.AsPointer(ref this), pRootNode, ulWhatToShow, pFilter, fEntityReferenceExpansion, ppTreeWalker);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT createNodeIterator(IDispatch* pRootNode, [NativeTypeName("long")] int ulWhatToShow, VARIANT* pFilter, [NativeTypeName("VARIANT_BOOL")] short fEntityReferenceExpansion, IDOMNodeIterator** ppNodeIterator);

        [VtblIndex(8)]
        HRESULT createTreeWalker(IDispatch* pRootNode, [NativeTypeName("long")] int ulWhatToShow, VARIANT* pFilter, [NativeTypeName("VARIANT_BOOL")] short fEntityReferenceExpansion, IDOMTreeWalker** ppTreeWalker);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (IDispatch *, long, VARIANT *, VARIANT_BOOL, IDOMNodeIterator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int, VARIANT*, short, IDOMNodeIterator**, int> createNodeIterator;

        [NativeTypeName("HRESULT (IDispatch *, long, VARIANT *, VARIANT_BOOL, IDOMTreeWalker **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int, VARIANT*, short, IDOMTreeWalker**, int> createTreeWalker;
    }
}
