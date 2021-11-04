// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("31C147B6-0ADE-4A3C-B514-DDF932EF6D17")]
    [NativeTypeName("struct IShellFolderViewDual2 : IShellFolderViewDual")]
    [NativeInheritance("IShellFolderViewDual")]
    public unsafe partial struct IShellFolderViewDual2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellFolderViewDual2*, Guid*, void**, int>)(lpVtbl[0]))((IShellFolderViewDual2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellFolderViewDual2*, uint>)(lpVtbl[1]))((IShellFolderViewDual2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellFolderViewDual2*, uint>)(lpVtbl[2]))((IShellFolderViewDual2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IShellFolderViewDual2*, uint*, int>)(lpVtbl[3]))((IShellFolderViewDual2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IShellFolderViewDual2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IShellFolderViewDual2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IShellFolderViewDual2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IShellFolderViewDual2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IShellFolderViewDual2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IShellFolderViewDual2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_Application(IDispatch** ppid)
        {
            return ((delegate* unmanaged<IShellFolderViewDual2*, IDispatch**, int>)(lpVtbl[7]))((IShellFolderViewDual2*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_Parent(IDispatch** ppid)
        {
            return ((delegate* unmanaged<IShellFolderViewDual2*, IDispatch**, int>)(lpVtbl[8]))((IShellFolderViewDual2*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_Folder(Folder** ppid)
        {
            return ((delegate* unmanaged<IShellFolderViewDual2*, Folder**, int>)(lpVtbl[9]))((IShellFolderViewDual2*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SelectedItems(FolderItems** ppid)
        {
            return ((delegate* unmanaged<IShellFolderViewDual2*, FolderItems**, int>)(lpVtbl[10]))((IShellFolderViewDual2*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_FocusedItem(FolderItem** ppid)
        {
            return ((delegate* unmanaged<IShellFolderViewDual2*, FolderItem**, int>)(lpVtbl[11]))((IShellFolderViewDual2*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SelectItem(VARIANT* pvfi, int dwFlags)
        {
            return ((delegate* unmanaged<IShellFolderViewDual2*, VARIANT*, int, int>)(lpVtbl[12]))((IShellFolderViewDual2*)Unsafe.AsPointer(ref this), pvfi, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT PopupItemMenu(FolderItem* pfi, VARIANT vx, VARIANT vy, [NativeTypeName("BSTR *")] ushort** pbs)
        {
            return ((delegate* unmanaged<IShellFolderViewDual2*, FolderItem*, VARIANT, VARIANT, ushort**, int>)(lpVtbl[13]))((IShellFolderViewDual2*)Unsafe.AsPointer(ref this), pfi, vx, vy, pbs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_Script(IDispatch** ppDisp)
        {
            return ((delegate* unmanaged<IShellFolderViewDual2*, IDispatch**, int>)(lpVtbl[14]))((IShellFolderViewDual2*)Unsafe.AsPointer(ref this), ppDisp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_ViewOptions([NativeTypeName("long *")] int* plViewOptions)
        {
            return ((delegate* unmanaged<IShellFolderViewDual2*, int*, int>)(lpVtbl[15]))((IShellFolderViewDual2*)Unsafe.AsPointer(ref this), plViewOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_CurrentViewMode(uint* pViewMode)
        {
            return ((delegate* unmanaged<IShellFolderViewDual2*, uint*, int>)(lpVtbl[16]))((IShellFolderViewDual2*)Unsafe.AsPointer(ref this), pViewMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT put_CurrentViewMode(uint ViewMode)
        {
            return ((delegate* unmanaged<IShellFolderViewDual2*, uint, int>)(lpVtbl[17]))((IShellFolderViewDual2*)Unsafe.AsPointer(ref this), ViewMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT SelectItemRelative(int iRelative)
        {
            return ((delegate* unmanaged<IShellFolderViewDual2*, int, int>)(lpVtbl[18]))((IShellFolderViewDual2*)Unsafe.AsPointer(ref this), iRelative);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderViewDual2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderViewDual2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderViewDual2*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderViewDual2*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderViewDual2*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderViewDual2*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderViewDual2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderViewDual2*, IDispatch**, int> get_Application;

            [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderViewDual2*, IDispatch**, int> get_Parent;

            [NativeTypeName("HRESULT (Folder **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderViewDual2*, Folder**, int> get_Folder;

            [NativeTypeName("HRESULT (FolderItems **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderViewDual2*, FolderItems**, int> SelectedItems;

            [NativeTypeName("HRESULT (FolderItem **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderViewDual2*, FolderItem**, int> get_FocusedItem;

            [NativeTypeName("HRESULT (VARIANT *, int) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderViewDual2*, VARIANT*, int, int> SelectItem;

            [NativeTypeName("HRESULT (FolderItem *, VARIANT, VARIANT, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderViewDual2*, FolderItem*, VARIANT, VARIANT, ushort**, int> PopupItemMenu;

            [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderViewDual2*, IDispatch**, int> get_Script;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderViewDual2*, int*, int> get_ViewOptions;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderViewDual2*, uint*, int> get_CurrentViewMode;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderViewDual2*, uint, int> put_CurrentViewMode;

            [NativeTypeName("HRESULT (int) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderViewDual2*, int, int> SelectItemRelative;
        }
    }
}
