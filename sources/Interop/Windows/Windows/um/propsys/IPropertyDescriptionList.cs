// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("1F9FC1D0-C39B-4B26-817F-011967D3440E")]
    [NativeTypeName("struct IPropertyDescriptionList : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPropertyDescriptionList : IPropertyDescriptionList.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPropertyDescriptionList*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyDescriptionList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPropertyDescriptionList*, uint>)(lpVtbl[1]))((IPropertyDescriptionList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPropertyDescriptionList*, uint>)(lpVtbl[2]))((IPropertyDescriptionList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetCount(uint* pcElem)
        {
            return ((delegate* unmanaged<IPropertyDescriptionList*, uint*, int>)(lpVtbl[3]))((IPropertyDescriptionList*)Unsafe.AsPointer(ref this), pcElem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetAt(uint iElem, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IPropertyDescriptionList*, uint, Guid*, void**, int>)(lpVtbl[4]))((IPropertyDescriptionList*)Unsafe.AsPointer(ref this), iElem, riid, ppv);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetCount(uint* pcElem);

            [VtblIndex(4)]
            HRESULT GetAt(uint iElem, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyDescriptionList*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyDescriptionList*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyDescriptionList*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyDescriptionList*, uint*, int> GetCount;

            [NativeTypeName("HRESULT (UINT, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyDescriptionList*, uint, Guid*, void**, int> GetAt;
        }
    }
}
