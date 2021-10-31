// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0DF2C94B-F5F9-472D-AF6B-C46E0AC9CD05")]
    [NativeTypeName("struct ISpatialAudioObjectForMetadataCommands : ISpatialAudioObjectBase")]
    [NativeInheritance("ISpatialAudioObjectBase")]
    public unsafe partial struct ISpatialAudioObjectForMetadataCommands
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectForMetadataCommands*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectForMetadataCommands*, uint>)(lpVtbl[1]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectForMetadataCommands*, uint>)(lpVtbl[2]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetBuffer(byte** buffer, [NativeTypeName("UINT32 *")] uint* bufferLength)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectForMetadataCommands*, byte**, uint*, int>)(lpVtbl[3]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this), buffer, bufferLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetEndOfStream([NativeTypeName("UINT32")] uint frameCount)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectForMetadataCommands*, uint, int>)(lpVtbl[4]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this), frameCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT IsActive(BOOL* isActive)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectForMetadataCommands*, BOOL*, int>)(lpVtbl[5]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this), isActive);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetAudioObjectType(AudioObjectType* audioObjectType)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectForMetadataCommands*, AudioObjectType*, int>)(lpVtbl[6]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this), audioObjectType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT WriteNextMetadataCommand(byte commandID, void* valueBuffer, [NativeTypeName("UINT32")] uint valueBufferLength)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectForMetadataCommands*, byte, void*, uint, int>)(lpVtbl[7]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this), commandID, valueBuffer, valueBufferLength);
        }
    }
}
