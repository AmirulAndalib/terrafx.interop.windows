// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2933BF83-7B36-11D2-B20E-00C04F983E60")]
    [NativeTypeName("struct IXMLDOMNamedNodeMap : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IXMLDOMNamedNodeMap : IXMLDOMNamedNodeMap.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IXMLDOMNamedNodeMap*, Guid*, void**, int>)(lpVtbl[0]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IXMLDOMNamedNodeMap*, uint>)(lpVtbl[1]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IXMLDOMNamedNodeMap*, uint>)(lpVtbl[2]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IXMLDOMNamedNodeMap*, uint*, int>)(lpVtbl[3]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IXMLDOMNamedNodeMap*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IXMLDOMNamedNodeMap*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IXMLDOMNamedNodeMap*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT getNamedItem([NativeTypeName("BSTR")] ushort* name, IXMLDOMNode** namedItem)
        {
            return ((delegate* unmanaged<IXMLDOMNamedNodeMap*, ushort*, IXMLDOMNode**, int>)(lpVtbl[7]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), name, namedItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT setNamedItem(IXMLDOMNode* newItem, IXMLDOMNode** nameItem)
        {
            return ((delegate* unmanaged<IXMLDOMNamedNodeMap*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[8]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), newItem, nameItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT removeNamedItem([NativeTypeName("BSTR")] ushort* name, IXMLDOMNode** namedItem)
        {
            return ((delegate* unmanaged<IXMLDOMNamedNodeMap*, ushort*, IXMLDOMNode**, int>)(lpVtbl[9]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), name, namedItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_item([NativeTypeName("long")] int index, IXMLDOMNode** listItem)
        {
            return ((delegate* unmanaged<IXMLDOMNamedNodeMap*, int, IXMLDOMNode**, int>)(lpVtbl[10]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), index, listItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_length([NativeTypeName("long *")] int* listLength)
        {
            return ((delegate* unmanaged<IXMLDOMNamedNodeMap*, int*, int>)(lpVtbl[11]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), listLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT getQualifiedItem([NativeTypeName("BSTR")] ushort* baseName, [NativeTypeName("BSTR")] ushort* namespaceURI, IXMLDOMNode** qualifiedItem)
        {
            return ((delegate* unmanaged<IXMLDOMNamedNodeMap*, ushort*, ushort*, IXMLDOMNode**, int>)(lpVtbl[12]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), baseName, namespaceURI, qualifiedItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT removeQualifiedItem([NativeTypeName("BSTR")] ushort* baseName, [NativeTypeName("BSTR")] ushort* namespaceURI, IXMLDOMNode** qualifiedItem)
        {
            return ((delegate* unmanaged<IXMLDOMNamedNodeMap*, ushort*, ushort*, IXMLDOMNode**, int>)(lpVtbl[13]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), baseName, namespaceURI, qualifiedItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT nextNode(IXMLDOMNode** nextItem)
        {
            return ((delegate* unmanaged<IXMLDOMNamedNodeMap*, IXMLDOMNode**, int>)(lpVtbl[14]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), nextItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT reset()
        {
            return ((delegate* unmanaged<IXMLDOMNamedNodeMap*, int>)(lpVtbl[15]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get__newEnum(IUnknown** ppUnk)
        {
            return ((delegate* unmanaged<IXMLDOMNamedNodeMap*, IUnknown**, int>)(lpVtbl[16]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), ppUnk);
        }

        public interface Interface : IDispatch.Interface
        {
            [VtblIndex(7)]
            HRESULT getNamedItem([NativeTypeName("BSTR")] ushort* name, IXMLDOMNode** namedItem);

            [VtblIndex(8)]
            HRESULT setNamedItem(IXMLDOMNode* newItem, IXMLDOMNode** nameItem);

            [VtblIndex(9)]
            HRESULT removeNamedItem([NativeTypeName("BSTR")] ushort* name, IXMLDOMNode** namedItem);

            [VtblIndex(10)]
            HRESULT get_item([NativeTypeName("long")] int index, IXMLDOMNode** listItem);

            [VtblIndex(11)]
            HRESULT get_length([NativeTypeName("long *")] int* listLength);

            [VtblIndex(12)]
            HRESULT getQualifiedItem([NativeTypeName("BSTR")] ushort* baseName, [NativeTypeName("BSTR")] ushort* namespaceURI, IXMLDOMNode** qualifiedItem);

            [VtblIndex(13)]
            HRESULT removeQualifiedItem([NativeTypeName("BSTR")] ushort* baseName, [NativeTypeName("BSTR")] ushort* namespaceURI, IXMLDOMNode** qualifiedItem);

            [VtblIndex(14)]
            HRESULT nextNode(IXMLDOMNode** nextItem);

            [VtblIndex(15)]
            HRESULT reset();

            [VtblIndex(16)]
            HRESULT get__newEnum(IUnknown** ppUnk);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMNamedNodeMap*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMNamedNodeMap*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMNamedNodeMap*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMNamedNodeMap*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMNamedNodeMap*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMNamedNodeMap*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMNamedNodeMap*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMNamedNodeMap*, ushort*, IXMLDOMNode**, int> getNamedItem;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMNamedNodeMap*, IXMLDOMNode*, IXMLDOMNode**, int> setNamedItem;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMNamedNodeMap*, ushort*, IXMLDOMNode**, int> removeNamedItem;

            [NativeTypeName("HRESULT (long, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMNamedNodeMap*, int, IXMLDOMNode**, int> get_item;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMNamedNodeMap*, int*, int> get_length;

            [NativeTypeName("HRESULT (BSTR, BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMNamedNodeMap*, ushort*, ushort*, IXMLDOMNode**, int> getQualifiedItem;

            [NativeTypeName("HRESULT (BSTR, BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMNamedNodeMap*, ushort*, ushort*, IXMLDOMNode**, int> removeQualifiedItem;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMNamedNodeMap*, IXMLDOMNode**, int> nextNode;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMNamedNodeMap*, int> reset;

            [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMNamedNodeMap*, IUnknown**, int> get__newEnum;
        }
    }
}
