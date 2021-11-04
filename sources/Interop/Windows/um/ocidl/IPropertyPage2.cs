// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("01E44665-24AC-101B-84ED-08002B2EC713")]
    [NativeTypeName("struct IPropertyPage2 : IPropertyPage")]
    [NativeInheritance("IPropertyPage")]
    public unsafe partial struct IPropertyPage2 : IPropertyPage2.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPropertyPage2*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyPage2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPropertyPage2*, uint>)(lpVtbl[1]))((IPropertyPage2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPropertyPage2*, uint>)(lpVtbl[2]))((IPropertyPage2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetPageSite(IPropertyPageSite* pPageSite)
        {
            return ((delegate* unmanaged<IPropertyPage2*, IPropertyPageSite*, int>)(lpVtbl[3]))((IPropertyPage2*)Unsafe.AsPointer(ref this), pPageSite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Activate(HWND hWndParent, [NativeTypeName("LPCRECT")] RECT* pRect, BOOL bModal)
        {
            return ((delegate* unmanaged<IPropertyPage2*, HWND, RECT*, BOOL, int>)(lpVtbl[4]))((IPropertyPage2*)Unsafe.AsPointer(ref this), hWndParent, pRect, bModal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Deactivate()
        {
            return ((delegate* unmanaged<IPropertyPage2*, int>)(lpVtbl[5]))((IPropertyPage2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetPageInfo(PROPPAGEINFO* pPageInfo)
        {
            return ((delegate* unmanaged<IPropertyPage2*, PROPPAGEINFO*, int>)(lpVtbl[6]))((IPropertyPage2*)Unsafe.AsPointer(ref this), pPageInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetObjects([NativeTypeName("ULONG")] uint cObjects, IUnknown** ppUnk)
        {
            return ((delegate* unmanaged<IPropertyPage2*, uint, IUnknown**, int>)(lpVtbl[7]))((IPropertyPage2*)Unsafe.AsPointer(ref this), cObjects, ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Show(uint nCmdShow)
        {
            return ((delegate* unmanaged<IPropertyPage2*, uint, int>)(lpVtbl[8]))((IPropertyPage2*)Unsafe.AsPointer(ref this), nCmdShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Move([NativeTypeName("LPCRECT")] RECT* pRect)
        {
            return ((delegate* unmanaged<IPropertyPage2*, RECT*, int>)(lpVtbl[9]))((IPropertyPage2*)Unsafe.AsPointer(ref this), pRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT IsPageDirty()
        {
            return ((delegate* unmanaged<IPropertyPage2*, int>)(lpVtbl[10]))((IPropertyPage2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT Apply()
        {
            return ((delegate* unmanaged<IPropertyPage2*, int>)(lpVtbl[11]))((IPropertyPage2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT Help([NativeTypeName("LPCOLESTR")] ushort* pszHelpDir)
        {
            return ((delegate* unmanaged<IPropertyPage2*, ushort*, int>)(lpVtbl[12]))((IPropertyPage2*)Unsafe.AsPointer(ref this), pszHelpDir);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT TranslateAccelerator(MSG* pMsg)
        {
            return ((delegate* unmanaged<IPropertyPage2*, MSG*, int>)(lpVtbl[13]))((IPropertyPage2*)Unsafe.AsPointer(ref this), pMsg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT EditProperty([NativeTypeName("DISPID")] int dispID)
        {
            return ((delegate* unmanaged<IPropertyPage2*, int, int>)(lpVtbl[14]))((IPropertyPage2*)Unsafe.AsPointer(ref this), dispID);
        }

        public interface Interface : IPropertyPage.Interface
        {
            [VtblIndex(14)]
            HRESULT EditProperty([NativeTypeName("DISPID")] int dispID);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyPage2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyPage2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyPage2*, uint> Release;

            [NativeTypeName("HRESULT (IPropertyPageSite *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyPage2*, IPropertyPageSite*, int> SetPageSite;

            [NativeTypeName("HRESULT (HWND, LPCRECT, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyPage2*, HWND, RECT*, BOOL, int> Activate;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyPage2*, int> Deactivate;

            [NativeTypeName("HRESULT (PROPPAGEINFO *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyPage2*, PROPPAGEINFO*, int> GetPageInfo;

            [NativeTypeName("HRESULT (ULONG, IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyPage2*, uint, IUnknown**, int> SetObjects;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyPage2*, uint, int> Show;

            [NativeTypeName("HRESULT (LPCRECT) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyPage2*, RECT*, int> Move;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyPage2*, int> IsPageDirty;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyPage2*, int> Apply;

            [NativeTypeName("HRESULT (LPCOLESTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyPage2*, ushort*, int> Help;

            [NativeTypeName("HRESULT (MSG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyPage2*, MSG*, int> TranslateAccelerator;

            [NativeTypeName("HRESULT (DISPID) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyPage2*, int, int> EditProperty;
        }
    }
}
