// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BDE633D3-E1DC-4A7F-A693-BBAE399C4A20")]
    [NativeTypeName("struct IMFVideoProcessorControl2 : IMFVideoProcessorControl")]
    [NativeInheritance("IMFVideoProcessorControl")]
    public unsafe partial struct IMFVideoProcessorControl2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFVideoProcessorControl2*, Guid*, void**, int>)(lpVtbl[0]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFVideoProcessorControl2*, uint>)(lpVtbl[1]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFVideoProcessorControl2*, uint>)(lpVtbl[2]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetBorderColor(MFARGB* pBorderColor)
        {
            return ((delegate* unmanaged<IMFVideoProcessorControl2*, MFARGB*, int>)(lpVtbl[3]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this), pBorderColor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetSourceRectangle(RECT* pSrcRect)
        {
            return ((delegate* unmanaged<IMFVideoProcessorControl2*, RECT*, int>)(lpVtbl[4]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this), pSrcRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetDestinationRectangle(RECT* pDstRect)
        {
            return ((delegate* unmanaged<IMFVideoProcessorControl2*, RECT*, int>)(lpVtbl[5]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this), pDstRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetMirror(MF_VIDEO_PROCESSOR_MIRROR eMirror)
        {
            return ((delegate* unmanaged<IMFVideoProcessorControl2*, MF_VIDEO_PROCESSOR_MIRROR, int>)(lpVtbl[6]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this), eMirror);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetRotation(MF_VIDEO_PROCESSOR_ROTATION eRotation)
        {
            return ((delegate* unmanaged<IMFVideoProcessorControl2*, MF_VIDEO_PROCESSOR_ROTATION, int>)(lpVtbl[7]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this), eRotation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetConstrictionSize(SIZE* pConstrictionSize)
        {
            return ((delegate* unmanaged<IMFVideoProcessorControl2*, SIZE*, int>)(lpVtbl[8]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this), pConstrictionSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetRotationOverride(uint uiRotation)
        {
            return ((delegate* unmanaged<IMFVideoProcessorControl2*, uint, int>)(lpVtbl[9]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this), uiRotation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT EnableHardwareEffects(BOOL fEnabled)
        {
            return ((delegate* unmanaged<IMFVideoProcessorControl2*, BOOL, int>)(lpVtbl[10]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this), fEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetSupportedHardwareEffects(uint* puiSupport)
        {
            return ((delegate* unmanaged<IMFVideoProcessorControl2*, uint*, int>)(lpVtbl[11]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this), puiSupport);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFVideoProcessorControl2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFVideoProcessorControl2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFVideoProcessorControl2*, uint> Release;

            [NativeTypeName("HRESULT (MFARGB *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFVideoProcessorControl2*, MFARGB*, int> SetBorderColor;

            [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFVideoProcessorControl2*, RECT*, int> SetSourceRectangle;

            [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFVideoProcessorControl2*, RECT*, int> SetDestinationRectangle;

            [NativeTypeName("HRESULT (MF_VIDEO_PROCESSOR_MIRROR) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFVideoProcessorControl2*, MF_VIDEO_PROCESSOR_MIRROR, int> SetMirror;

            [NativeTypeName("HRESULT (MF_VIDEO_PROCESSOR_ROTATION) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFVideoProcessorControl2*, MF_VIDEO_PROCESSOR_ROTATION, int> SetRotation;

            [NativeTypeName("HRESULT (SIZE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFVideoProcessorControl2*, SIZE*, int> SetConstrictionSize;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFVideoProcessorControl2*, uint, int> SetRotationOverride;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFVideoProcessorControl2*, BOOL, int> EnableHardwareEffects;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFVideoProcessorControl2*, uint*, int> GetSupportedHardwareEffects;
        }
    }
}
