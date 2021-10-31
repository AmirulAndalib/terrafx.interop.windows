// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F220-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLTxtRange : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLTxtRange
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, uint>)(lpVtbl[1]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, uint>)(lpVtbl[2]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, uint*, int>)(lpVtbl[3]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_htmlText([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, ushort**, int>)(lpVtbl[7]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT put_text([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, int>)(lpVtbl[8]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_text([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, ushort**, int>)(lpVtbl[9]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT parentElement(IHTMLElement** parent)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, IHTMLElement**, int>)(lpVtbl[10]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), parent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT duplicate(IHTMLTxtRange** Duplicate)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, IHTMLTxtRange**, int>)(lpVtbl[11]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), Duplicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT inRange(IHTMLTxtRange* Range, [NativeTypeName("VARIANT_BOOL *")] short* InRange)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, IHTMLTxtRange*, short*, int>)(lpVtbl[12]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), Range, InRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT isEqual(IHTMLTxtRange* Range, [NativeTypeName("VARIANT_BOOL *")] short* IsEqual)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, IHTMLTxtRange*, short*, int>)(lpVtbl[13]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), Range, IsEqual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT scrollIntoView([NativeTypeName("VARIANT_BOOL")] short fStart = -1)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, short, int>)(lpVtbl[14]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), fStart);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT collapse([NativeTypeName("VARIANT_BOOL")] short Start = -1)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, short, int>)(lpVtbl[15]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), Start);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT expand([NativeTypeName("BSTR")] ushort* Unit, [NativeTypeName("VARIANT_BOOL *")] short* Success)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, short*, int>)(lpVtbl[16]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), Unit, Success);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT move([NativeTypeName("BSTR")] ushort* Unit, [NativeTypeName("long")] int Count, [NativeTypeName("long *")] int* ActualCount)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, int, int*, int>)(lpVtbl[17]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), Unit, Count, ActualCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT moveStart([NativeTypeName("BSTR")] ushort* Unit, [NativeTypeName("long")] int Count, [NativeTypeName("long *")] int* ActualCount)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, int, int*, int>)(lpVtbl[18]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), Unit, Count, ActualCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT moveEnd([NativeTypeName("BSTR")] ushort* Unit, [NativeTypeName("long")] int Count, [NativeTypeName("long *")] int* ActualCount)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, int, int*, int>)(lpVtbl[19]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), Unit, Count, ActualCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT select()
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, int>)(lpVtbl[20]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT pasteHTML([NativeTypeName("BSTR")] ushort* html)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, int>)(lpVtbl[21]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), html);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT moveToElementText(IHTMLElement* element)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, IHTMLElement*, int>)(lpVtbl[22]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), element);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT setEndPoint([NativeTypeName("BSTR")] ushort* how, IHTMLTxtRange* SourceRange)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, IHTMLTxtRange*, int>)(lpVtbl[23]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), how, SourceRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT compareEndPoints([NativeTypeName("BSTR")] ushort* how, IHTMLTxtRange* SourceRange, [NativeTypeName("long *")] int* ret)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, IHTMLTxtRange*, int*, int>)(lpVtbl[24]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), how, SourceRange, ret);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT findText([NativeTypeName("BSTR")] ushort* String, [NativeTypeName("long")] int count, [NativeTypeName("long")] int Flags, [NativeTypeName("VARIANT_BOOL *")] short* Success)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, int, int, short*, int>)(lpVtbl[25]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), String, count, Flags, Success);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT moveToPoint([NativeTypeName("long")] int x, [NativeTypeName("long")] int y)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, int, int, int>)(lpVtbl[26]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT getBookmark([NativeTypeName("BSTR *")] ushort** Boolmark)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, ushort**, int>)(lpVtbl[27]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), Boolmark);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT moveToBookmark([NativeTypeName("BSTR")] ushort* Bookmark, [NativeTypeName("VARIANT_BOOL *")] short* Success)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, short*, int>)(lpVtbl[28]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), Bookmark, Success);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT queryCommandSupported([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, short*, int>)(lpVtbl[29]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), cmdID, pfRet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT queryCommandEnabled([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, short*, int>)(lpVtbl[30]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), cmdID, pfRet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT queryCommandState([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, short*, int>)(lpVtbl[31]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), cmdID, pfRet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT queryCommandIndeterm([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, short*, int>)(lpVtbl[32]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), cmdID, pfRet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT queryCommandText([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("BSTR *")] ushort** pcmdText)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, ushort**, int>)(lpVtbl[33]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), cmdID, pcmdText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT queryCommandValue([NativeTypeName("BSTR")] ushort* cmdID, VARIANT* pcmdValue)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, VARIANT*, int>)(lpVtbl[34]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), cmdID, pcmdValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT execCommand([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL")] short showUI, VARIANT value, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, short, VARIANT, short*, int>)(lpVtbl[35]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), cmdID, showUI, value, pfRet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT execCommandShowHelp([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
        {
            return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, short*, int>)(lpVtbl[36]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), cmdID, pfRet);
        }
    }
}
