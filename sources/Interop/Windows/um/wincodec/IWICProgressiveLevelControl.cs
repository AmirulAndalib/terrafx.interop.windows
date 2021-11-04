// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DAAC296F-7AA5-4DBF-8D15-225C5976F891")]
    [NativeTypeName("struct IWICProgressiveLevelControl : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICProgressiveLevelControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWICProgressiveLevelControl*, Guid*, void**, int>)(lpVtbl[0]))((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWICProgressiveLevelControl*, uint>)(lpVtbl[1]))((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWICProgressiveLevelControl*, uint>)(lpVtbl[2]))((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetLevelCount(uint* pcLevels)
        {
            return ((delegate* unmanaged<IWICProgressiveLevelControl*, uint*, int>)(lpVtbl[3]))((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this), pcLevels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetCurrentLevel(uint* pnLevel)
        {
            return ((delegate* unmanaged<IWICProgressiveLevelControl*, uint*, int>)(lpVtbl[4]))((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this), pnLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetCurrentLevel(uint nLevel)
        {
            return ((delegate* unmanaged<IWICProgressiveLevelControl*, uint, int>)(lpVtbl[5]))((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this), nLevel);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICProgressiveLevelControl*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWICProgressiveLevelControl*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWICProgressiveLevelControl*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICProgressiveLevelControl*, uint*, int> GetLevelCount;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICProgressiveLevelControl*, uint*, int> GetCurrentLevel;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICProgressiveLevelControl*, uint, int> SetCurrentLevel;
        }
    }
}
