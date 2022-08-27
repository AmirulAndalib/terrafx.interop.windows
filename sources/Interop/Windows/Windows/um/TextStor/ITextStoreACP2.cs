// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/TextStor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='ITextStoreACP2.xml' path='doc/member[@name="ITextStoreACP2"]/*' />
[Guid("F86AD89F-5FE4-4B8D-BB9F-EF3797A84F1F")]
[NativeTypeName("struct ITextStoreACP2 : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct ITextStoreACP2 : ITextStoreACP2.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITextStoreACP2*, Guid*, void**, int>)(lpVtbl[0]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITextStoreACP2*, uint>)(lpVtbl[1]))((ITextStoreACP2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITextStoreACP2*, uint>)(lpVtbl[2]))((ITextStoreACP2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITextStoreACP2.xml' path='doc/member[@name="ITextStoreACP2.AdviseSink"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AdviseSink([NativeTypeName("const IID &")] Guid* riid, IUnknown* punk, [NativeTypeName("DWORD")] uint dwMask)
    {
        return ((delegate* unmanaged<ITextStoreACP2*, Guid*, IUnknown*, uint, int>)(lpVtbl[3]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), riid, punk, dwMask);
    }

    /// <include file='ITextStoreACP2.xml' path='doc/member[@name="ITextStoreACP2.UnadviseSink"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnadviseSink(IUnknown* punk)
    {
        return ((delegate* unmanaged<ITextStoreACP2*, IUnknown*, int>)(lpVtbl[4]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), punk);
    }

    /// <include file='ITextStoreACP2.xml' path='doc/member[@name="ITextStoreACP2.RequestLock"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RequestLock([NativeTypeName("DWORD")] uint dwLockFlags, HRESULT* phrSession)
    {
        return ((delegate* unmanaged<ITextStoreACP2*, uint, HRESULT*, int>)(lpVtbl[5]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), dwLockFlags, phrSession);
    }

    /// <include file='ITextStoreACP2.xml' path='doc/member[@name="ITextStoreACP2.GetStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetStatus(TS_STATUS* pdcs)
    {
        return ((delegate* unmanaged<ITextStoreACP2*, TS_STATUS*, int>)(lpVtbl[6]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), pdcs);
    }

    /// <include file='ITextStoreACP2.xml' path='doc/member[@name="ITextStoreACP2.QueryInsert"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT QueryInsert([NativeTypeName("LONG")] int acpTestStart, [NativeTypeName("LONG")] int acpTestEnd, [NativeTypeName("ULONG")] uint cch, [NativeTypeName("LONG *")] int* pacpResultStart, [NativeTypeName("LONG *")] int* pacpResultEnd)
    {
        return ((delegate* unmanaged<ITextStoreACP2*, int, int, uint, int*, int*, int>)(lpVtbl[7]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), acpTestStart, acpTestEnd, cch, pacpResultStart, pacpResultEnd);
    }

    /// <include file='ITextStoreACP2.xml' path='doc/member[@name="ITextStoreACP2.GetSelection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetSelection([NativeTypeName("ULONG")] uint ulIndex, [NativeTypeName("ULONG")] uint ulCount, TS_SELECTION_ACP* pSelection, [NativeTypeName("ULONG *")] uint* pcFetched)
    {
        return ((delegate* unmanaged<ITextStoreACP2*, uint, uint, TS_SELECTION_ACP*, uint*, int>)(lpVtbl[8]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), ulIndex, ulCount, pSelection, pcFetched);
    }

    /// <include file='ITextStoreACP2.xml' path='doc/member[@name="ITextStoreACP2.SetSelection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetSelection([NativeTypeName("ULONG")] uint ulCount, [NativeTypeName("const TS_SELECTION_ACP *")] TS_SELECTION_ACP* pSelection)
    {
        return ((delegate* unmanaged<ITextStoreACP2*, uint, TS_SELECTION_ACP*, int>)(lpVtbl[9]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), ulCount, pSelection);
    }

    /// <include file='ITextStoreACP2.xml' path='doc/member[@name="ITextStoreACP2.GetText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetText([NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, [NativeTypeName("WCHAR *")] ushort* pchPlain, [NativeTypeName("ULONG")] uint cchPlainReq, [NativeTypeName("ULONG *")] uint* pcchPlainRet, TS_RUNINFO* prgRunInfo, [NativeTypeName("ULONG")] uint cRunInfoReq, [NativeTypeName("ULONG *")] uint* pcRunInfoRet, [NativeTypeName("LONG *")] int* pacpNext)
    {
        return ((delegate* unmanaged<ITextStoreACP2*, int, int, ushort*, uint, uint*, TS_RUNINFO*, uint, uint*, int*, int>)(lpVtbl[10]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), acpStart, acpEnd, pchPlain, cchPlainReq, pcchPlainRet, prgRunInfo, cRunInfoReq, pcRunInfoRet, pacpNext);
    }

    /// <include file='ITextStoreACP2.xml' path='doc/member[@name="ITextStoreACP2.SetText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetText([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, [NativeTypeName("const WCHAR *")] ushort* pchText, [NativeTypeName("ULONG")] uint cch, TS_TEXTCHANGE* pChange)
    {
        return ((delegate* unmanaged<ITextStoreACP2*, uint, int, int, ushort*, uint, TS_TEXTCHANGE*, int>)(lpVtbl[11]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), dwFlags, acpStart, acpEnd, pchText, cch, pChange);
    }

    /// <include file='ITextStoreACP2.xml' path='doc/member[@name="ITextStoreACP2.GetFormattedText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetFormattedText([NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, IDataObject** ppDataObject)
    {
        return ((delegate* unmanaged<ITextStoreACP2*, int, int, IDataObject**, int>)(lpVtbl[12]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), acpStart, acpEnd, ppDataObject);
    }

    /// <include file='ITextStoreACP2.xml' path='doc/member[@name="ITextStoreACP2.GetEmbedded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetEmbedded([NativeTypeName("LONG")] int acpPos, [NativeTypeName("const GUID &")] Guid* rguidService, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk)
    {
        return ((delegate* unmanaged<ITextStoreACP2*, int, Guid*, Guid*, IUnknown**, int>)(lpVtbl[13]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), acpPos, rguidService, riid, ppunk);
    }

    /// <include file='ITextStoreACP2.xml' path='doc/member[@name="ITextStoreACP2.QueryInsertEmbedded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT QueryInsertEmbedded([NativeTypeName("const GUID *")] Guid* pguidService, [NativeTypeName("const FORMATETC *")] FORMATETC* pFormatEtc, BOOL* pfInsertable)
    {
        return ((delegate* unmanaged<ITextStoreACP2*, Guid*, FORMATETC*, BOOL*, int>)(lpVtbl[14]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), pguidService, pFormatEtc, pfInsertable);
    }

    /// <include file='ITextStoreACP2.xml' path='doc/member[@name="ITextStoreACP2.InsertEmbedded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT InsertEmbedded([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, IDataObject* pDataObject, TS_TEXTCHANGE* pChange)
    {
        return ((delegate* unmanaged<ITextStoreACP2*, uint, int, int, IDataObject*, TS_TEXTCHANGE*, int>)(lpVtbl[15]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), dwFlags, acpStart, acpEnd, pDataObject, pChange);
    }

    /// <include file='ITextStoreACP2.xml' path='doc/member[@name="ITextStoreACP2.InsertTextAtSelection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT InsertTextAtSelection([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const WCHAR *")] ushort* pchText, [NativeTypeName("ULONG")] uint cch, [NativeTypeName("LONG *")] int* pacpStart, [NativeTypeName("LONG *")] int* pacpEnd, TS_TEXTCHANGE* pChange)
    {
        return ((delegate* unmanaged<ITextStoreACP2*, uint, ushort*, uint, int*, int*, TS_TEXTCHANGE*, int>)(lpVtbl[16]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), dwFlags, pchText, cch, pacpStart, pacpEnd, pChange);
    }

    /// <include file='ITextStoreACP2.xml' path='doc/member[@name="ITextStoreACP2.InsertEmbeddedAtSelection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT InsertEmbeddedAtSelection([NativeTypeName("DWORD")] uint dwFlags, IDataObject* pDataObject, [NativeTypeName("LONG *")] int* pacpStart, [NativeTypeName("LONG *")] int* pacpEnd, TS_TEXTCHANGE* pChange)
    {
        return ((delegate* unmanaged<ITextStoreACP2*, uint, IDataObject*, int*, int*, TS_TEXTCHANGE*, int>)(lpVtbl[17]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), dwFlags, pDataObject, pacpStart, pacpEnd, pChange);
    }

    /// <include file='ITextStoreACP2.xml' path='doc/member[@name="ITextStoreACP2.RequestSupportedAttrs"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT RequestSupportedAttrs([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG")] uint cFilterAttrs, [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs)
    {
        return ((delegate* unmanaged<ITextStoreACP2*, uint, uint, Guid*, int>)(lpVtbl[18]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), dwFlags, cFilterAttrs, paFilterAttrs);
    }

    /// <include file='ITextStoreACP2.xml' path='doc/member[@name="ITextStoreACP2.RequestAttrsAtPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT RequestAttrsAtPosition([NativeTypeName("LONG")] int acpPos, [NativeTypeName("ULONG")] uint cFilterAttrs, [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<ITextStoreACP2*, int, uint, Guid*, uint, int>)(lpVtbl[19]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), acpPos, cFilterAttrs, paFilterAttrs, dwFlags);
    }

    /// <include file='ITextStoreACP2.xml' path='doc/member[@name="ITextStoreACP2.RequestAttrsTransitioningAtPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT RequestAttrsTransitioningAtPosition([NativeTypeName("LONG")] int acpPos, [NativeTypeName("ULONG")] uint cFilterAttrs, [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<ITextStoreACP2*, int, uint, Guid*, uint, int>)(lpVtbl[20]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), acpPos, cFilterAttrs, paFilterAttrs, dwFlags);
    }

    /// <include file='ITextStoreACP2.xml' path='doc/member[@name="ITextStoreACP2.FindNextAttrTransition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT FindNextAttrTransition([NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpHalt, [NativeTypeName("ULONG")] uint cFilterAttrs, [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONG *")] int* pacpNext, BOOL* pfFound, [NativeTypeName("LONG *")] int* plFoundOffset)
    {
        return ((delegate* unmanaged<ITextStoreACP2*, int, int, uint, Guid*, uint, int*, BOOL*, int*, int>)(lpVtbl[21]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), acpStart, acpHalt, cFilterAttrs, paFilterAttrs, dwFlags, pacpNext, pfFound, plFoundOffset);
    }

    /// <include file='ITextStoreACP2.xml' path='doc/member[@name="ITextStoreACP2.RetrieveRequestedAttrs"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT RetrieveRequestedAttrs([NativeTypeName("ULONG")] uint ulCount, TS_ATTRVAL* paAttrVals, [NativeTypeName("ULONG *")] uint* pcFetched)
    {
        return ((delegate* unmanaged<ITextStoreACP2*, uint, TS_ATTRVAL*, uint*, int>)(lpVtbl[22]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), ulCount, paAttrVals, pcFetched);
    }

    /// <include file='ITextStoreACP2.xml' path='doc/member[@name="ITextStoreACP2.GetEndACP"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetEndACP([NativeTypeName("LONG *")] int* pacp)
    {
        return ((delegate* unmanaged<ITextStoreACP2*, int*, int>)(lpVtbl[23]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), pacp);
    }

    /// <include file='ITextStoreACP2.xml' path='doc/member[@name="ITextStoreACP2.GetActiveView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetActiveView([NativeTypeName("TsViewCookie *")] uint* pvcView)
    {
        return ((delegate* unmanaged<ITextStoreACP2*, uint*, int>)(lpVtbl[24]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), pvcView);
    }

    /// <include file='ITextStoreACP2.xml' path='doc/member[@name="ITextStoreACP2.GetACPFromPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetACPFromPoint([NativeTypeName("TsViewCookie")] uint vcView, [NativeTypeName("const POINT *")] POINT* ptScreen, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONG *")] int* pacp)
    {
        return ((delegate* unmanaged<ITextStoreACP2*, uint, POINT*, uint, int*, int>)(lpVtbl[25]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), vcView, ptScreen, dwFlags, pacp);
    }

    /// <include file='ITextStoreACP2.xml' path='doc/member[@name="ITextStoreACP2.GetTextExt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetTextExt([NativeTypeName("TsViewCookie")] uint vcView, [NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, RECT* prc, BOOL* pfClipped)
    {
        return ((delegate* unmanaged<ITextStoreACP2*, uint, int, int, RECT*, BOOL*, int>)(lpVtbl[26]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), vcView, acpStart, acpEnd, prc, pfClipped);
    }

    /// <include file='ITextStoreACP2.xml' path='doc/member[@name="ITextStoreACP2.GetScreenExt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT GetScreenExt([NativeTypeName("TsViewCookie")] uint vcView, RECT* prc)
    {
        return ((delegate* unmanaged<ITextStoreACP2*, uint, RECT*, int>)(lpVtbl[27]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), vcView, prc);
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

        [NativeTypeName("HRESULT (const IID &, IUnknown *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, uint, int> AdviseSink;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> UnadviseSink;

        [NativeTypeName("HRESULT (DWORD, HRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, HRESULT*, int> RequestLock;

        [NativeTypeName("HRESULT (TS_STATUS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TS_STATUS*, int> GetStatus;

        [NativeTypeName("HRESULT (LONG, LONG, ULONG, LONG *, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, uint, int*, int*, int> QueryInsert;

        [NativeTypeName("HRESULT (ULONG, ULONG, TS_SELECTION_ACP *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, TS_SELECTION_ACP*, uint*, int> GetSelection;

        [NativeTypeName("HRESULT (ULONG, const TS_SELECTION_ACP *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, TS_SELECTION_ACP*, int> SetSelection;

        [NativeTypeName("HRESULT (LONG, LONG, WCHAR *, ULONG, ULONG *, TS_RUNINFO *, ULONG, ULONG *, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, ushort*, uint, uint*, TS_RUNINFO*, uint, uint*, int*, int> GetText;

        [NativeTypeName("HRESULT (DWORD, LONG, LONG, const WCHAR *, ULONG, TS_TEXTCHANGE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int, int, ushort*, uint, TS_TEXTCHANGE*, int> SetText;

        [NativeTypeName("HRESULT (LONG, LONG, IDataObject **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, IDataObject**, int> GetFormattedText;

        [NativeTypeName("HRESULT (LONG, const GUID &, const IID &, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, Guid*, IUnknown**, int> GetEmbedded;

        [NativeTypeName("HRESULT (const GUID *, const FORMATETC *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, FORMATETC*, BOOL*, int> QueryInsertEmbedded;

        [NativeTypeName("HRESULT (DWORD, LONG, LONG, IDataObject *, TS_TEXTCHANGE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int, int, IDataObject*, TS_TEXTCHANGE*, int> InsertEmbedded;

        [NativeTypeName("HRESULT (DWORD, const WCHAR *, ULONG, LONG *, LONG *, TS_TEXTCHANGE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint, int*, int*, TS_TEXTCHANGE*, int> InsertTextAtSelection;

        [NativeTypeName("HRESULT (DWORD, IDataObject *, LONG *, LONG *, TS_TEXTCHANGE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDataObject*, int*, int*, TS_TEXTCHANGE*, int> InsertEmbeddedAtSelection;

        [NativeTypeName("HRESULT (DWORD, ULONG, const TS_ATTRID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, Guid*, int> RequestSupportedAttrs;

        [NativeTypeName("HRESULT (LONG, ULONG, const TS_ATTRID *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, uint, Guid*, uint, int> RequestAttrsAtPosition;

        [NativeTypeName("HRESULT (LONG, ULONG, const TS_ATTRID *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, uint, Guid*, uint, int> RequestAttrsTransitioningAtPosition;

        [NativeTypeName("HRESULT (LONG, LONG, ULONG, const TS_ATTRID *, DWORD, LONG *, BOOL *, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, uint, Guid*, uint, int*, BOOL*, int*, int> FindNextAttrTransition;

        [NativeTypeName("HRESULT (ULONG, TS_ATTRVAL *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, TS_ATTRVAL*, uint*, int> RetrieveRequestedAttrs;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetEndACP;

        [NativeTypeName("HRESULT (TsViewCookie *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetActiveView;

        [NativeTypeName("HRESULT (TsViewCookie, const POINT *, DWORD, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, POINT*, uint, int*, int> GetACPFromPoint;

        [NativeTypeName("HRESULT (TsViewCookie, LONG, LONG, RECT *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int, int, RECT*, BOOL*, int> GetTextExt;

        [NativeTypeName("HRESULT (TsViewCookie, RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, RECT*, int> GetScreenExt;
    }
}
