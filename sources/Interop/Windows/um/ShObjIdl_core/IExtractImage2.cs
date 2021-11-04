// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("953BB1EE-93B4-11D1-98A3-00C04FB687DA")]
    [NativeTypeName("struct IExtractImage2 : IExtractImage")]
    [NativeInheritance("IExtractImage")]
    public unsafe partial struct IExtractImage2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IExtractImage2*, Guid*, void**, int>)(lpVtbl[0]))((IExtractImage2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IExtractImage2*, uint>)(lpVtbl[1]))((IExtractImage2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IExtractImage2*, uint>)(lpVtbl[2]))((IExtractImage2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetLocation([NativeTypeName("LPWSTR")] ushort* pszPathBuffer, [NativeTypeName("DWORD")] uint cch, [NativeTypeName("DWORD *")] uint* pdwPriority, [NativeTypeName("const SIZE *")] SIZE* prgSize, [NativeTypeName("DWORD")] uint dwRecClrDepth, [NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<IExtractImage2*, ushort*, uint, uint*, SIZE*, uint, uint*, int>)(lpVtbl[3]))((IExtractImage2*)Unsafe.AsPointer(ref this), pszPathBuffer, cch, pdwPriority, prgSize, dwRecClrDepth, pdwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Extract(HBITMAP* phBmpThumbnail)
        {
            return ((delegate* unmanaged<IExtractImage2*, HBITMAP*, int>)(lpVtbl[4]))((IExtractImage2*)Unsafe.AsPointer(ref this), phBmpThumbnail);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetDateStamp(FILETIME* pDateStamp)
        {
            return ((delegate* unmanaged<IExtractImage2*, FILETIME*, int>)(lpVtbl[5]))((IExtractImage2*)Unsafe.AsPointer(ref this), pDateStamp);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IExtractImage2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IExtractImage2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IExtractImage2*, uint> Release;

            [NativeTypeName("HRESULT (LPWSTR, DWORD, DWORD *, const SIZE *, DWORD, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IExtractImage2*, ushort*, uint, uint*, SIZE*, uint, uint*, int> GetLocation;

            [NativeTypeName("HRESULT (HBITMAP *) __attribute__((stdcall))")]
            public delegate* unmanaged<IExtractImage2*, HBITMAP*, int> Extract;

            [NativeTypeName("HRESULT (FILETIME *) __attribute__((stdcall))")]
            public delegate* unmanaged<IExtractImage2*, FILETIME*, int> GetDateStamp;
        }
    }
}
