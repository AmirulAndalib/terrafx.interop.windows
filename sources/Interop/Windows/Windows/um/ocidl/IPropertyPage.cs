// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("B196B28D-BAB4-101A-B69C-00AA00341D07")]
    [NativeTypeName("struct IPropertyPage : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPropertyPage : IPropertyPage.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPropertyPage*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyPage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPropertyPage*, uint>)(lpVtbl[1]))((IPropertyPage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPropertyPage*, uint>)(lpVtbl[2]))((IPropertyPage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetPageSite(IPropertyPageSite* pPageSite)
        {
            return ((delegate* unmanaged<IPropertyPage*, IPropertyPageSite*, int>)(lpVtbl[3]))((IPropertyPage*)Unsafe.AsPointer(ref this), pPageSite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Activate(HWND hWndParent, [NativeTypeName("LPCRECT")] RECT* pRect, BOOL bModal)
        {
            return ((delegate* unmanaged<IPropertyPage*, HWND, RECT*, BOOL, int>)(lpVtbl[4]))((IPropertyPage*)Unsafe.AsPointer(ref this), hWndParent, pRect, bModal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Deactivate()
        {
            return ((delegate* unmanaged<IPropertyPage*, int>)(lpVtbl[5]))((IPropertyPage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetPageInfo(PROPPAGEINFO* pPageInfo)
        {
            return ((delegate* unmanaged<IPropertyPage*, PROPPAGEINFO*, int>)(lpVtbl[6]))((IPropertyPage*)Unsafe.AsPointer(ref this), pPageInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetObjects([NativeTypeName("ULONG")] uint cObjects, IUnknown** ppUnk)
        {
            return ((delegate* unmanaged<IPropertyPage*, uint, IUnknown**, int>)(lpVtbl[7]))((IPropertyPage*)Unsafe.AsPointer(ref this), cObjects, ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Show(uint nCmdShow)
        {
            return ((delegate* unmanaged<IPropertyPage*, uint, int>)(lpVtbl[8]))((IPropertyPage*)Unsafe.AsPointer(ref this), nCmdShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Move([NativeTypeName("LPCRECT")] RECT* pRect)
        {
            return ((delegate* unmanaged<IPropertyPage*, RECT*, int>)(lpVtbl[9]))((IPropertyPage*)Unsafe.AsPointer(ref this), pRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT IsPageDirty()
        {
            return ((delegate* unmanaged<IPropertyPage*, int>)(lpVtbl[10]))((IPropertyPage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT Apply()
        {
            return ((delegate* unmanaged<IPropertyPage*, int>)(lpVtbl[11]))((IPropertyPage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT Help([NativeTypeName("LPCOLESTR")] ushort* pszHelpDir)
        {
            return ((delegate* unmanaged<IPropertyPage*, ushort*, int>)(lpVtbl[12]))((IPropertyPage*)Unsafe.AsPointer(ref this), pszHelpDir);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT TranslateAccelerator(MSG* pMsg)
        {
            return ((delegate* unmanaged<IPropertyPage*, MSG*, int>)(lpVtbl[13]))((IPropertyPage*)Unsafe.AsPointer(ref this), pMsg);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetPageSite(IPropertyPageSite* pPageSite);

            [VtblIndex(4)]
            HRESULT Activate(HWND hWndParent, [NativeTypeName("LPCRECT")] RECT* pRect, BOOL bModal);

            [VtblIndex(5)]
            HRESULT Deactivate();

            [VtblIndex(6)]
            HRESULT GetPageInfo(PROPPAGEINFO* pPageInfo);

            [VtblIndex(7)]
            HRESULT SetObjects([NativeTypeName("ULONG")] uint cObjects, IUnknown** ppUnk);

            [VtblIndex(8)]
            HRESULT Show(uint nCmdShow);

            [VtblIndex(9)]
            HRESULT Move([NativeTypeName("LPCRECT")] RECT* pRect);

            [VtblIndex(10)]
            HRESULT IsPageDirty();

            [VtblIndex(11)]
            HRESULT Apply();

            [VtblIndex(12)]
            HRESULT Help([NativeTypeName("LPCOLESTR")] ushort* pszHelpDir);

            [VtblIndex(13)]
            HRESULT TranslateAccelerator(MSG* pMsg);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyPage*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyPage*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyPage*, uint> Release;

            [NativeTypeName("HRESULT (IPropertyPageSite *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyPage*, IPropertyPageSite*, int> SetPageSite;

            [NativeTypeName("HRESULT (HWND, LPCRECT, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyPage*, HWND, RECT*, BOOL, int> Activate;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyPage*, int> Deactivate;

            [NativeTypeName("HRESULT (PROPPAGEINFO *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyPage*, PROPPAGEINFO*, int> GetPageInfo;

            [NativeTypeName("HRESULT (ULONG, IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyPage*, uint, IUnknown**, int> SetObjects;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyPage*, uint, int> Show;

            [NativeTypeName("HRESULT (LPCRECT) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyPage*, RECT*, int> Move;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyPage*, int> IsPageDirty;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyPage*, int> Apply;

            [NativeTypeName("HRESULT (LPCOLESTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyPage*, ushort*, int> Help;

            [NativeTypeName("HRESULT (MSG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyPage*, MSG*, int> TranslateAccelerator;
        }
    }
}
