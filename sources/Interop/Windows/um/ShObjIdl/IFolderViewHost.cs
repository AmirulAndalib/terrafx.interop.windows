// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1EA58F02-D55A-411D-B09E-9E65AC21605B")]
    [NativeTypeName("struct IFolderViewHost : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IFolderViewHost
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFolderViewHost*, Guid*, void**, int>)(lpVtbl[0]))((IFolderViewHost*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFolderViewHost*, uint>)(lpVtbl[1]))((IFolderViewHost*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFolderViewHost*, uint>)(lpVtbl[2]))((IFolderViewHost*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Initialize(HWND hwndParent, IDataObject* pdo, RECT* prc)
        {
            return ((delegate* unmanaged<IFolderViewHost*, HWND, IDataObject*, RECT*, int>)(lpVtbl[3]))((IFolderViewHost*)Unsafe.AsPointer(ref this), hwndParent, pdo, prc);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IFolderViewHost*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IFolderViewHost*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IFolderViewHost*, uint> Release;

            [NativeTypeName("HRESULT (HWND, IDataObject *, RECT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFolderViewHost*, HWND, IDataObject*, RECT*, int> Initialize;
        }
    }
}
