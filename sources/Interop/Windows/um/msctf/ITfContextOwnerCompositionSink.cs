// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5F20AA40-B57A-4F34-96AB-3576F377CC79")]
    [NativeTypeName("struct ITfContextOwnerCompositionSink : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfContextOwnerCompositionSink : ITfContextOwnerCompositionSink.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfContextOwnerCompositionSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfContextOwnerCompositionSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfContextOwnerCompositionSink*, uint>)(lpVtbl[1]))((ITfContextOwnerCompositionSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfContextOwnerCompositionSink*, uint>)(lpVtbl[2]))((ITfContextOwnerCompositionSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnStartComposition(ITfCompositionView* pComposition, BOOL* pfOk)
        {
            return ((delegate* unmanaged<ITfContextOwnerCompositionSink*, ITfCompositionView*, BOOL*, int>)(lpVtbl[3]))((ITfContextOwnerCompositionSink*)Unsafe.AsPointer(ref this), pComposition, pfOk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OnUpdateComposition(ITfCompositionView* pComposition, ITfRange* pRangeNew)
        {
            return ((delegate* unmanaged<ITfContextOwnerCompositionSink*, ITfCompositionView*, ITfRange*, int>)(lpVtbl[4]))((ITfContextOwnerCompositionSink*)Unsafe.AsPointer(ref this), pComposition, pRangeNew);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT OnEndComposition(ITfCompositionView* pComposition)
        {
            return ((delegate* unmanaged<ITfContextOwnerCompositionSink*, ITfCompositionView*, int>)(lpVtbl[5]))((ITfContextOwnerCompositionSink*)Unsafe.AsPointer(ref this), pComposition);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT OnStartComposition(ITfCompositionView* pComposition, BOOL* pfOk);

            [VtblIndex(4)]
            HRESULT OnUpdateComposition(ITfCompositionView* pComposition, ITfRange* pRangeNew);

            [VtblIndex(5)]
            HRESULT OnEndComposition(ITfCompositionView* pComposition);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfContextOwnerCompositionSink*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfContextOwnerCompositionSink*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfContextOwnerCompositionSink*, uint> Release;

            [NativeTypeName("HRESULT (ITfCompositionView *, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfContextOwnerCompositionSink*, ITfCompositionView*, BOOL*, int> OnStartComposition;

            [NativeTypeName("HRESULT (ITfCompositionView *, ITfRange *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfContextOwnerCompositionSink*, ITfCompositionView*, ITfRange*, int> OnUpdateComposition;

            [NativeTypeName("HRESULT (ITfCompositionView *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfContextOwnerCompositionSink*, ITfCompositionView*, int> OnEndComposition;
        }
    }
}
