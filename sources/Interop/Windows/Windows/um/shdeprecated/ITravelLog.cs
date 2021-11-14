// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("66A9CB08-4802-11D2-A561-00A0C92DBFE8")]
    [NativeTypeName("struct ITravelLog : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITravelLog : ITravelLog.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITravelLog*, Guid*, void**, int>)(lpVtbl[0]))((ITravelLog*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITravelLog*, uint>)(lpVtbl[1]))((ITravelLog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITravelLog*, uint>)(lpVtbl[2]))((ITravelLog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AddEntry(IUnknown* punk, BOOL fIsLocalAnchor)
        {
            return ((delegate* unmanaged<ITravelLog*, IUnknown*, BOOL, int>)(lpVtbl[3]))((ITravelLog*)Unsafe.AsPointer(ref this), punk, fIsLocalAnchor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT UpdateEntry(IUnknown* punk, BOOL fIsLocalAnchor)
        {
            return ((delegate* unmanaged<ITravelLog*, IUnknown*, BOOL, int>)(lpVtbl[4]))((ITravelLog*)Unsafe.AsPointer(ref this), punk, fIsLocalAnchor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT UpdateExternal(IUnknown* punk, IUnknown* punkHLBrowseContext)
        {
            return ((delegate* unmanaged<ITravelLog*, IUnknown*, IUnknown*, int>)(lpVtbl[5]))((ITravelLog*)Unsafe.AsPointer(ref this), punk, punkHLBrowseContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Travel(IUnknown* punk, int iOffset)
        {
            return ((delegate* unmanaged<ITravelLog*, IUnknown*, int, int>)(lpVtbl[6]))((ITravelLog*)Unsafe.AsPointer(ref this), punk, iOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetTravelEntry(IUnknown* punk, int iOffset, ITravelEntry** ppte)
        {
            return ((delegate* unmanaged<ITravelLog*, IUnknown*, int, ITravelEntry**, int>)(lpVtbl[7]))((ITravelLog*)Unsafe.AsPointer(ref this), punk, iOffset, ppte);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT FindTravelEntry(IUnknown* punk, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, ITravelEntry** ppte)
        {
            return ((delegate* unmanaged<ITravelLog*, IUnknown*, ITEMIDLIST*, ITravelEntry**, int>)(lpVtbl[8]))((ITravelLog*)Unsafe.AsPointer(ref this), punk, pidl, ppte);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetToolTipText(IUnknown* punk, int iOffset, int idsTemplate, [NativeTypeName("LPWSTR")] ushort* pwzText, [NativeTypeName("DWORD")] uint cchText)
        {
            return ((delegate* unmanaged<ITravelLog*, IUnknown*, int, int, ushort*, uint, int>)(lpVtbl[9]))((ITravelLog*)Unsafe.AsPointer(ref this), punk, iOffset, idsTemplate, pwzText, cchText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT InsertMenuEntries(IUnknown* punk, HMENU hmenu, int nPos, int idFirst, int idLast, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITravelLog*, IUnknown*, HMENU, int, int, int, uint, int>)(lpVtbl[10]))((ITravelLog*)Unsafe.AsPointer(ref this), punk, hmenu, nPos, idFirst, idLast, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT Clone(ITravelLog** pptl)
        {
            return ((delegate* unmanaged<ITravelLog*, ITravelLog**, int>)(lpVtbl[11]))((ITravelLog*)Unsafe.AsPointer(ref this), pptl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("DWORD")]
        public uint CountEntries(IUnknown* punk)
        {
            return ((delegate* unmanaged<ITravelLog*, IUnknown*, uint>)(lpVtbl[12]))((ITravelLog*)Unsafe.AsPointer(ref this), punk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT Revert()
        {
            return ((delegate* unmanaged<ITravelLog*, int>)(lpVtbl[13]))((ITravelLog*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT AddEntry(IUnknown* punk, BOOL fIsLocalAnchor);

            [VtblIndex(4)]
            HRESULT UpdateEntry(IUnknown* punk, BOOL fIsLocalAnchor);

            [VtblIndex(5)]
            HRESULT UpdateExternal(IUnknown* punk, IUnknown* punkHLBrowseContext);

            [VtblIndex(6)]
            HRESULT Travel(IUnknown* punk, int iOffset);

            [VtblIndex(7)]
            HRESULT GetTravelEntry(IUnknown* punk, int iOffset, ITravelEntry** ppte);

            [VtblIndex(8)]
            HRESULT FindTravelEntry(IUnknown* punk, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, ITravelEntry** ppte);

            [VtblIndex(9)]
            HRESULT GetToolTipText(IUnknown* punk, int iOffset, int idsTemplate, [NativeTypeName("LPWSTR")] ushort* pwzText, [NativeTypeName("DWORD")] uint cchText);

            [VtblIndex(10)]
            HRESULT InsertMenuEntries(IUnknown* punk, HMENU hmenu, int nPos, int idFirst, int idLast, [NativeTypeName("DWORD")] uint dwFlags);

            [VtblIndex(11)]
            HRESULT Clone(ITravelLog** pptl);

            [VtblIndex(12)]
            [return: NativeTypeName("DWORD")]
            uint CountEntries(IUnknown* punk);

            [VtblIndex(13)]
            HRESULT Revert();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITravelLog*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITravelLog*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITravelLog*, uint> Release;

            [NativeTypeName("HRESULT (IUnknown *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<ITravelLog*, IUnknown*, BOOL, int> AddEntry;

            [NativeTypeName("HRESULT (IUnknown *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<ITravelLog*, IUnknown*, BOOL, int> UpdateEntry;

            [NativeTypeName("HRESULT (IUnknown *, IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITravelLog*, IUnknown*, IUnknown*, int> UpdateExternal;

            [NativeTypeName("HRESULT (IUnknown *, int) __attribute__((stdcall))")]
            public delegate* unmanaged<ITravelLog*, IUnknown*, int, int> Travel;

            [NativeTypeName("HRESULT (IUnknown *, int, ITravelEntry **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITravelLog*, IUnknown*, int, ITravelEntry**, int> GetTravelEntry;

            [NativeTypeName("HRESULT (IUnknown *, LPCITEMIDLIST, ITravelEntry **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITravelLog*, IUnknown*, ITEMIDLIST*, ITravelEntry**, int> FindTravelEntry;

            [NativeTypeName("HRESULT (IUnknown *, int, int, LPWSTR, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ITravelLog*, IUnknown*, int, int, ushort*, uint, int> GetToolTipText;

            [NativeTypeName("HRESULT (IUnknown *, HMENU, int, int, int, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ITravelLog*, IUnknown*, HMENU, int, int, int, uint, int> InsertMenuEntries;

            [NativeTypeName("HRESULT (ITravelLog **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITravelLog*, ITravelLog**, int> Clone;

            [NativeTypeName("DWORD (IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITravelLog*, IUnknown*, uint> CountEntries;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<ITravelLog*, int> Revert;
        }
    }
}
