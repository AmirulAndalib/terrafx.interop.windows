// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3C594F9F-9F30-47A1-979A-C9E83D3D0A06")]
    [NativeTypeName("struct IApplicationDocumentLists : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IApplicationDocumentLists : IApplicationDocumentLists.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IApplicationDocumentLists*, Guid*, void**, int>)(lpVtbl[0]))((IApplicationDocumentLists*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IApplicationDocumentLists*, uint>)(lpVtbl[1]))((IApplicationDocumentLists*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IApplicationDocumentLists*, uint>)(lpVtbl[2]))((IApplicationDocumentLists*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetAppID([NativeTypeName("LPCWSTR")] ushort* pszAppID)
        {
            return ((delegate* unmanaged<IApplicationDocumentLists*, ushort*, int>)(lpVtbl[3]))((IApplicationDocumentLists*)Unsafe.AsPointer(ref this), pszAppID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetList(APPDOCLISTTYPE listtype, uint cItemsDesired, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IApplicationDocumentLists*, APPDOCLISTTYPE, uint, Guid*, void**, int>)(lpVtbl[4]))((IApplicationDocumentLists*)Unsafe.AsPointer(ref this), listtype, cItemsDesired, riid, ppv);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetAppID([NativeTypeName("LPCWSTR")] ushort* pszAppID);

            [VtblIndex(4)]
            HRESULT GetList(APPDOCLISTTYPE listtype, uint cItemsDesired, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IApplicationDocumentLists*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IApplicationDocumentLists*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IApplicationDocumentLists*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IApplicationDocumentLists*, ushort*, int> SetAppID;

            [NativeTypeName("HRESULT (APPDOCLISTTYPE, UINT, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IApplicationDocumentLists*, APPDOCLISTTYPE, uint, Guid*, void**, int> GetList;
        }
    }
}
