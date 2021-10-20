// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C0A651F5-B48B-11D2-B5ED-006097C686F6")]
    [NativeTypeName("struct IFolderFilterSite : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IFolderFilterSite
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFolderFilterSite*, Guid*, void**, int>)(lpVtbl[0]))((IFolderFilterSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFolderFilterSite*, uint>)(lpVtbl[1]))((IFolderFilterSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFolderFilterSite*, uint>)(lpVtbl[2]))((IFolderFilterSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetFilter(IUnknown* punk)
        {
            return ((delegate* unmanaged<IFolderFilterSite*, IUnknown*, int>)(lpVtbl[3]))((IFolderFilterSite*)Unsafe.AsPointer(ref this), punk);
        }
    }
}