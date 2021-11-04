// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305104B6-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLSelection : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLSelection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLSelection*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLSelection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLSelection*, uint>)(lpVtbl[1]))((IHTMLSelection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLSelection*, uint>)(lpVtbl[2]))((IHTMLSelection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLSelection*, uint*, int>)(lpVtbl[3]))((IHTMLSelection*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLSelection*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLSelection*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLSelection*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLSelection*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLSelection*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLSelection*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_anchorNode(IHTMLDOMNode** p)
        {
            return ((delegate* unmanaged<IHTMLSelection*, IHTMLDOMNode**, int>)(lpVtbl[7]))((IHTMLSelection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_anchorOffset([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLSelection*, int*, int>)(lpVtbl[8]))((IHTMLSelection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_focusNode(IHTMLDOMNode** p)
        {
            return ((delegate* unmanaged<IHTMLSelection*, IHTMLDOMNode**, int>)(lpVtbl[9]))((IHTMLSelection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_focusOffset([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLSelection*, int*, int>)(lpVtbl[10]))((IHTMLSelection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_isCollapsed([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLSelection*, short*, int>)(lpVtbl[11]))((IHTMLSelection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT collapse(IDispatch* parentNode, [NativeTypeName("long")] int offfset)
        {
            return ((delegate* unmanaged<IHTMLSelection*, IDispatch*, int, int>)(lpVtbl[12]))((IHTMLSelection*)Unsafe.AsPointer(ref this), parentNode, offfset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT collapseToStart()
        {
            return ((delegate* unmanaged<IHTMLSelection*, int>)(lpVtbl[13]))((IHTMLSelection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT collapseToEnd()
        {
            return ((delegate* unmanaged<IHTMLSelection*, int>)(lpVtbl[14]))((IHTMLSelection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT selectAllChildren(IDispatch* parentNode)
        {
            return ((delegate* unmanaged<IHTMLSelection*, IDispatch*, int>)(lpVtbl[15]))((IHTMLSelection*)Unsafe.AsPointer(ref this), parentNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT deleteFromDocument()
        {
            return ((delegate* unmanaged<IHTMLSelection*, int>)(lpVtbl[16]))((IHTMLSelection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_rangeCount([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLSelection*, int*, int>)(lpVtbl[17]))((IHTMLSelection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT getRangeAt([NativeTypeName("long")] int index, IHTMLDOMRange** ppRange)
        {
            return ((delegate* unmanaged<IHTMLSelection*, int, IHTMLDOMRange**, int>)(lpVtbl[18]))((IHTMLSelection*)Unsafe.AsPointer(ref this), index, ppRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT addRange(IDispatch* range)
        {
            return ((delegate* unmanaged<IHTMLSelection*, IDispatch*, int>)(lpVtbl[19]))((IHTMLSelection*)Unsafe.AsPointer(ref this), range);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT removeRange(IDispatch* range)
        {
            return ((delegate* unmanaged<IHTMLSelection*, IDispatch*, int>)(lpVtbl[20]))((IHTMLSelection*)Unsafe.AsPointer(ref this), range);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT removeAllRanges()
        {
            return ((delegate* unmanaged<IHTMLSelection*, int>)(lpVtbl[21]))((IHTMLSelection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT toString([NativeTypeName("BSTR *")] ushort** pSelectionString)
        {
            return ((delegate* unmanaged<IHTMLSelection*, ushort**, int>)(lpVtbl[22]))((IHTMLSelection*)Unsafe.AsPointer(ref this), pSelectionString);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLSelection*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLSelection*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLSelection*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLSelection*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLSelection*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLSelection*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLSelection*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (IHTMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLSelection*, IHTMLDOMNode**, int> get_anchorNode;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLSelection*, int*, int> get_anchorOffset;

            [NativeTypeName("HRESULT (IHTMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLSelection*, IHTMLDOMNode**, int> get_focusNode;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLSelection*, int*, int> get_focusOffset;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLSelection*, short*, int> get_isCollapsed;

            [NativeTypeName("HRESULT (IDispatch *, long) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLSelection*, IDispatch*, int, int> collapse;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLSelection*, int> collapseToStart;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLSelection*, int> collapseToEnd;

            [NativeTypeName("HRESULT (IDispatch *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLSelection*, IDispatch*, int> selectAllChildren;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLSelection*, int> deleteFromDocument;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLSelection*, int*, int> get_rangeCount;

            [NativeTypeName("HRESULT (long, IHTMLDOMRange **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLSelection*, int, IHTMLDOMRange**, int> getRangeAt;

            [NativeTypeName("HRESULT (IDispatch *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLSelection*, IDispatch*, int> addRange;

            [NativeTypeName("HRESULT (IDispatch *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLSelection*, IDispatch*, int> removeRange;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLSelection*, int> removeAllRanges;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLSelection*, ushort**, int> toString;
        }
    }
}
