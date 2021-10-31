// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EC39FA88-F8AF-41C5-8421-38BED28F4673")]
    [NativeTypeName("struct IShellView3 : IShellView2")]
    [NativeInheritance("IShellView2")]
    public unsafe partial struct IShellView3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellView3*, Guid*, void**, int>)(lpVtbl[0]))((IShellView3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellView3*, uint>)(lpVtbl[1]))((IShellView3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellView3*, uint>)(lpVtbl[2]))((IShellView3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetWindow(HWND* phwnd)
        {
            return ((delegate* unmanaged<IShellView3*, HWND*, int>)(lpVtbl[3]))((IShellView3*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
        {
            return ((delegate* unmanaged<IShellView3*, BOOL, int>)(lpVtbl[4]))((IShellView3*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT TranslateAcceleratorW(MSG* pmsg)
        {
            return ((delegate* unmanaged<IShellView3*, MSG*, int>)(lpVtbl[5]))((IShellView3*)Unsafe.AsPointer(ref this), pmsg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT EnableModeless(BOOL fEnable)
        {
            return ((delegate* unmanaged<IShellView3*, BOOL, int>)(lpVtbl[6]))((IShellView3*)Unsafe.AsPointer(ref this), fEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT UIActivate(uint uState)
        {
            return ((delegate* unmanaged<IShellView3*, uint, int>)(lpVtbl[7]))((IShellView3*)Unsafe.AsPointer(ref this), uState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Refresh()
        {
            return ((delegate* unmanaged<IShellView3*, int>)(lpVtbl[8]))((IShellView3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT CreateViewWindow(IShellView* psvPrevious, [NativeTypeName("LPCFOLDERSETTINGS")] FOLDERSETTINGS* pfs, IShellBrowser* psb, RECT* prcView, HWND* phWnd)
        {
            return ((delegate* unmanaged<IShellView3*, IShellView*, FOLDERSETTINGS*, IShellBrowser*, RECT*, HWND*, int>)(lpVtbl[9]))((IShellView3*)Unsafe.AsPointer(ref this), psvPrevious, pfs, psb, prcView, phWnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT DestroyViewWindow()
        {
            return ((delegate* unmanaged<IShellView3*, int>)(lpVtbl[10]))((IShellView3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetCurrentInfo([NativeTypeName("LPFOLDERSETTINGS")] FOLDERSETTINGS* pfs)
        {
            return ((delegate* unmanaged<IShellView3*, FOLDERSETTINGS*, int>)(lpVtbl[11]))((IShellView3*)Unsafe.AsPointer(ref this), pfs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT AddPropertySheetPages([NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("LPFNSVADDPROPSHEETPAGE")] delegate* unmanaged<HPROPSHEETPAGE, nint, BOOL> pfn, [NativeTypeName("LPARAM")] nint lparam)
        {
            return ((delegate* unmanaged<IShellView3*, uint, delegate* unmanaged<HPROPSHEETPAGE, nint, BOOL>, nint, int>)(lpVtbl[12]))((IShellView3*)Unsafe.AsPointer(ref this), dwReserved, pfn, lparam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT SaveViewState()
        {
            return ((delegate* unmanaged<IShellView3*, int>)(lpVtbl[13]))((IShellView3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT SelectItem([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlItem, [NativeTypeName("SVSIF")] uint uFlags)
        {
            return ((delegate* unmanaged<IShellView3*, ITEMIDLIST*, uint, int>)(lpVtbl[14]))((IShellView3*)Unsafe.AsPointer(ref this), pidlItem, uFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetItemObject(uint uItem, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IShellView3*, uint, Guid*, void**, int>)(lpVtbl[15]))((IShellView3*)Unsafe.AsPointer(ref this), uItem, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetView([NativeTypeName("SHELLVIEWID *")] Guid* pvid, [NativeTypeName("ULONG")] uint uView)
        {
            return ((delegate* unmanaged<IShellView3*, Guid*, uint, int>)(lpVtbl[16]))((IShellView3*)Unsafe.AsPointer(ref this), pvid, uView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT CreateViewWindow2([NativeTypeName("LPSV2CVW2_PARAMS")] SV2CVW2_PARAMS* lpParams)
        {
            return ((delegate* unmanaged<IShellView3*, SV2CVW2_PARAMS*, int>)(lpVtbl[17]))((IShellView3*)Unsafe.AsPointer(ref this), lpParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT HandleRename([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlNew)
        {
            return ((delegate* unmanaged<IShellView3*, ITEMIDLIST*, int>)(lpVtbl[18]))((IShellView3*)Unsafe.AsPointer(ref this), pidlNew);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT SelectAndPositionItem([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlItem, uint uFlags, POINT* ppt)
        {
            return ((delegate* unmanaged<IShellView3*, ITEMIDLIST*, uint, POINT*, int>)(lpVtbl[19]))((IShellView3*)Unsafe.AsPointer(ref this), pidlItem, uFlags, ppt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT CreateViewWindow3(IShellBrowser* psbOwner, IShellView* psvPrev, [NativeTypeName("SV3CVW3_FLAGS")] uint dwViewFlags, FOLDERFLAGS dwMask, FOLDERFLAGS dwFlags, FOLDERVIEWMODE fvMode, [NativeTypeName("const SHELLVIEWID *")] Guid* pvid, [NativeTypeName("const RECT *")] RECT* prcView, HWND* phwndView)
        {
            return ((delegate* unmanaged<IShellView3*, IShellBrowser*, IShellView*, uint, FOLDERFLAGS, FOLDERFLAGS, FOLDERVIEWMODE, Guid*, RECT*, HWND*, int>)(lpVtbl[20]))((IShellView3*)Unsafe.AsPointer(ref this), psbOwner, psvPrev, dwViewFlags, dwMask, dwFlags, fvMode, pvid, prcView, phwndView);
        }
    }
}
