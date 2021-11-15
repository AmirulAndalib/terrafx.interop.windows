// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("305104C0-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLStyleSheetRulesAppliedCollection : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLStyleSheetRulesAppliedCollection : IHTMLStyleSheetRulesAppliedCollection.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLStyleSheetRulesAppliedCollection*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLStyleSheetRulesAppliedCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLStyleSheetRulesAppliedCollection*, uint>)(lpVtbl[1]))((IHTMLStyleSheetRulesAppliedCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLStyleSheetRulesAppliedCollection*, uint>)(lpVtbl[2]))((IHTMLStyleSheetRulesAppliedCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLStyleSheetRulesAppliedCollection*, uint*, int>)(lpVtbl[3]))((IHTMLStyleSheetRulesAppliedCollection*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLStyleSheetRulesAppliedCollection*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLStyleSheetRulesAppliedCollection*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLStyleSheetRulesAppliedCollection*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLStyleSheetRulesAppliedCollection*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLStyleSheetRulesAppliedCollection*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLStyleSheetRulesAppliedCollection*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT item([NativeTypeName("long")] int index, IHTMLStyleSheetRule** ppHTMLStyleSheetRule)
        {
            return ((delegate* unmanaged<IHTMLStyleSheetRulesAppliedCollection*, int, IHTMLStyleSheetRule**, int>)(lpVtbl[7]))((IHTMLStyleSheetRulesAppliedCollection*)Unsafe.AsPointer(ref this), index, ppHTMLStyleSheetRule);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_length([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLStyleSheetRulesAppliedCollection*, int*, int>)(lpVtbl[8]))((IHTMLStyleSheetRulesAppliedCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT propertyAppliedBy([NativeTypeName("BSTR")] ushort* name, IHTMLStyleSheetRule** ppRule)
        {
            return ((delegate* unmanaged<IHTMLStyleSheetRulesAppliedCollection*, ushort*, IHTMLStyleSheetRule**, int>)(lpVtbl[9]))((IHTMLStyleSheetRulesAppliedCollection*)Unsafe.AsPointer(ref this), name, ppRule);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT propertyAppliedTrace([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("long")] int index, IHTMLStyleSheetRule** ppRule)
        {
            return ((delegate* unmanaged<IHTMLStyleSheetRulesAppliedCollection*, ushort*, int, IHTMLStyleSheetRule**, int>)(lpVtbl[10]))((IHTMLStyleSheetRulesAppliedCollection*)Unsafe.AsPointer(ref this), name, index, ppRule);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT propertyAppliedTraceLength([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("long *")] int* pLength)
        {
            return ((delegate* unmanaged<IHTMLStyleSheetRulesAppliedCollection*, ushort*, int*, int>)(lpVtbl[11]))((IHTMLStyleSheetRulesAppliedCollection*)Unsafe.AsPointer(ref this), name, pLength);
        }

        public interface Interface : IDispatch.Interface
        {
            [VtblIndex(7)]
            HRESULT item([NativeTypeName("long")] int index, IHTMLStyleSheetRule** ppHTMLStyleSheetRule);

            [VtblIndex(8)]
            HRESULT get_length([NativeTypeName("long *")] int* p);

            [VtblIndex(9)]
            HRESULT propertyAppliedBy([NativeTypeName("BSTR")] ushort* name, IHTMLStyleSheetRule** ppRule);

            [VtblIndex(10)]
            HRESULT propertyAppliedTrace([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("long")] int index, IHTMLStyleSheetRule** ppRule);

            [VtblIndex(11)]
            HRESULT propertyAppliedTraceLength([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("long *")] int* pLength);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLStyleSheetRulesAppliedCollection*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLStyleSheetRulesAppliedCollection*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLStyleSheetRulesAppliedCollection*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLStyleSheetRulesAppliedCollection*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLStyleSheetRulesAppliedCollection*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLStyleSheetRulesAppliedCollection*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLStyleSheetRulesAppliedCollection*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (long, IHTMLStyleSheetRule **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLStyleSheetRulesAppliedCollection*, int, IHTMLStyleSheetRule**, int> item;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLStyleSheetRulesAppliedCollection*, int*, int> get_length;

            [NativeTypeName("HRESULT (BSTR, IHTMLStyleSheetRule **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLStyleSheetRulesAppliedCollection*, ushort*, IHTMLStyleSheetRule**, int> propertyAppliedBy;

            [NativeTypeName("HRESULT (BSTR, long, IHTMLStyleSheetRule **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLStyleSheetRulesAppliedCollection*, ushort*, int, IHTMLStyleSheetRule**, int> propertyAppliedTrace;

            [NativeTypeName("HRESULT (BSTR, long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLStyleSheetRulesAppliedCollection*, ushort*, int*, int> propertyAppliedTraceLength;
        }
    }
}