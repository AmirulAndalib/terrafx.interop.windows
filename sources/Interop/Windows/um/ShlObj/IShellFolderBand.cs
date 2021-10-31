// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7FE80CC8-C247-11D0-B93A-00A0C90312E1")]
    [NativeTypeName("struct IShellFolderBand : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IShellFolderBand
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellFolderBand*, Guid*, void**, int>)(lpVtbl[0]))((IShellFolderBand*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellFolderBand*, uint>)(lpVtbl[1]))((IShellFolderBand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellFolderBand*, uint>)(lpVtbl[2]))((IShellFolderBand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT InitializeSFB(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
        {
            return ((delegate* unmanaged<IShellFolderBand*, IShellFolder*, ITEMIDLIST*, int>)(lpVtbl[3]))((IShellFolderBand*)Unsafe.AsPointer(ref this), psf, pidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetBandInfoSFB([NativeTypeName("PBANDINFOSFB")] BANDINFOSFB* pbi)
        {
            return ((delegate* unmanaged<IShellFolderBand*, BANDINFOSFB*, int>)(lpVtbl[4]))((IShellFolderBand*)Unsafe.AsPointer(ref this), pbi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetBandInfoSFB([NativeTypeName("PBANDINFOSFB")] BANDINFOSFB* pbi)
        {
            return ((delegate* unmanaged<IShellFolderBand*, BANDINFOSFB*, int>)(lpVtbl[5]))((IShellFolderBand*)Unsafe.AsPointer(ref this), pbi);
        }
    }
}
