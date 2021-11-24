// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("3050F662-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLEditDesigner : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IHTMLEditDesigner : IHTMLEditDesigner.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLEditDesigner*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLEditDesigner*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLEditDesigner*, uint>)(lpVtbl[1]))((IHTMLEditDesigner*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLEditDesigner*, uint>)(lpVtbl[2]))((IHTMLEditDesigner*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT PreHandleEvent([NativeTypeName("DISPID")] int inEvtDispId, IHTMLEventObj* pIEventObj)
    {
        return ((delegate* unmanaged<IHTMLEditDesigner*, int, IHTMLEventObj*, int>)(lpVtbl[3]))((IHTMLEditDesigner*)Unsafe.AsPointer(ref this), inEvtDispId, pIEventObj);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT PostHandleEvent([NativeTypeName("DISPID")] int inEvtDispId, IHTMLEventObj* pIEventObj)
    {
        return ((delegate* unmanaged<IHTMLEditDesigner*, int, IHTMLEventObj*, int>)(lpVtbl[4]))((IHTMLEditDesigner*)Unsafe.AsPointer(ref this), inEvtDispId, pIEventObj);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT TranslateAcceleratorW([NativeTypeName("DISPID")] int inEvtDispId, IHTMLEventObj* pIEventObj)
    {
        return ((delegate* unmanaged<IHTMLEditDesigner*, int, IHTMLEventObj*, int>)(lpVtbl[5]))((IHTMLEditDesigner*)Unsafe.AsPointer(ref this), inEvtDispId, pIEventObj);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT PostEditorEventNotify([NativeTypeName("DISPID")] int inEvtDispId, IHTMLEventObj* pIEventObj)
    {
        return ((delegate* unmanaged<IHTMLEditDesigner*, int, IHTMLEventObj*, int>)(lpVtbl[6]))((IHTMLEditDesigner*)Unsafe.AsPointer(ref this), inEvtDispId, pIEventObj);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT PreHandleEvent([NativeTypeName("DISPID")] int inEvtDispId, IHTMLEventObj* pIEventObj);

        [VtblIndex(4)]
        HRESULT PostHandleEvent([NativeTypeName("DISPID")] int inEvtDispId, IHTMLEventObj* pIEventObj);

        [VtblIndex(5)]
        HRESULT TranslateAcceleratorW([NativeTypeName("DISPID")] int inEvtDispId, IHTMLEventObj* pIEventObj);

        [VtblIndex(6)]
        HRESULT PostEditorEventNotify([NativeTypeName("DISPID")] int inEvtDispId, IHTMLEventObj* pIEventObj);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IHTMLEditDesigner*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IHTMLEditDesigner*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IHTMLEditDesigner*, uint> Release;

        [NativeTypeName("HRESULT (DISPID, IHTMLEventObj *) __attribute__((stdcall))")]
        public delegate* unmanaged<IHTMLEditDesigner*, int, IHTMLEventObj*, int> PreHandleEvent;

        [NativeTypeName("HRESULT (DISPID, IHTMLEventObj *) __attribute__((stdcall))")]
        public delegate* unmanaged<IHTMLEditDesigner*, int, IHTMLEventObj*, int> PostHandleEvent;

        [NativeTypeName("HRESULT (DISPID, IHTMLEventObj *) __attribute__((stdcall))")]
        public delegate* unmanaged<IHTMLEditDesigner*, int, IHTMLEventObj*, int> TranslateAcceleratorW;

        [NativeTypeName("HRESULT (DISPID, IHTMLEventObj *) __attribute__((stdcall))")]
        public delegate* unmanaged<IHTMLEditDesigner*, int, IHTMLEventObj*, int> PostEditorEventNotify;
    }
}
