// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3BAB89E4-5FBE-45F4-A5BC-DCA36AD225A8")]
    [NativeTypeName("struct ITfFnBalloon : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfFnBalloon
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfFnBalloon*, Guid*, void**, int>)(lpVtbl[0]))((ITfFnBalloon*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfFnBalloon*, uint>)(lpVtbl[1]))((ITfFnBalloon*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfFnBalloon*, uint>)(lpVtbl[2]))((ITfFnBalloon*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT UpdateBalloon(TfLBBalloonStyle style, [NativeTypeName("const WCHAR *")] ushort* pch, [NativeTypeName("ULONG")] uint cch)
        {
            return ((delegate* unmanaged<ITfFnBalloon*, TfLBBalloonStyle, ushort*, uint, int>)(lpVtbl[3]))((ITfFnBalloon*)Unsafe.AsPointer(ref this), style, pch, cch);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfFnBalloon*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfFnBalloon*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfFnBalloon*, uint> Release;

            [NativeTypeName("HRESULT (TfLBBalloonStyle, const WCHAR *, ULONG) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfFnBalloon*, TfLBBalloonStyle, ushort*, uint, int> UpdateBalloon;
        }
    }
}
