// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("3AA7AF7E-9B36-420C-A8E3-F77D4674A488")]
    [NativeTypeName("struct IKnownFolder : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IKnownFolder : IKnownFolder.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IKnownFolder*, Guid*, void**, int>)(lpVtbl[0]))((IKnownFolder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IKnownFolder*, uint>)(lpVtbl[1]))((IKnownFolder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IKnownFolder*, uint>)(lpVtbl[2]))((IKnownFolder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetId([NativeTypeName("KNOWNFOLDERID *")] Guid* pkfid)
        {
            return ((delegate* unmanaged<IKnownFolder*, Guid*, int>)(lpVtbl[3]))((IKnownFolder*)Unsafe.AsPointer(ref this), pkfid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetCategory(KF_CATEGORY* pCategory)
        {
            return ((delegate* unmanaged<IKnownFolder*, KF_CATEGORY*, int>)(lpVtbl[4]))((IKnownFolder*)Unsafe.AsPointer(ref this), pCategory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetShellItem([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IKnownFolder*, uint, Guid*, void**, int>)(lpVtbl[5]))((IKnownFolder*)Unsafe.AsPointer(ref this), dwFlags, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetPath([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR *")] ushort** ppszPath)
        {
            return ((delegate* unmanaged<IKnownFolder*, uint, ushort**, int>)(lpVtbl[6]))((IKnownFolder*)Unsafe.AsPointer(ref this), dwFlags, ppszPath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetPath([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* pszPath)
        {
            return ((delegate* unmanaged<IKnownFolder*, uint, ushort*, int>)(lpVtbl[7]))((IKnownFolder*)Unsafe.AsPointer(ref this), dwFlags, pszPath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetIDList([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
        {
            return ((delegate* unmanaged<IKnownFolder*, uint, ITEMIDLIST**, int>)(lpVtbl[8]))((IKnownFolder*)Unsafe.AsPointer(ref this), dwFlags, ppidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetFolderType([NativeTypeName("FOLDERTYPEID *")] Guid* pftid)
        {
            return ((delegate* unmanaged<IKnownFolder*, Guid*, int>)(lpVtbl[9]))((IKnownFolder*)Unsafe.AsPointer(ref this), pftid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetRedirectionCapabilities([NativeTypeName("KF_REDIRECTION_CAPABILITIES *")] uint* pCapabilities)
        {
            return ((delegate* unmanaged<IKnownFolder*, uint*, int>)(lpVtbl[10]))((IKnownFolder*)Unsafe.AsPointer(ref this), pCapabilities);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetFolderDefinition(KNOWNFOLDER_DEFINITION* pKFD)
        {
            return ((delegate* unmanaged<IKnownFolder*, KNOWNFOLDER_DEFINITION*, int>)(lpVtbl[11]))((IKnownFolder*)Unsafe.AsPointer(ref this), pKFD);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetId([NativeTypeName("KNOWNFOLDERID *")] Guid* pkfid);

            [VtblIndex(4)]
            HRESULT GetCategory(KF_CATEGORY* pCategory);

            [VtblIndex(5)]
            HRESULT GetShellItem([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

            [VtblIndex(6)]
            HRESULT GetPath([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR *")] ushort** ppszPath);

            [VtblIndex(7)]
            HRESULT SetPath([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* pszPath);

            [VtblIndex(8)]
            HRESULT GetIDList([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl);

            [VtblIndex(9)]
            HRESULT GetFolderType([NativeTypeName("FOLDERTYPEID *")] Guid* pftid);

            [VtblIndex(10)]
            HRESULT GetRedirectionCapabilities([NativeTypeName("KF_REDIRECTION_CAPABILITIES *")] uint* pCapabilities);

            [VtblIndex(11)]
            HRESULT GetFolderDefinition(KNOWNFOLDER_DEFINITION* pKFD);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IKnownFolder*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IKnownFolder*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IKnownFolder*, uint> Release;

            [NativeTypeName("HRESULT (KNOWNFOLDERID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IKnownFolder*, Guid*, int> GetId;

            [NativeTypeName("HRESULT (KF_CATEGORY *) __attribute__((stdcall))")]
            public delegate* unmanaged<IKnownFolder*, KF_CATEGORY*, int> GetCategory;

            [NativeTypeName("HRESULT (DWORD, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IKnownFolder*, uint, Guid*, void**, int> GetShellItem;

            [NativeTypeName("HRESULT (DWORD, LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IKnownFolder*, uint, ushort**, int> GetPath;

            [NativeTypeName("HRESULT (DWORD, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IKnownFolder*, uint, ushort*, int> SetPath;

            [NativeTypeName("HRESULT (DWORD, LPITEMIDLIST *) __attribute__((stdcall))")]
            public delegate* unmanaged<IKnownFolder*, uint, ITEMIDLIST**, int> GetIDList;

            [NativeTypeName("HRESULT (FOLDERTYPEID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IKnownFolder*, Guid*, int> GetFolderType;

            [NativeTypeName("HRESULT (KF_REDIRECTION_CAPABILITIES *) __attribute__((stdcall))")]
            public delegate* unmanaged<IKnownFolder*, uint*, int> GetRedirectionCapabilities;

            [NativeTypeName("HRESULT (KNOWNFOLDER_DEFINITION *) __attribute__((stdcall))")]
            public delegate* unmanaged<IKnownFolder*, KNOWNFOLDER_DEFINITION*, int> GetFolderDefinition;
        }
    }
}