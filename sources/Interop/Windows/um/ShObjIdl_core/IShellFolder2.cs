// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("93F2F68C-1D1B-11D3-A30E-00C04F79ABD1")]
    [NativeTypeName("struct IShellFolder2 : IShellFolder")]
    [NativeInheritance("IShellFolder")]
    public unsafe partial struct IShellFolder2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellFolder2*, Guid*, void**, int>)(lpVtbl[0]))((IShellFolder2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellFolder2*, uint>)(lpVtbl[1]))((IShellFolder2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellFolder2*, uint>)(lpVtbl[2]))((IShellFolder2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT ParseDisplayName(HWND hwnd, IBindCtx* pbc, [NativeTypeName("LPWSTR")] ushort* pszDisplayName, [NativeTypeName("ULONG *")] uint* pchEaten, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl, [NativeTypeName("ULONG *")] uint* pdwAttributes)
        {
            return ((delegate* unmanaged<IShellFolder2*, HWND, IBindCtx*, ushort*, uint*, ITEMIDLIST**, uint*, int>)(lpVtbl[3]))((IShellFolder2*)Unsafe.AsPointer(ref this), hwnd, pbc, pszDisplayName, pchEaten, ppidl, pdwAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT EnumObjects(HWND hwnd, [NativeTypeName("SHCONTF")] uint grfFlags, IEnumIDList** ppenumIDList)
        {
            return ((delegate* unmanaged<IShellFolder2*, HWND, uint, IEnumIDList**, int>)(lpVtbl[4]))((IShellFolder2*)Unsafe.AsPointer(ref this), hwnd, grfFlags, ppenumIDList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT BindToObject([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IShellFolder2*, ITEMIDLIST*, IBindCtx*, Guid*, void**, int>)(lpVtbl[5]))((IShellFolder2*)Unsafe.AsPointer(ref this), pidl, pbc, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT BindToStorage([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IShellFolder2*, ITEMIDLIST*, IBindCtx*, Guid*, void**, int>)(lpVtbl[6]))((IShellFolder2*)Unsafe.AsPointer(ref this), pidl, pbc, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT CompareIDs([NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl1, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl2)
        {
            return ((delegate* unmanaged<IShellFolder2*, nint, ITEMIDLIST*, ITEMIDLIST*, int>)(lpVtbl[7]))((IShellFolder2*)Unsafe.AsPointer(ref this), lParam, pidl1, pidl2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT CreateViewObject(HWND hwndOwner, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IShellFolder2*, HWND, Guid*, void**, int>)(lpVtbl[8]))((IShellFolder2*)Unsafe.AsPointer(ref this), hwndOwner, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetAttributesOf(uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl, [NativeTypeName("SFGAOF *")] uint* rgfInOut)
        {
            return ((delegate* unmanaged<IShellFolder2*, uint, ITEMIDLIST**, uint*, int>)(lpVtbl[9]))((IShellFolder2*)Unsafe.AsPointer(ref this), cidl, apidl, rgfInOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetUIObjectOf(HWND hwndOwner, uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl, [NativeTypeName("const IID &")] Guid* riid, uint* rgfReserved, void** ppv)
        {
            return ((delegate* unmanaged<IShellFolder2*, HWND, uint, ITEMIDLIST**, Guid*, uint*, void**, int>)(lpVtbl[10]))((IShellFolder2*)Unsafe.AsPointer(ref this), hwndOwner, cidl, apidl, riid, rgfReserved, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetDisplayNameOf([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("SHGDNF")] uint uFlags, STRRET* pName)
        {
            return ((delegate* unmanaged<IShellFolder2*, ITEMIDLIST*, uint, STRRET*, int>)(lpVtbl[11]))((IShellFolder2*)Unsafe.AsPointer(ref this), pidl, uFlags, pName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SetNameOf(HWND hwnd, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("SHGDNF")] uint uFlags, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlOut)
        {
            return ((delegate* unmanaged<IShellFolder2*, HWND, ITEMIDLIST*, ushort*, uint, ITEMIDLIST**, int>)(lpVtbl[12]))((IShellFolder2*)Unsafe.AsPointer(ref this), hwnd, pidl, pszName, uFlags, ppidlOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetDefaultSearchGUID(Guid* pguid)
        {
            return ((delegate* unmanaged<IShellFolder2*, Guid*, int>)(lpVtbl[13]))((IShellFolder2*)Unsafe.AsPointer(ref this), pguid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT EnumSearches(IEnumExtraSearch** ppenum)
        {
            return ((delegate* unmanaged<IShellFolder2*, IEnumExtraSearch**, int>)(lpVtbl[14]))((IShellFolder2*)Unsafe.AsPointer(ref this), ppenum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetDefaultColumn([NativeTypeName("DWORD")] uint dwRes, [NativeTypeName("ULONG *")] uint* pSort, [NativeTypeName("ULONG *")] uint* pDisplay)
        {
            return ((delegate* unmanaged<IShellFolder2*, uint, uint*, uint*, int>)(lpVtbl[15]))((IShellFolder2*)Unsafe.AsPointer(ref this), dwRes, pSort, pDisplay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetDefaultColumnState(uint iColumn, [NativeTypeName("SHCOLSTATEF *")] uint* pcsFlags)
        {
            return ((delegate* unmanaged<IShellFolder2*, uint, uint*, int>)(lpVtbl[16]))((IShellFolder2*)Unsafe.AsPointer(ref this), iColumn, pcsFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetDetailsEx([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("const SHCOLUMNID *")] PROPERTYKEY* pscid, VARIANT* pv)
        {
            return ((delegate* unmanaged<IShellFolder2*, ITEMIDLIST*, PROPERTYKEY*, VARIANT*, int>)(lpVtbl[17]))((IShellFolder2*)Unsafe.AsPointer(ref this), pidl, pscid, pv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetDetailsOf([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, uint iColumn, SHELLDETAILS* psd)
        {
            return ((delegate* unmanaged<IShellFolder2*, ITEMIDLIST*, uint, SHELLDETAILS*, int>)(lpVtbl[18]))((IShellFolder2*)Unsafe.AsPointer(ref this), pidl, iColumn, psd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT MapColumnToSCID(uint iColumn, [NativeTypeName("SHCOLUMNID *")] PROPERTYKEY* pscid)
        {
            return ((delegate* unmanaged<IShellFolder2*, uint, PROPERTYKEY*, int>)(lpVtbl[19]))((IShellFolder2*)Unsafe.AsPointer(ref this), iColumn, pscid);
        }
    }
}
