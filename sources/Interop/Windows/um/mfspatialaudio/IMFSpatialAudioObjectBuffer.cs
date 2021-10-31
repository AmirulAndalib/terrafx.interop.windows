// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfspatialaudio.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D396EC8C-605E-4249-978D-72AD1C312872")]
    [NativeTypeName("struct IMFSpatialAudioObjectBuffer : IMFMediaBuffer")]
    [NativeInheritance("IMFMediaBuffer")]
    public unsafe partial struct IMFSpatialAudioObjectBuffer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer*, Guid*, void**, int>)(lpVtbl[0]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer*, uint>)(lpVtbl[1]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer*, uint>)(lpVtbl[2]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Lock(byte** ppbBuffer, [NativeTypeName("DWORD *")] uint* pcbMaxLength, [NativeTypeName("DWORD *")] uint* pcbCurrentLength)
        {
            return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer*, byte**, uint*, uint*, int>)(lpVtbl[3]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this), ppbBuffer, pcbMaxLength, pcbCurrentLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Unlock()
        {
            return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer*, int>)(lpVtbl[4]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetCurrentLength([NativeTypeName("DWORD *")] uint* pcbCurrentLength)
        {
            return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer*, uint*, int>)(lpVtbl[5]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this), pcbCurrentLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetCurrentLength([NativeTypeName("DWORD")] uint cbCurrentLength)
        {
            return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer*, uint, int>)(lpVtbl[6]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this), cbCurrentLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetMaxLength([NativeTypeName("DWORD *")] uint* pcbMaxLength)
        {
            return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer*, uint*, int>)(lpVtbl[7]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this), pcbMaxLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetID([NativeTypeName("UINT32")] uint u32ID)
        {
            return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer*, uint, int>)(lpVtbl[8]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this), u32ID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetID([NativeTypeName("UINT32 *")] uint* pu32ID)
        {
            return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer*, uint*, int>)(lpVtbl[9]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this), pu32ID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetType(AudioObjectType type)
        {
            return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer*, AudioObjectType, int>)(lpVtbl[10]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this), type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetType(AudioObjectType* pType)
        {
            return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer*, AudioObjectType*, int>)(lpVtbl[11]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetMetadataItems(ISpatialAudioMetadataItems** ppMetadataItems)
        {
            return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer*, ISpatialAudioMetadataItems**, int>)(lpVtbl[12]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this), ppMetadataItems);
        }
    }
}
