// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows10.0.15063.0")]
    [Guid("EED9C2EE-66B4-4F18-A697-AC7D3960215C")]
    [NativeTypeName("struct IMFSensorTransformFactory : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFSensorTransformFactory : IMFSensorTransformFactory.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSensorTransformFactory*, Guid*, void**, int>)(lpVtbl[0]))((IMFSensorTransformFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSensorTransformFactory*, uint>)(lpVtbl[1]))((IMFSensorTransformFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSensorTransformFactory*, uint>)(lpVtbl[2]))((IMFSensorTransformFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetFactoryAttributes(IMFAttributes** ppAttributes)
        {
            return ((delegate* unmanaged<IMFSensorTransformFactory*, IMFAttributes**, int>)(lpVtbl[3]))((IMFSensorTransformFactory*)Unsafe.AsPointer(ref this), ppAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT InitializeFactory([NativeTypeName("DWORD")] uint dwMaxTransformCount, IMFCollection* pSensorDevices, IMFAttributes* pAttributes)
        {
            return ((delegate* unmanaged<IMFSensorTransformFactory*, uint, IMFCollection*, IMFAttributes*, int>)(lpVtbl[4]))((IMFSensorTransformFactory*)Unsafe.AsPointer(ref this), dwMaxTransformCount, pSensorDevices, pAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetTransformCount([NativeTypeName("DWORD *")] uint* pdwCount)
        {
            return ((delegate* unmanaged<IMFSensorTransformFactory*, uint*, int>)(lpVtbl[5]))((IMFSensorTransformFactory*)Unsafe.AsPointer(ref this), pdwCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetTransformInformation([NativeTypeName("DWORD")] uint TransformIndex, Guid* pguidTransformId, IMFAttributes** ppAttributes, IMFCollection** ppStreamInformation)
        {
            return ((delegate* unmanaged<IMFSensorTransformFactory*, uint, Guid*, IMFAttributes**, IMFCollection**, int>)(lpVtbl[6]))((IMFSensorTransformFactory*)Unsafe.AsPointer(ref this), TransformIndex, pguidTransformId, ppAttributes, ppStreamInformation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT CreateTransform([NativeTypeName("const GUID &")] Guid* guidSensorTransformID, IMFAttributes* pAttributes, IMFDeviceTransform** ppDeviceMFT)
        {
            return ((delegate* unmanaged<IMFSensorTransformFactory*, Guid*, IMFAttributes*, IMFDeviceTransform**, int>)(lpVtbl[7]))((IMFSensorTransformFactory*)Unsafe.AsPointer(ref this), guidSensorTransformID, pAttributes, ppDeviceMFT);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetFactoryAttributes(IMFAttributes** ppAttributes);

            [VtblIndex(4)]
            HRESULT InitializeFactory([NativeTypeName("DWORD")] uint dwMaxTransformCount, IMFCollection* pSensorDevices, IMFAttributes* pAttributes);

            [VtblIndex(5)]
            HRESULT GetTransformCount([NativeTypeName("DWORD *")] uint* pdwCount);

            [VtblIndex(6)]
            HRESULT GetTransformInformation([NativeTypeName("DWORD")] uint TransformIndex, Guid* pguidTransformId, IMFAttributes** ppAttributes, IMFCollection** ppStreamInformation);

            [VtblIndex(7)]
            HRESULT CreateTransform([NativeTypeName("const GUID &")] Guid* guidSensorTransformID, IMFAttributes* pAttributes, IMFDeviceTransform** ppDeviceMFT);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSensorTransformFactory*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSensorTransformFactory*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSensorTransformFactory*, uint> Release;

            [NativeTypeName("HRESULT (IMFAttributes **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSensorTransformFactory*, IMFAttributes**, int> GetFactoryAttributes;

            [NativeTypeName("HRESULT (DWORD, IMFCollection *, IMFAttributes *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSensorTransformFactory*, uint, IMFCollection*, IMFAttributes*, int> InitializeFactory;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSensorTransformFactory*, uint*, int> GetTransformCount;

            [NativeTypeName("HRESULT (DWORD, GUID *, IMFAttributes **, IMFCollection **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSensorTransformFactory*, uint, Guid*, IMFAttributes**, IMFCollection**, int> GetTransformInformation;

            [NativeTypeName("HRESULT (const GUID &, IMFAttributes *, IMFDeviceTransform **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSensorTransformFactory*, Guid*, IMFAttributes*, IMFDeviceTransform**, int> CreateTransform;
        }
    }
}
