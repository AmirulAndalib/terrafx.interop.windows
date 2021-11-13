// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/TextStor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("28888FE3-C2A0-483A-A3EA-8CB1CE51FF3D")]
    [NativeTypeName("struct ITextStoreACP : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITextStoreACP : ITextStoreACP.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITextStoreACP*, Guid*, void**, int>)(lpVtbl[0]))((ITextStoreACP*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITextStoreACP*, uint>)(lpVtbl[1]))((ITextStoreACP*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITextStoreACP*, uint>)(lpVtbl[2]))((ITextStoreACP*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AdviseSink([NativeTypeName("const IID &")] Guid* riid, IUnknown* punk, [NativeTypeName("DWORD")] uint dwMask)
        {
            return ((delegate* unmanaged<ITextStoreACP*, Guid*, IUnknown*, uint, int>)(lpVtbl[3]))((ITextStoreACP*)Unsafe.AsPointer(ref this), riid, punk, dwMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT UnadviseSink(IUnknown* punk)
        {
            return ((delegate* unmanaged<ITextStoreACP*, IUnknown*, int>)(lpVtbl[4]))((ITextStoreACP*)Unsafe.AsPointer(ref this), punk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT RequestLock([NativeTypeName("DWORD")] uint dwLockFlags, HRESULT* phrSession)
        {
            return ((delegate* unmanaged<ITextStoreACP*, uint, HRESULT*, int>)(lpVtbl[5]))((ITextStoreACP*)Unsafe.AsPointer(ref this), dwLockFlags, phrSession);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetStatus(TS_STATUS* pdcs)
        {
            return ((delegate* unmanaged<ITextStoreACP*, TS_STATUS*, int>)(lpVtbl[6]))((ITextStoreACP*)Unsafe.AsPointer(ref this), pdcs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT QueryInsert([NativeTypeName("LONG")] int acpTestStart, [NativeTypeName("LONG")] int acpTestEnd, [NativeTypeName("ULONG")] uint cch, [NativeTypeName("LONG *")] int* pacpResultStart, [NativeTypeName("LONG *")] int* pacpResultEnd)
        {
            return ((delegate* unmanaged<ITextStoreACP*, int, int, uint, int*, int*, int>)(lpVtbl[7]))((ITextStoreACP*)Unsafe.AsPointer(ref this), acpTestStart, acpTestEnd, cch, pacpResultStart, pacpResultEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetSelection([NativeTypeName("ULONG")] uint ulIndex, [NativeTypeName("ULONG")] uint ulCount, TS_SELECTION_ACP* pSelection, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<ITextStoreACP*, uint, uint, TS_SELECTION_ACP*, uint*, int>)(lpVtbl[8]))((ITextStoreACP*)Unsafe.AsPointer(ref this), ulIndex, ulCount, pSelection, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetSelection([NativeTypeName("ULONG")] uint ulCount, [NativeTypeName("const TS_SELECTION_ACP *")] TS_SELECTION_ACP* pSelection)
        {
            return ((delegate* unmanaged<ITextStoreACP*, uint, TS_SELECTION_ACP*, int>)(lpVtbl[9]))((ITextStoreACP*)Unsafe.AsPointer(ref this), ulCount, pSelection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetText([NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, [NativeTypeName("WCHAR *")] ushort* pchPlain, [NativeTypeName("ULONG")] uint cchPlainReq, [NativeTypeName("ULONG *")] uint* pcchPlainRet, TS_RUNINFO* prgRunInfo, [NativeTypeName("ULONG")] uint cRunInfoReq, [NativeTypeName("ULONG *")] uint* pcRunInfoRet, [NativeTypeName("LONG *")] int* pacpNext)
        {
            return ((delegate* unmanaged<ITextStoreACP*, int, int, ushort*, uint, uint*, TS_RUNINFO*, uint, uint*, int*, int>)(lpVtbl[10]))((ITextStoreACP*)Unsafe.AsPointer(ref this), acpStart, acpEnd, pchPlain, cchPlainReq, pcchPlainRet, prgRunInfo, cRunInfoReq, pcRunInfoRet, pacpNext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetText([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, [NativeTypeName("const WCHAR *")] ushort* pchText, [NativeTypeName("ULONG")] uint cch, TS_TEXTCHANGE* pChange)
        {
            return ((delegate* unmanaged<ITextStoreACP*, uint, int, int, ushort*, uint, TS_TEXTCHANGE*, int>)(lpVtbl[11]))((ITextStoreACP*)Unsafe.AsPointer(ref this), dwFlags, acpStart, acpEnd, pchText, cch, pChange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetFormattedText([NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, IDataObject** ppDataObject)
        {
            return ((delegate* unmanaged<ITextStoreACP*, int, int, IDataObject**, int>)(lpVtbl[12]))((ITextStoreACP*)Unsafe.AsPointer(ref this), acpStart, acpEnd, ppDataObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetEmbedded([NativeTypeName("LONG")] int acpPos, [NativeTypeName("const GUID &")] Guid* rguidService, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk)
        {
            return ((delegate* unmanaged<ITextStoreACP*, int, Guid*, Guid*, IUnknown**, int>)(lpVtbl[13]))((ITextStoreACP*)Unsafe.AsPointer(ref this), acpPos, rguidService, riid, ppunk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT QueryInsertEmbedded([NativeTypeName("const GUID *")] Guid* pguidService, [NativeTypeName("const FORMATETC *")] FORMATETC* pFormatEtc, BOOL* pfInsertable)
        {
            return ((delegate* unmanaged<ITextStoreACP*, Guid*, FORMATETC*, BOOL*, int>)(lpVtbl[14]))((ITextStoreACP*)Unsafe.AsPointer(ref this), pguidService, pFormatEtc, pfInsertable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT InsertEmbedded([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, IDataObject* pDataObject, TS_TEXTCHANGE* pChange)
        {
            return ((delegate* unmanaged<ITextStoreACP*, uint, int, int, IDataObject*, TS_TEXTCHANGE*, int>)(lpVtbl[15]))((ITextStoreACP*)Unsafe.AsPointer(ref this), dwFlags, acpStart, acpEnd, pDataObject, pChange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT InsertTextAtSelection([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const WCHAR *")] ushort* pchText, [NativeTypeName("ULONG")] uint cch, [NativeTypeName("LONG *")] int* pacpStart, [NativeTypeName("LONG *")] int* pacpEnd, TS_TEXTCHANGE* pChange)
        {
            return ((delegate* unmanaged<ITextStoreACP*, uint, ushort*, uint, int*, int*, TS_TEXTCHANGE*, int>)(lpVtbl[16]))((ITextStoreACP*)Unsafe.AsPointer(ref this), dwFlags, pchText, cch, pacpStart, pacpEnd, pChange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT InsertEmbeddedAtSelection([NativeTypeName("DWORD")] uint dwFlags, IDataObject* pDataObject, [NativeTypeName("LONG *")] int* pacpStart, [NativeTypeName("LONG *")] int* pacpEnd, TS_TEXTCHANGE* pChange)
        {
            return ((delegate* unmanaged<ITextStoreACP*, uint, IDataObject*, int*, int*, TS_TEXTCHANGE*, int>)(lpVtbl[17]))((ITextStoreACP*)Unsafe.AsPointer(ref this), dwFlags, pDataObject, pacpStart, pacpEnd, pChange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT RequestSupportedAttrs([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG")] uint cFilterAttrs, [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs)
        {
            return ((delegate* unmanaged<ITextStoreACP*, uint, uint, Guid*, int>)(lpVtbl[18]))((ITextStoreACP*)Unsafe.AsPointer(ref this), dwFlags, cFilterAttrs, paFilterAttrs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT RequestAttrsAtPosition([NativeTypeName("LONG")] int acpPos, [NativeTypeName("ULONG")] uint cFilterAttrs, [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITextStoreACP*, int, uint, Guid*, uint, int>)(lpVtbl[19]))((ITextStoreACP*)Unsafe.AsPointer(ref this), acpPos, cFilterAttrs, paFilterAttrs, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT RequestAttrsTransitioningAtPosition([NativeTypeName("LONG")] int acpPos, [NativeTypeName("ULONG")] uint cFilterAttrs, [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITextStoreACP*, int, uint, Guid*, uint, int>)(lpVtbl[20]))((ITextStoreACP*)Unsafe.AsPointer(ref this), acpPos, cFilterAttrs, paFilterAttrs, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT FindNextAttrTransition([NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpHalt, [NativeTypeName("ULONG")] uint cFilterAttrs, [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONG *")] int* pacpNext, BOOL* pfFound, [NativeTypeName("LONG *")] int* plFoundOffset)
        {
            return ((delegate* unmanaged<ITextStoreACP*, int, int, uint, Guid*, uint, int*, BOOL*, int*, int>)(lpVtbl[21]))((ITextStoreACP*)Unsafe.AsPointer(ref this), acpStart, acpHalt, cFilterAttrs, paFilterAttrs, dwFlags, pacpNext, pfFound, plFoundOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT RetrieveRequestedAttrs([NativeTypeName("ULONG")] uint ulCount, TS_ATTRVAL* paAttrVals, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<ITextStoreACP*, uint, TS_ATTRVAL*, uint*, int>)(lpVtbl[22]))((ITextStoreACP*)Unsafe.AsPointer(ref this), ulCount, paAttrVals, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT GetEndACP([NativeTypeName("LONG *")] int* pacp)
        {
            return ((delegate* unmanaged<ITextStoreACP*, int*, int>)(lpVtbl[23]))((ITextStoreACP*)Unsafe.AsPointer(ref this), pacp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT GetActiveView([NativeTypeName("TsViewCookie *")] uint* pvcView)
        {
            return ((delegate* unmanaged<ITextStoreACP*, uint*, int>)(lpVtbl[24]))((ITextStoreACP*)Unsafe.AsPointer(ref this), pvcView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT GetACPFromPoint([NativeTypeName("TsViewCookie")] uint vcView, [NativeTypeName("const POINT *")] POINT* ptScreen, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONG *")] int* pacp)
        {
            return ((delegate* unmanaged<ITextStoreACP*, uint, POINT*, uint, int*, int>)(lpVtbl[25]))((ITextStoreACP*)Unsafe.AsPointer(ref this), vcView, ptScreen, dwFlags, pacp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT GetTextExt([NativeTypeName("TsViewCookie")] uint vcView, [NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, RECT* prc, BOOL* pfClipped)
        {
            return ((delegate* unmanaged<ITextStoreACP*, uint, int, int, RECT*, BOOL*, int>)(lpVtbl[26]))((ITextStoreACP*)Unsafe.AsPointer(ref this), vcView, acpStart, acpEnd, prc, pfClipped);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT GetScreenExt([NativeTypeName("TsViewCookie")] uint vcView, RECT* prc)
        {
            return ((delegate* unmanaged<ITextStoreACP*, uint, RECT*, int>)(lpVtbl[27]))((ITextStoreACP*)Unsafe.AsPointer(ref this), vcView, prc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT GetWnd([NativeTypeName("TsViewCookie")] uint vcView, HWND* phwnd)
        {
            return ((delegate* unmanaged<ITextStoreACP*, uint, HWND*, int>)(lpVtbl[28]))((ITextStoreACP*)Unsafe.AsPointer(ref this), vcView, phwnd);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT AdviseSink([NativeTypeName("const IID &")] Guid* riid, IUnknown* punk, [NativeTypeName("DWORD")] uint dwMask);

            [VtblIndex(4)]
            HRESULT UnadviseSink(IUnknown* punk);

            [VtblIndex(5)]
            HRESULT RequestLock([NativeTypeName("DWORD")] uint dwLockFlags, HRESULT* phrSession);

            [VtblIndex(6)]
            HRESULT GetStatus(TS_STATUS* pdcs);

            [VtblIndex(7)]
            HRESULT QueryInsert([NativeTypeName("LONG")] int acpTestStart, [NativeTypeName("LONG")] int acpTestEnd, [NativeTypeName("ULONG")] uint cch, [NativeTypeName("LONG *")] int* pacpResultStart, [NativeTypeName("LONG *")] int* pacpResultEnd);

            [VtblIndex(8)]
            HRESULT GetSelection([NativeTypeName("ULONG")] uint ulIndex, [NativeTypeName("ULONG")] uint ulCount, TS_SELECTION_ACP* pSelection, [NativeTypeName("ULONG *")] uint* pcFetched);

            [VtblIndex(9)]
            HRESULT SetSelection([NativeTypeName("ULONG")] uint ulCount, [NativeTypeName("const TS_SELECTION_ACP *")] TS_SELECTION_ACP* pSelection);

            [VtblIndex(10)]
            HRESULT GetText([NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, [NativeTypeName("WCHAR *")] ushort* pchPlain, [NativeTypeName("ULONG")] uint cchPlainReq, [NativeTypeName("ULONG *")] uint* pcchPlainRet, TS_RUNINFO* prgRunInfo, [NativeTypeName("ULONG")] uint cRunInfoReq, [NativeTypeName("ULONG *")] uint* pcRunInfoRet, [NativeTypeName("LONG *")] int* pacpNext);

            [VtblIndex(11)]
            HRESULT SetText([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, [NativeTypeName("const WCHAR *")] ushort* pchText, [NativeTypeName("ULONG")] uint cch, TS_TEXTCHANGE* pChange);

            [VtblIndex(12)]
            HRESULT GetFormattedText([NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, IDataObject** ppDataObject);

            [VtblIndex(13)]
            HRESULT GetEmbedded([NativeTypeName("LONG")] int acpPos, [NativeTypeName("const GUID &")] Guid* rguidService, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk);

            [VtblIndex(14)]
            HRESULT QueryInsertEmbedded([NativeTypeName("const GUID *")] Guid* pguidService, [NativeTypeName("const FORMATETC *")] FORMATETC* pFormatEtc, BOOL* pfInsertable);

            [VtblIndex(15)]
            HRESULT InsertEmbedded([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, IDataObject* pDataObject, TS_TEXTCHANGE* pChange);

            [VtblIndex(16)]
            HRESULT InsertTextAtSelection([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const WCHAR *")] ushort* pchText, [NativeTypeName("ULONG")] uint cch, [NativeTypeName("LONG *")] int* pacpStart, [NativeTypeName("LONG *")] int* pacpEnd, TS_TEXTCHANGE* pChange);

            [VtblIndex(17)]
            HRESULT InsertEmbeddedAtSelection([NativeTypeName("DWORD")] uint dwFlags, IDataObject* pDataObject, [NativeTypeName("LONG *")] int* pacpStart, [NativeTypeName("LONG *")] int* pacpEnd, TS_TEXTCHANGE* pChange);

            [VtblIndex(18)]
            HRESULT RequestSupportedAttrs([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG")] uint cFilterAttrs, [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs);

            [VtblIndex(19)]
            HRESULT RequestAttrsAtPosition([NativeTypeName("LONG")] int acpPos, [NativeTypeName("ULONG")] uint cFilterAttrs, [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs, [NativeTypeName("DWORD")] uint dwFlags);

            [VtblIndex(20)]
            HRESULT RequestAttrsTransitioningAtPosition([NativeTypeName("LONG")] int acpPos, [NativeTypeName("ULONG")] uint cFilterAttrs, [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs, [NativeTypeName("DWORD")] uint dwFlags);

            [VtblIndex(21)]
            HRESULT FindNextAttrTransition([NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpHalt, [NativeTypeName("ULONG")] uint cFilterAttrs, [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONG *")] int* pacpNext, BOOL* pfFound, [NativeTypeName("LONG *")] int* plFoundOffset);

            [VtblIndex(22)]
            HRESULT RetrieveRequestedAttrs([NativeTypeName("ULONG")] uint ulCount, TS_ATTRVAL* paAttrVals, [NativeTypeName("ULONG *")] uint* pcFetched);

            [VtblIndex(23)]
            HRESULT GetEndACP([NativeTypeName("LONG *")] int* pacp);

            [VtblIndex(24)]
            HRESULT GetActiveView([NativeTypeName("TsViewCookie *")] uint* pvcView);

            [VtblIndex(25)]
            HRESULT GetACPFromPoint([NativeTypeName("TsViewCookie")] uint vcView, [NativeTypeName("const POINT *")] POINT* ptScreen, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONG *")] int* pacp);

            [VtblIndex(26)]
            HRESULT GetTextExt([NativeTypeName("TsViewCookie")] uint vcView, [NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, RECT* prc, BOOL* pfClipped);

            [VtblIndex(27)]
            HRESULT GetScreenExt([NativeTypeName("TsViewCookie")] uint vcView, RECT* prc);

            [VtblIndex(28)]
            HRESULT GetWnd([NativeTypeName("TsViewCookie")] uint vcView, HWND* phwnd);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreACP*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreACP*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreACP*, uint> Release;

            [NativeTypeName("HRESULT (const IID &, IUnknown *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreACP*, Guid*, IUnknown*, uint, int> AdviseSink;

            [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreACP*, IUnknown*, int> UnadviseSink;

            [NativeTypeName("HRESULT (DWORD, HRESULT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreACP*, uint, HRESULT*, int> RequestLock;

            [NativeTypeName("HRESULT (TS_STATUS *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreACP*, TS_STATUS*, int> GetStatus;

            [NativeTypeName("HRESULT (LONG, LONG, ULONG, LONG *, LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreACP*, int, int, uint, int*, int*, int> QueryInsert;

            [NativeTypeName("HRESULT (ULONG, ULONG, TS_SELECTION_ACP *, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreACP*, uint, uint, TS_SELECTION_ACP*, uint*, int> GetSelection;

            [NativeTypeName("HRESULT (ULONG, const TS_SELECTION_ACP *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreACP*, uint, TS_SELECTION_ACP*, int> SetSelection;

            [NativeTypeName("HRESULT (LONG, LONG, WCHAR *, ULONG, ULONG *, TS_RUNINFO *, ULONG, ULONG *, LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreACP*, int, int, ushort*, uint, uint*, TS_RUNINFO*, uint, uint*, int*, int> GetText;

            [NativeTypeName("HRESULT (DWORD, LONG, LONG, const WCHAR *, ULONG, TS_TEXTCHANGE *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreACP*, uint, int, int, ushort*, uint, TS_TEXTCHANGE*, int> SetText;

            [NativeTypeName("HRESULT (LONG, LONG, IDataObject **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreACP*, int, int, IDataObject**, int> GetFormattedText;

            [NativeTypeName("HRESULT (LONG, const GUID &, const IID &, IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreACP*, int, Guid*, Guid*, IUnknown**, int> GetEmbedded;

            [NativeTypeName("HRESULT (const GUID *, const FORMATETC *, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreACP*, Guid*, FORMATETC*, BOOL*, int> QueryInsertEmbedded;

            [NativeTypeName("HRESULT (DWORD, LONG, LONG, IDataObject *, TS_TEXTCHANGE *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreACP*, uint, int, int, IDataObject*, TS_TEXTCHANGE*, int> InsertEmbedded;

            [NativeTypeName("HRESULT (DWORD, const WCHAR *, ULONG, LONG *, LONG *, TS_TEXTCHANGE *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreACP*, uint, ushort*, uint, int*, int*, TS_TEXTCHANGE*, int> InsertTextAtSelection;

            [NativeTypeName("HRESULT (DWORD, IDataObject *, LONG *, LONG *, TS_TEXTCHANGE *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreACP*, uint, IDataObject*, int*, int*, TS_TEXTCHANGE*, int> InsertEmbeddedAtSelection;

            [NativeTypeName("HRESULT (DWORD, ULONG, const TS_ATTRID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreACP*, uint, uint, Guid*, int> RequestSupportedAttrs;

            [NativeTypeName("HRESULT (LONG, ULONG, const TS_ATTRID *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreACP*, int, uint, Guid*, uint, int> RequestAttrsAtPosition;

            [NativeTypeName("HRESULT (LONG, ULONG, const TS_ATTRID *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreACP*, int, uint, Guid*, uint, int> RequestAttrsTransitioningAtPosition;

            [NativeTypeName("HRESULT (LONG, LONG, ULONG, const TS_ATTRID *, DWORD, LONG *, BOOL *, LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreACP*, int, int, uint, Guid*, uint, int*, BOOL*, int*, int> FindNextAttrTransition;

            [NativeTypeName("HRESULT (ULONG, TS_ATTRVAL *, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreACP*, uint, TS_ATTRVAL*, uint*, int> RetrieveRequestedAttrs;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreACP*, int*, int> GetEndACP;

            [NativeTypeName("HRESULT (TsViewCookie *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreACP*, uint*, int> GetActiveView;

            [NativeTypeName("HRESULT (TsViewCookie, const POINT *, DWORD, LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreACP*, uint, POINT*, uint, int*, int> GetACPFromPoint;

            [NativeTypeName("HRESULT (TsViewCookie, LONG, LONG, RECT *, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreACP*, uint, int, int, RECT*, BOOL*, int> GetTextExt;

            [NativeTypeName("HRESULT (TsViewCookie, RECT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreACP*, uint, RECT*, int> GetScreenExt;

            [NativeTypeName("HRESULT (TsViewCookie, HWND *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreACP*, uint, HWND*, int> GetWnd;
        }
    }
}
