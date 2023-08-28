// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6"]/*' />
[Guid("30510471-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLRuleStyle6 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLRuleStyle6 : IHTMLRuleStyle6.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLRuleStyle6));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, uint>)(lpVtbl[1]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, uint>)(lpVtbl[2]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, uint*, int>)(lpVtbl[3]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, Guid*, char**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.put_content"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_content([NativeTypeName("BSTR")] char* v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, char*, int>)(lpVtbl[7]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.get_content"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_content([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, char**, int>)(lpVtbl[8]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.put_captionSide"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_captionSide([NativeTypeName("BSTR")] char* v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, char*, int>)(lpVtbl[9]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.get_captionSide"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_captionSide([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, char**, int>)(lpVtbl[10]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.put_counterIncrement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_counterIncrement([NativeTypeName("BSTR")] char* v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, char*, int>)(lpVtbl[11]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.get_counterIncrement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_counterIncrement([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, char**, int>)(lpVtbl[12]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.put_counterReset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_counterReset([NativeTypeName("BSTR")] char* v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, char*, int>)(lpVtbl[13]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.get_counterReset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_counterReset([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, char**, int>)(lpVtbl[14]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.put_outline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_outline([NativeTypeName("BSTR")] char* v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, char*, int>)(lpVtbl[15]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.get_outline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_outline([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, char**, int>)(lpVtbl[16]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.put_outlineWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_outlineWidth(VARIANT v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, VARIANT, int>)(lpVtbl[17]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.get_outlineWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_outlineWidth(VARIANT* p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, VARIANT*, int>)(lpVtbl[18]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.put_outlineStyle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_outlineStyle([NativeTypeName("BSTR")] char* v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, char*, int>)(lpVtbl[19]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.get_outlineStyle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_outlineStyle([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, char**, int>)(lpVtbl[20]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.put_outlineColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_outlineColor(VARIANT v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, VARIANT, int>)(lpVtbl[21]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.get_outlineColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_outlineColor(VARIANT* p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, VARIANT*, int>)(lpVtbl[22]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.put_boxSizing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_boxSizing([NativeTypeName("BSTR")] char* v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, char*, int>)(lpVtbl[23]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.get_boxSizing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_boxSizing([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, char**, int>)(lpVtbl[24]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.put_borderSpacing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_borderSpacing([NativeTypeName("BSTR")] char* v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, char*, int>)(lpVtbl[25]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.get_borderSpacing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_borderSpacing([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, char**, int>)(lpVtbl[26]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.put_orphans"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_orphans(VARIANT v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, VARIANT, int>)(lpVtbl[27]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.get_orphans"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_orphans(VARIANT* p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, VARIANT*, int>)(lpVtbl[28]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.put_widows"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_widows(VARIANT v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, VARIANT, int>)(lpVtbl[29]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.get_widows"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_widows(VARIANT* p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, VARIANT*, int>)(lpVtbl[30]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.put_pageBreakInside"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_pageBreakInside([NativeTypeName("BSTR")] char* v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, char*, int>)(lpVtbl[31]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.get_pageBreakInside"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_pageBreakInside([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, char**, int>)(lpVtbl[32]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.put_emptyCells"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_emptyCells([NativeTypeName("BSTR")] char* v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, char*, int>)(lpVtbl[33]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.get_emptyCells"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_emptyCells([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, char**, int>)(lpVtbl[34]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.put_msBlockProgression"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT put_msBlockProgression([NativeTypeName("BSTR")] char* v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, char*, int>)(lpVtbl[35]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.get_msBlockProgression"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_msBlockProgression([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, char**, int>)(lpVtbl[36]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.put_quotes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT put_quotes([NativeTypeName("BSTR")] char* v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, char*, int>)(lpVtbl[37]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRuleStyle6.xml' path='doc/member[@name="IHTMLRuleStyle6.get_quotes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_quotes([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLRuleStyle6*, char**, int>)(lpVtbl[38]))((IHTMLRuleStyle6*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_content([NativeTypeName("BSTR")] char* v);

        [VtblIndex(8)]
        HRESULT get_content([NativeTypeName("BSTR *")] char** p);

        [VtblIndex(9)]
        HRESULT put_captionSide([NativeTypeName("BSTR")] char* v);

        [VtblIndex(10)]
        HRESULT get_captionSide([NativeTypeName("BSTR *")] char** p);

        [VtblIndex(11)]
        HRESULT put_counterIncrement([NativeTypeName("BSTR")] char* v);

        [VtblIndex(12)]
        HRESULT get_counterIncrement([NativeTypeName("BSTR *")] char** p);

        [VtblIndex(13)]
        HRESULT put_counterReset([NativeTypeName("BSTR")] char* v);

        [VtblIndex(14)]
        HRESULT get_counterReset([NativeTypeName("BSTR *")] char** p);

        [VtblIndex(15)]
        HRESULT put_outline([NativeTypeName("BSTR")] char* v);

        [VtblIndex(16)]
        HRESULT get_outline([NativeTypeName("BSTR *")] char** p);

        [VtblIndex(17)]
        HRESULT put_outlineWidth(VARIANT v);

        [VtblIndex(18)]
        HRESULT get_outlineWidth(VARIANT* p);

        [VtblIndex(19)]
        HRESULT put_outlineStyle([NativeTypeName("BSTR")] char* v);

        [VtblIndex(20)]
        HRESULT get_outlineStyle([NativeTypeName("BSTR *")] char** p);

        [VtblIndex(21)]
        HRESULT put_outlineColor(VARIANT v);

        [VtblIndex(22)]
        HRESULT get_outlineColor(VARIANT* p);

        [VtblIndex(23)]
        HRESULT put_boxSizing([NativeTypeName("BSTR")] char* v);

        [VtblIndex(24)]
        HRESULT get_boxSizing([NativeTypeName("BSTR *")] char** p);

        [VtblIndex(25)]
        HRESULT put_borderSpacing([NativeTypeName("BSTR")] char* v);

        [VtblIndex(26)]
        HRESULT get_borderSpacing([NativeTypeName("BSTR *")] char** p);

        [VtblIndex(27)]
        HRESULT put_orphans(VARIANT v);

        [VtblIndex(28)]
        HRESULT get_orphans(VARIANT* p);

        [VtblIndex(29)]
        HRESULT put_widows(VARIANT v);

        [VtblIndex(30)]
        HRESULT get_widows(VARIANT* p);

        [VtblIndex(31)]
        HRESULT put_pageBreakInside([NativeTypeName("BSTR")] char* v);

        [VtblIndex(32)]
        HRESULT get_pageBreakInside([NativeTypeName("BSTR *")] char** p);

        [VtblIndex(33)]
        HRESULT put_emptyCells([NativeTypeName("BSTR")] char* v);

        [VtblIndex(34)]
        HRESULT get_emptyCells([NativeTypeName("BSTR *")] char** p);

        [VtblIndex(35)]
        HRESULT put_msBlockProgression([NativeTypeName("BSTR")] char* v);

        [VtblIndex(36)]
        HRESULT get_msBlockProgression([NativeTypeName("BSTR *")] char** p);

        [VtblIndex(37)]
        HRESULT put_quotes([NativeTypeName("BSTR")] char* v);

        [VtblIndex(38)]
        HRESULT get_quotes([NativeTypeName("BSTR *")] char** p);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_content;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_content;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_captionSide;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_captionSide;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_counterIncrement;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_counterIncrement;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_counterReset;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_counterReset;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_outline;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_outline;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_outlineWidth;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_outlineWidth;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_outlineStyle;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_outlineStyle;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_outlineColor;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_outlineColor;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_boxSizing;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_boxSizing;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_borderSpacing;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_borderSpacing;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_orphans;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_orphans;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_widows;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_widows;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_pageBreakInside;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_pageBreakInside;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_emptyCells;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_emptyCells;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_msBlockProgression;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_msBlockProgression;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_quotes;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_quotes;
    }
}
