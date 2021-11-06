// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mediaobj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("65ABEA96-CF36-453F-AF8A-705E98F16260")]
    [NativeTypeName("struct IDMOQualityControl : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDMOQualityControl : IDMOQualityControl.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDMOQualityControl*, Guid*, void**, int>)(lpVtbl[0]))((IDMOQualityControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDMOQualityControl*, uint>)(lpVtbl[1]))((IDMOQualityControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDMOQualityControl*, uint>)(lpVtbl[2]))((IDMOQualityControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetNow([NativeTypeName("REFERENCE_TIME")] long rtNow)
        {
            return ((delegate* unmanaged<IDMOQualityControl*, long, int>)(lpVtbl[3]))((IDMOQualityControl*)Unsafe.AsPointer(ref this), rtNow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetStatus([NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IDMOQualityControl*, uint, int>)(lpVtbl[4]))((IDMOQualityControl*)Unsafe.AsPointer(ref this), dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetStatus([NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<IDMOQualityControl*, uint*, int>)(lpVtbl[5]))((IDMOQualityControl*)Unsafe.AsPointer(ref this), pdwFlags);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetNow([NativeTypeName("REFERENCE_TIME")] long rtNow);

            [VtblIndex(4)]
            HRESULT SetStatus([NativeTypeName("DWORD")] uint dwFlags);

            [VtblIndex(5)]
            HRESULT GetStatus([NativeTypeName("DWORD *")] uint* pdwFlags);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDMOQualityControl*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDMOQualityControl*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDMOQualityControl*, uint> Release;

            [NativeTypeName("HRESULT (REFERENCE_TIME) __attribute__((stdcall))")]
            public delegate* unmanaged<IDMOQualityControl*, long, int> SetNow;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IDMOQualityControl*, uint, int> SetStatus;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDMOQualityControl*, uint*, int> GetStatus;
        }
    }
}
