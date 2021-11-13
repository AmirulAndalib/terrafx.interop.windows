// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("6DAA848C-5EB0-45CC-AEA5-998A2CDA1FFB")]
    [NativeTypeName("struct IPartsList : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPartsList : IPartsList.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPartsList*, Guid*, void**, int>)(lpVtbl[0]))((IPartsList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPartsList*, uint>)(lpVtbl[1]))((IPartsList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPartsList*, uint>)(lpVtbl[2]))((IPartsList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetCount(uint* pCount)
        {
            return ((delegate* unmanaged<IPartsList*, uint*, int>)(lpVtbl[3]))((IPartsList*)Unsafe.AsPointer(ref this), pCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetPart(uint nIndex, IPart** ppPart)
        {
            return ((delegate* unmanaged<IPartsList*, uint, IPart**, int>)(lpVtbl[4]))((IPartsList*)Unsafe.AsPointer(ref this), nIndex, ppPart);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetCount(uint* pCount);

            [VtblIndex(4)]
            HRESULT GetPart(uint nIndex, IPart** ppPart);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPartsList*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPartsList*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPartsList*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPartsList*, uint*, int> GetCount;

            [NativeTypeName("HRESULT (UINT, IPart **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPartsList*, uint, IPart**, int> GetPart;
        }
    }
}
