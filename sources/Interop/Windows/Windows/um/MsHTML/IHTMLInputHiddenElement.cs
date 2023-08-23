// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHTMLInputHiddenElement.xml' path='doc/member[@name="IHTMLInputHiddenElement"]/*' />
[Guid("3050F2A4-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLInputHiddenElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLInputHiddenElement : IHTMLInputHiddenElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLInputHiddenElement));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLInputHiddenElement*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLInputHiddenElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLInputHiddenElement*, uint>)(lpVtbl[1]))((IHTMLInputHiddenElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLInputHiddenElement*, uint>)(lpVtbl[2]))((IHTMLInputHiddenElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLInputHiddenElement*, uint*, int>)(lpVtbl[3]))((IHTMLInputHiddenElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLInputHiddenElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLInputHiddenElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLInputHiddenElement*, Guid*, char**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLInputHiddenElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLInputHiddenElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLInputHiddenElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLInputHiddenElement.xml' path='doc/member[@name="IHTMLInputHiddenElement.get_type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_type([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged<IHTMLInputHiddenElement*, char**, int>)(lpVtbl[7]))((IHTMLInputHiddenElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputHiddenElement.xml' path='doc/member[@name="IHTMLInputHiddenElement.put_value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_value([NativeTypeName("BSTR")] char* v)
    {
        return ((delegate* unmanaged<IHTMLInputHiddenElement*, char*, int>)(lpVtbl[8]))((IHTMLInputHiddenElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputHiddenElement.xml' path='doc/member[@name="IHTMLInputHiddenElement.get_value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_value([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged<IHTMLInputHiddenElement*, char**, int>)(lpVtbl[9]))((IHTMLInputHiddenElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputHiddenElement.xml' path='doc/member[@name="IHTMLInputHiddenElement.put_name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_name([NativeTypeName("BSTR")] char* v)
    {
        return ((delegate* unmanaged<IHTMLInputHiddenElement*, char*, int>)(lpVtbl[10]))((IHTMLInputHiddenElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputHiddenElement.xml' path='doc/member[@name="IHTMLInputHiddenElement.get_name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_name([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged<IHTMLInputHiddenElement*, char**, int>)(lpVtbl[11]))((IHTMLInputHiddenElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputHiddenElement.xml' path='doc/member[@name="IHTMLInputHiddenElement.put_status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_status(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLInputHiddenElement*, VARIANT, int>)(lpVtbl[12]))((IHTMLInputHiddenElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputHiddenElement.xml' path='doc/member[@name="IHTMLInputHiddenElement.get_status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_status(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLInputHiddenElement*, VARIANT*, int>)(lpVtbl[13]))((IHTMLInputHiddenElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputHiddenElement.xml' path='doc/member[@name="IHTMLInputHiddenElement.put_disabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_disabled([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLInputHiddenElement*, short, int>)(lpVtbl[14]))((IHTMLInputHiddenElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputHiddenElement.xml' path='doc/member[@name="IHTMLInputHiddenElement.get_disabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_disabled([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLInputHiddenElement*, short*, int>)(lpVtbl[15]))((IHTMLInputHiddenElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputHiddenElement.xml' path='doc/member[@name="IHTMLInputHiddenElement.get_form"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_form(IHTMLFormElement** p)
    {
        return ((delegate* unmanaged<IHTMLInputHiddenElement*, IHTMLFormElement**, int>)(lpVtbl[16]))((IHTMLInputHiddenElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputHiddenElement.xml' path='doc/member[@name="IHTMLInputHiddenElement.createTextRange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT createTextRange(IHTMLTxtRange** range)
    {
        return ((delegate* unmanaged<IHTMLInputHiddenElement*, IHTMLTxtRange**, int>)(lpVtbl[17]))((IHTMLInputHiddenElement*)Unsafe.AsPointer(ref this), range);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_type([NativeTypeName("BSTR *")] char** p);

        [VtblIndex(8)]
        HRESULT put_value([NativeTypeName("BSTR")] char* v);

        [VtblIndex(9)]
        HRESULT get_value([NativeTypeName("BSTR *")] char** p);

        [VtblIndex(10)]
        HRESULT put_name([NativeTypeName("BSTR")] char* v);

        [VtblIndex(11)]
        HRESULT get_name([NativeTypeName("BSTR *")] char** p);

        [VtblIndex(12)]
        HRESULT put_status(VARIANT v);

        [VtblIndex(13)]
        HRESULT get_status(VARIANT* p);

        [VtblIndex(14)]
        HRESULT put_disabled([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(15)]
        HRESULT get_disabled([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(16)]
        HRESULT get_form(IHTMLFormElement** p);

        [VtblIndex(17)]
        HRESULT createTextRange(IHTMLTxtRange** range);
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
        public delegate* unmanaged<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, char**, int> get_type;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, char*, int> put_value;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, char**, int> get_value;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, char*, int> put_name;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, char**, int> get_name;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_status;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_status;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_disabled;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_disabled;

        [NativeTypeName("HRESULT (IHTMLFormElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLFormElement**, int> get_form;

        [NativeTypeName("HRESULT (IHTMLTxtRange **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLTxtRange**, int> createTextRange;
    }
}
