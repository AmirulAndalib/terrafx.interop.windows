// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F4FD-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTCDefaultDispatch : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTCDefaultDispatch
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTCDefaultDispatch*, Guid*, void**, int>)(lpVtbl[0]))((IHTCDefaultDispatch*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTCDefaultDispatch*, uint>)(lpVtbl[1]))((IHTCDefaultDispatch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTCDefaultDispatch*, uint>)(lpVtbl[2]))((IHTCDefaultDispatch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTCDefaultDispatch*, uint*, int>)(lpVtbl[3]))((IHTCDefaultDispatch*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTCDefaultDispatch*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTCDefaultDispatch*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTCDefaultDispatch*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTCDefaultDispatch*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTCDefaultDispatch*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTCDefaultDispatch*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_element(IHTMLElement** p)
        {
            return ((delegate* unmanaged<IHTCDefaultDispatch*, IHTMLElement**, int>)(lpVtbl[7]))((IHTCDefaultDispatch*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT createEventObject(IHTMLEventObj** eventObj)
        {
            return ((delegate* unmanaged<IHTCDefaultDispatch*, IHTMLEventObj**, int>)(lpVtbl[8]))((IHTCDefaultDispatch*)Unsafe.AsPointer(ref this), eventObj);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_defaults(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTCDefaultDispatch*, IDispatch**, int>)(lpVtbl[9]))((IHTCDefaultDispatch*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_document(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTCDefaultDispatch*, IDispatch**, int>)(lpVtbl[10]))((IHTCDefaultDispatch*)Unsafe.AsPointer(ref this), p);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTCDefaultDispatch*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTCDefaultDispatch*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTCDefaultDispatch*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTCDefaultDispatch*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTCDefaultDispatch*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTCDefaultDispatch*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTCDefaultDispatch*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTCDefaultDispatch*, IHTMLElement**, int> get_element;

            [NativeTypeName("HRESULT (IHTMLEventObj **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTCDefaultDispatch*, IHTMLEventObj**, int> createEventObject;

            [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTCDefaultDispatch*, IDispatch**, int> get_defaults;

            [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTCDefaultDispatch*, IDispatch**, int> get_document;
        }
    }
}
