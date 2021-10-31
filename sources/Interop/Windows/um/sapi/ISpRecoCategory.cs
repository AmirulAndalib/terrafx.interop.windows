// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DA0CD0F9-14A2-4F09-8C2A-85CC48979345")]
    [NativeTypeName("struct ISpRecoCategory : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISpRecoCategory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpRecoCategory*, Guid*, void**, int>)(lpVtbl[0]))((ISpRecoCategory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpRecoCategory*, uint>)(lpVtbl[1]))((ISpRecoCategory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpRecoCategory*, uint>)(lpVtbl[2]))((ISpRecoCategory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetType(SPCATEGORYTYPE* peCategoryType)
        {
            return ((delegate* unmanaged<ISpRecoCategory*, SPCATEGORYTYPE*, int>)(lpVtbl[3]))((ISpRecoCategory*)Unsafe.AsPointer(ref this), peCategoryType);
        }
    }
}
