// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A615096F-1C57-4813-8A15-55EE6E5A839C")]
    [NativeTypeName("struct ITfTransitoryExtensionSink : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfTransitoryExtensionSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfTransitoryExtensionSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfTransitoryExtensionSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfTransitoryExtensionSink*, uint>)(lpVtbl[1]))((ITfTransitoryExtensionSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfTransitoryExtensionSink*, uint>)(lpVtbl[2]))((ITfTransitoryExtensionSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnTransitoryExtensionUpdated(ITfContext* pic, [NativeTypeName("TfEditCookie")] uint ecReadOnly, ITfRange* pResultRange, ITfRange* pCompositionRange, BOOL* pfDeleteResultRange)
        {
            return ((delegate* unmanaged<ITfTransitoryExtensionSink*, ITfContext*, uint, ITfRange*, ITfRange*, BOOL*, int>)(lpVtbl[3]))((ITfTransitoryExtensionSink*)Unsafe.AsPointer(ref this), pic, ecReadOnly, pResultRange, pCompositionRange, pfDeleteResultRange);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfTransitoryExtensionSink*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfTransitoryExtensionSink*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfTransitoryExtensionSink*, uint> Release;

            [NativeTypeName("HRESULT (ITfContext *, TfEditCookie, ITfRange *, ITfRange *, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfTransitoryExtensionSink*, ITfContext*, uint, ITfRange*, ITfRange*, BOOL*, int> OnTransitoryExtensionUpdated;
        }
    }
}
