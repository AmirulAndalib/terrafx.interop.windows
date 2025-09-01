// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHTMLElementRender.xml' path='doc/member[@name="IHTMLElementRender"]/*' />
[Guid("3050F669-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLElementRender : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IHTMLElementRender : IHTMLElementRender.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHTMLElementRender);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLElementRender*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLElementRender*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLElementRender*, uint>)(lpVtbl[1]))((IHTMLElementRender*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLElementRender*, uint>)(lpVtbl[2]))((IHTMLElementRender*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLElementRender.xml' path='doc/member[@name="IHTMLElementRender.DrawToDC"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT DrawToDC(HDC hDC)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLElementRender*, HDC, int>)(lpVtbl[3]))((IHTMLElementRender*)Unsafe.AsPointer(ref this), hDC);
    }

    /// <include file='IHTMLElementRender.xml' path='doc/member[@name="IHTMLElementRender.SetDocumentPrinter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetDocumentPrinter([NativeTypeName("BSTR")] char* bstrPrinterName, HDC hDC)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLElementRender*, char*, HDC, int>)(lpVtbl[4]))((IHTMLElementRender*)Unsafe.AsPointer(ref this), bstrPrinterName, hDC);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT DrawToDC(HDC hDC);

        [VtblIndex(4)]
        HRESULT SetDocumentPrinter([NativeTypeName("BSTR")] char* bstrPrinterName, HDC hDC);
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

        [NativeTypeName("HRESULT (HDC) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HDC, int> DrawToDC;

        [NativeTypeName("HRESULT (BSTR, HDC) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, HDC, int> SetDocumentPrinter;
    }
}
