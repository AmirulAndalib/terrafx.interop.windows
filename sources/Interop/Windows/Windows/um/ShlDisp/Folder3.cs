// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='Folder3.xml' path='doc/member[@name="Folder3"]/*' />
[Guid("A7AE5F64-C4D7-4D7F-9307-4D24EE54B841")]
[NativeTypeName("struct Folder3 : Folder2")]
[NativeInheritance("Folder2")]
public unsafe partial struct Folder3 : Folder3.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<Folder3*, Guid*, void**, int>)(lpVtbl[0]))((Folder3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<Folder3*, uint>)(lpVtbl[1]))((Folder3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<Folder3*, uint>)(lpVtbl[2]))((Folder3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<Folder3*, uint*, int>)(lpVtbl[3]))((Folder3*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<Folder3*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((Folder3*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<Folder3*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((Folder3*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<Folder3*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((Folder3*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <inheritdoc cref="Folder.get_Title" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Title([NativeTypeName("BSTR *")] ushort** pbs)
    {
        return ((delegate* unmanaged<Folder3*, ushort**, int>)(lpVtbl[7]))((Folder3*)Unsafe.AsPointer(ref this), pbs);
    }

    /// <inheritdoc cref="Folder.get_Application" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Application(IDispatch** ppid)
    {
        return ((delegate* unmanaged<Folder3*, IDispatch**, int>)(lpVtbl[8]))((Folder3*)Unsafe.AsPointer(ref this), ppid);
    }

    /// <inheritdoc cref="Folder.get_Parent" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Parent(IDispatch** ppid)
    {
        return ((delegate* unmanaged<Folder3*, IDispatch**, int>)(lpVtbl[9]))((Folder3*)Unsafe.AsPointer(ref this), ppid);
    }

    /// <inheritdoc cref="Folder.get_ParentFolder" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ParentFolder(Folder** ppsf)
    {
        return ((delegate* unmanaged<Folder3*, Folder**, int>)(lpVtbl[10]))((Folder3*)Unsafe.AsPointer(ref this), ppsf);
    }

    /// <inheritdoc cref="Folder.Items" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Items(FolderItems** ppid)
    {
        return ((delegate* unmanaged<Folder3*, FolderItems**, int>)(lpVtbl[11]))((Folder3*)Unsafe.AsPointer(ref this), ppid);
    }

    /// <inheritdoc cref="Folder.ParseName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ParseName([NativeTypeName("BSTR")] ushort* bName, FolderItem** ppid)
    {
        return ((delegate* unmanaged<Folder3*, ushort*, FolderItem**, int>)(lpVtbl[12]))((Folder3*)Unsafe.AsPointer(ref this), bName, ppid);
    }

    /// <inheritdoc cref="Folder.NewFolder" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT NewFolder([NativeTypeName("BSTR")] ushort* bName, VARIANT vOptions)
    {
        return ((delegate* unmanaged<Folder3*, ushort*, VARIANT, int>)(lpVtbl[13]))((Folder3*)Unsafe.AsPointer(ref this), bName, vOptions);
    }

    /// <inheritdoc cref="Folder.MoveHere" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT MoveHere(VARIANT vItem, VARIANT vOptions)
    {
        return ((delegate* unmanaged<Folder3*, VARIANT, VARIANT, int>)(lpVtbl[14]))((Folder3*)Unsafe.AsPointer(ref this), vItem, vOptions);
    }

    /// <inheritdoc cref="Folder.CopyHere" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CopyHere(VARIANT vItem, VARIANT vOptions)
    {
        return ((delegate* unmanaged<Folder3*, VARIANT, VARIANT, int>)(lpVtbl[15]))((Folder3*)Unsafe.AsPointer(ref this), vItem, vOptions);
    }

    /// <inheritdoc cref="Folder.GetDetailsOf" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetDetailsOf(VARIANT vItem, int iColumn, [NativeTypeName("BSTR *")] ushort** pbs)
    {
        return ((delegate* unmanaged<Folder3*, VARIANT, int, ushort**, int>)(lpVtbl[16]))((Folder3*)Unsafe.AsPointer(ref this), vItem, iColumn, pbs);
    }

    /// <inheritdoc cref="Folder2.get_Self" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_Self(FolderItem** ppfi)
    {
        return ((delegate* unmanaged<Folder3*, FolderItem**, int>)(lpVtbl[17]))((Folder3*)Unsafe.AsPointer(ref this), ppfi);
    }

    /// <inheritdoc cref="Folder2.get_OfflineStatus" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_OfflineStatus([NativeTypeName("LONG *")] int* pul)
    {
        return ((delegate* unmanaged<Folder3*, int*, int>)(lpVtbl[18]))((Folder3*)Unsafe.AsPointer(ref this), pul);
    }

    /// <inheritdoc cref="Folder2.Synchronize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT Synchronize()
    {
        return ((delegate* unmanaged<Folder3*, int>)(lpVtbl[19]))((Folder3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="Folder2.get_HaveToShowWebViewBarricade" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_HaveToShowWebViewBarricade([NativeTypeName("VARIANT_BOOL *")] short* pbHaveToShowWebViewBarricade)
    {
        return ((delegate* unmanaged<Folder3*, short*, int>)(lpVtbl[20]))((Folder3*)Unsafe.AsPointer(ref this), pbHaveToShowWebViewBarricade);
    }

    /// <inheritdoc cref="Folder2.DismissedWebViewBarricade" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT DismissedWebViewBarricade()
    {
        return ((delegate* unmanaged<Folder3*, int>)(lpVtbl[21]))((Folder3*)Unsafe.AsPointer(ref this));
    }

    /// <include file='Folder3.xml' path='doc/member[@name="Folder3.get_ShowWebViewBarricade"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_ShowWebViewBarricade([NativeTypeName("VARIANT_BOOL *")] short* pbShowWebViewBarricade)
    {
        return ((delegate* unmanaged<Folder3*, short*, int>)(lpVtbl[22]))((Folder3*)Unsafe.AsPointer(ref this), pbShowWebViewBarricade);
    }

    /// <include file='Folder3.xml' path='doc/member[@name="Folder3.put_ShowWebViewBarricade"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_ShowWebViewBarricade([NativeTypeName("VARIANT_BOOL")] short bShowWebViewBarricade)
    {
        return ((delegate* unmanaged<Folder3*, short, int>)(lpVtbl[23]))((Folder3*)Unsafe.AsPointer(ref this), bShowWebViewBarricade);
    }

    public interface Interface : Folder2.Interface
    {
        [VtblIndex(22)]
        HRESULT get_ShowWebViewBarricade([NativeTypeName("VARIANT_BOOL *")] short* pbShowWebViewBarricade);

        [VtblIndex(23)]
        HRESULT put_ShowWebViewBarricade([NativeTypeName("VARIANT_BOOL")] short bShowWebViewBarricade);
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Title;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_Application;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_Parent;

        [NativeTypeName("HRESULT (Folder **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Folder**, int> get_ParentFolder;

        [NativeTypeName("HRESULT (FolderItems **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FolderItems**, int> Items;

        [NativeTypeName("HRESULT (BSTR, FolderItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, FolderItem**, int> ParseName;

        [NativeTypeName("HRESULT (BSTR, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT, int> NewFolder;

        [NativeTypeName("HRESULT (VARIANT, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, VARIANT, int> MoveHere;

        [NativeTypeName("HRESULT (VARIANT, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, VARIANT, int> CopyHere;

        [NativeTypeName("HRESULT (VARIANT, int, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int, ushort**, int> GetDetailsOf;

        [NativeTypeName("HRESULT (FolderItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FolderItem**, int> get_Self;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_OfflineStatus;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Synchronize;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_HaveToShowWebViewBarricade;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DismissedWebViewBarricade;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_ShowWebViewBarricade;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_ShowWebViewBarricade;
    }
}
