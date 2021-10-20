// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E9701183-E6B3-4FF2-8568-813615FEC7BE")]
    [NativeTypeName("struct INameSpaceTreeControlFolderCapabilities : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct INameSpaceTreeControlFolderCapabilities
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlFolderCapabilities*, Guid*, void**, int>)(lpVtbl[0]))((INameSpaceTreeControlFolderCapabilities*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<INameSpaceTreeControlFolderCapabilities*, uint>)(lpVtbl[1]))((INameSpaceTreeControlFolderCapabilities*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<INameSpaceTreeControlFolderCapabilities*, uint>)(lpVtbl[2]))((INameSpaceTreeControlFolderCapabilities*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetFolderCapabilities(NSTCFOLDERCAPABILITIES nfcMask, NSTCFOLDERCAPABILITIES* pnfcValue)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlFolderCapabilities*, NSTCFOLDERCAPABILITIES, NSTCFOLDERCAPABILITIES*, int>)(lpVtbl[3]))((INameSpaceTreeControlFolderCapabilities*)Unsafe.AsPointer(ref this), nfcMask, pnfcValue);
        }
    }
}