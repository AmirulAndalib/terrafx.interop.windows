// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IFilterMapper3.xml' path='doc/member[@name="IFilterMapper3"]/*' />
[Guid("B79BB0B1-33C1-11D1-ABE1-00A0C905F375")]
[NativeTypeName("struct IFilterMapper3 : IFilterMapper2")]
[NativeInheritance("IFilterMapper2")]
public unsafe partial struct IFilterMapper3 : IFilterMapper3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFilterMapper3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFilterMapper3*, Guid*, void**, int>)(lpVtbl[0]))((IFilterMapper3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFilterMapper3*, uint>)(lpVtbl[1]))((IFilterMapper3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFilterMapper3*, uint>)(lpVtbl[2]))((IFilterMapper3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IFilterMapper2.CreateCategory" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateCategory([NativeTypeName("const IID &")] Guid* clsidCategory, [NativeTypeName("DWORD")] uint dwCategoryMerit, [NativeTypeName("LPCWSTR")] char* Description)
    {
        return ((delegate* unmanaged[MemberFunction]<IFilterMapper3*, Guid*, uint, char*, int>)(lpVtbl[3]))((IFilterMapper3*)Unsafe.AsPointer(ref this), clsidCategory, dwCategoryMerit, Description);
    }

    /// <inheritdoc cref="IFilterMapper2.UnregisterFilter" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnregisterFilter([NativeTypeName("const CLSID *")] Guid* pclsidCategory, [NativeTypeName("LPCOLESTR")] char* szInstance, [NativeTypeName("const IID &")] Guid* Filter)
    {
        return ((delegate* unmanaged[MemberFunction]<IFilterMapper3*, Guid*, char*, Guid*, int>)(lpVtbl[4]))((IFilterMapper3*)Unsafe.AsPointer(ref this), pclsidCategory, szInstance, Filter);
    }

    /// <inheritdoc cref="IFilterMapper2.RegisterFilter" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RegisterFilter([NativeTypeName("const IID &")] Guid* clsidFilter, [NativeTypeName("LPCWSTR")] char* Name, IMoniker** ppMoniker, [NativeTypeName("const CLSID *")] Guid* pclsidCategory, [NativeTypeName("LPCOLESTR")] char* szInstance, [NativeTypeName("const REGFILTER2 *")] REGFILTER2* prf2)
    {
        return ((delegate* unmanaged[MemberFunction]<IFilterMapper3*, Guid*, char*, IMoniker**, Guid*, char*, REGFILTER2*, int>)(lpVtbl[5]))((IFilterMapper3*)Unsafe.AsPointer(ref this), clsidFilter, Name, ppMoniker, pclsidCategory, szInstance, prf2);
    }

    /// <inheritdoc cref="IFilterMapper2.EnumMatchingFilters" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EnumMatchingFilters(IEnumMoniker** ppEnum, [NativeTypeName("DWORD")] uint dwFlags, BOOL bExactMatch, [NativeTypeName("DWORD")] uint dwMerit, BOOL bInputNeeded, [NativeTypeName("DWORD")] uint cInputTypes, [NativeTypeName("const GUID *")] Guid* pInputTypes, [NativeTypeName("const REGPINMEDIUM *")] REGPINMEDIUM* pMedIn, [NativeTypeName("const CLSID *")] Guid* pPinCategoryIn, BOOL bRender, BOOL bOutputNeeded, [NativeTypeName("DWORD")] uint cOutputTypes, [NativeTypeName("const GUID *")] Guid* pOutputTypes, [NativeTypeName("const REGPINMEDIUM *")] REGPINMEDIUM* pMedOut, [NativeTypeName("const CLSID *")] Guid* pPinCategoryOut)
    {
        return ((delegate* unmanaged[MemberFunction]<IFilterMapper3*, IEnumMoniker**, uint, BOOL, uint, BOOL, uint, Guid*, REGPINMEDIUM*, Guid*, BOOL, BOOL, uint, Guid*, REGPINMEDIUM*, Guid*, int>)(lpVtbl[6]))((IFilterMapper3*)Unsafe.AsPointer(ref this), ppEnum, dwFlags, bExactMatch, dwMerit, bInputNeeded, cInputTypes, pInputTypes, pMedIn, pPinCategoryIn, bRender, bOutputNeeded, cOutputTypes, pOutputTypes, pMedOut, pPinCategoryOut);
    }

    /// <include file='IFilterMapper3.xml' path='doc/member[@name="IFilterMapper3.GetICreateDevEnum"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetICreateDevEnum(ICreateDevEnum** ppEnum)
    {
        return ((delegate* unmanaged[MemberFunction]<IFilterMapper3*, ICreateDevEnum**, int>)(lpVtbl[7]))((IFilterMapper3*)Unsafe.AsPointer(ref this), ppEnum);
    }

    public interface Interface : IFilterMapper2.Interface
    {
        [VtblIndex(7)]
        HRESULT GetICreateDevEnum(ICreateDevEnum** ppEnum);
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

        [NativeTypeName("HRESULT (const IID &, DWORD, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, uint, char*, int> CreateCategory;

        [NativeTypeName("HRESULT (const CLSID *, LPCOLESTR, const IID &) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char*, Guid*, int> UnregisterFilter;

        [NativeTypeName("HRESULT (const IID &, LPCWSTR, IMoniker **, const CLSID *, LPCOLESTR, const REGFILTER2 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char*, IMoniker**, Guid*, char*, REGFILTER2*, int> RegisterFilter;

        [NativeTypeName("HRESULT (IEnumMoniker **, DWORD, BOOL, DWORD, BOOL, DWORD, const GUID *, const REGPINMEDIUM *, const CLSID *, BOOL, BOOL, DWORD, const GUID *, const REGPINMEDIUM *, const CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEnumMoniker**, uint, BOOL, uint, BOOL, uint, Guid*, REGPINMEDIUM*, Guid*, BOOL, BOOL, uint, Guid*, REGPINMEDIUM*, Guid*, int> EnumMatchingFilters;

        [NativeTypeName("HRESULT (ICreateDevEnum **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICreateDevEnum**, int> GetICreateDevEnum;
    }
}
