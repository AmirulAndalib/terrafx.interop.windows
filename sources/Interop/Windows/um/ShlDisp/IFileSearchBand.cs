// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2D91EEA1-9932-11D2-BE86-00A0C9A83DA1")]
    [NativeTypeName("struct IFileSearchBand : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IFileSearchBand
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFileSearchBand*, Guid*, void**, int>)(lpVtbl[0]))((IFileSearchBand*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFileSearchBand*, uint>)(lpVtbl[1]))((IFileSearchBand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFileSearchBand*, uint>)(lpVtbl[2]))((IFileSearchBand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IFileSearchBand*, uint*, int>)(lpVtbl[3]))((IFileSearchBand*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IFileSearchBand*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IFileSearchBand*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IFileSearchBand*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IFileSearchBand*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IFileSearchBand*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IFileSearchBand*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int SetFocus()
        {
            return ((delegate* unmanaged<IFileSearchBand*, int>)(lpVtbl[7]))((IFileSearchBand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int SetSearchParameters([NativeTypeName("BSTR *")] ushort** pbstrSearchID, [NativeTypeName("VARIANT_BOOL")] short bNavToResults, VARIANT* pvarScope, VARIANT* pvarQueryFile)
        {
            return ((delegate* unmanaged<IFileSearchBand*, ushort**, short, VARIANT*, VARIANT*, int>)(lpVtbl[8]))((IFileSearchBand*)Unsafe.AsPointer(ref this), pbstrSearchID, bNavToResults, pvarScope, pvarQueryFile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_SearchID([NativeTypeName("BSTR *")] ushort** pbstrSearchID)
        {
            return ((delegate* unmanaged<IFileSearchBand*, ushort**, int>)(lpVtbl[9]))((IFileSearchBand*)Unsafe.AsPointer(ref this), pbstrSearchID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_Scope(VARIANT* pvarScope)
        {
            return ((delegate* unmanaged<IFileSearchBand*, VARIANT*, int>)(lpVtbl[10]))((IFileSearchBand*)Unsafe.AsPointer(ref this), pvarScope);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_QueryFile(VARIANT* pvarFile)
        {
            return ((delegate* unmanaged<IFileSearchBand*, VARIANT*, int>)(lpVtbl[11]))((IFileSearchBand*)Unsafe.AsPointer(ref this), pvarFile);
        }
    }
}