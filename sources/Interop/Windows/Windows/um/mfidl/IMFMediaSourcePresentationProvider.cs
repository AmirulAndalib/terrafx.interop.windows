// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("0E1D600A-C9F3-442D-8C51-A42D2D49452F")]
    [NativeTypeName("struct IMFMediaSourcePresentationProvider : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFMediaSourcePresentationProvider : IMFMediaSourcePresentationProvider.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaSourcePresentationProvider*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaSourcePresentationProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMediaSourcePresentationProvider*, uint>)(lpVtbl[1]))((IMFMediaSourcePresentationProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMediaSourcePresentationProvider*, uint>)(lpVtbl[2]))((IMFMediaSourcePresentationProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT ForceEndOfPresentation(IMFPresentationDescriptor* pPresentationDescriptor)
        {
            return ((delegate* unmanaged<IMFMediaSourcePresentationProvider*, IMFPresentationDescriptor*, int>)(lpVtbl[3]))((IMFMediaSourcePresentationProvider*)Unsafe.AsPointer(ref this), pPresentationDescriptor);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT ForceEndOfPresentation(IMFPresentationDescriptor* pPresentationDescriptor);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaSourcePresentationProvider*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaSourcePresentationProvider*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaSourcePresentationProvider*, uint> Release;

            [NativeTypeName("HRESULT (IMFPresentationDescriptor *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaSourcePresentationProvider*, IMFPresentationDescriptor*, int> ForceEndOfPresentation;
        }
    }
}