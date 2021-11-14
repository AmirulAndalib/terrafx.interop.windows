// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("74C2653B-5F55-4EB1-9F0F-18B8F68B7D3D")]
    [NativeTypeName("struct IMFExtendedCameraIntrinsicsDistortionModel6KT : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFExtendedCameraIntrinsicsDistortionModel6KT : IMFExtendedCameraIntrinsicsDistortionModel6KT.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFExtendedCameraIntrinsicsDistortionModel6KT*, Guid*, void**, int>)(lpVtbl[0]))((IMFExtendedCameraIntrinsicsDistortionModel6KT*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFExtendedCameraIntrinsicsDistortionModel6KT*, uint>)(lpVtbl[1]))((IMFExtendedCameraIntrinsicsDistortionModel6KT*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFExtendedCameraIntrinsicsDistortionModel6KT*, uint>)(lpVtbl[2]))((IMFExtendedCameraIntrinsicsDistortionModel6KT*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetDistortionModel(MFCameraIntrinsic_DistortionModel6KT* pDistortionModel)
        {
            return ((delegate* unmanaged<IMFExtendedCameraIntrinsicsDistortionModel6KT*, MFCameraIntrinsic_DistortionModel6KT*, int>)(lpVtbl[3]))((IMFExtendedCameraIntrinsicsDistortionModel6KT*)Unsafe.AsPointer(ref this), pDistortionModel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetDistortionModel([NativeTypeName("const MFCameraIntrinsic_DistortionModel6KT *")] MFCameraIntrinsic_DistortionModel6KT* pDistortionModel)
        {
            return ((delegate* unmanaged<IMFExtendedCameraIntrinsicsDistortionModel6KT*, MFCameraIntrinsic_DistortionModel6KT*, int>)(lpVtbl[4]))((IMFExtendedCameraIntrinsicsDistortionModel6KT*)Unsafe.AsPointer(ref this), pDistortionModel);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetDistortionModel(MFCameraIntrinsic_DistortionModel6KT* pDistortionModel);

            [VtblIndex(4)]
            HRESULT SetDistortionModel([NativeTypeName("const MFCameraIntrinsic_DistortionModel6KT *")] MFCameraIntrinsic_DistortionModel6KT* pDistortionModel);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFExtendedCameraIntrinsicsDistortionModel6KT*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFExtendedCameraIntrinsicsDistortionModel6KT*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFExtendedCameraIntrinsicsDistortionModel6KT*, uint> Release;

            [NativeTypeName("HRESULT (MFCameraIntrinsic_DistortionModel6KT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFExtendedCameraIntrinsicsDistortionModel6KT*, MFCameraIntrinsic_DistortionModel6KT*, int> GetDistortionModel;

            [NativeTypeName("HRESULT (const MFCameraIntrinsic_DistortionModel6KT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFExtendedCameraIntrinsicsDistortionModel6KT*, MFCameraIntrinsic_DistortionModel6KT*, int> SetDistortionModel;
        }
    }
}
