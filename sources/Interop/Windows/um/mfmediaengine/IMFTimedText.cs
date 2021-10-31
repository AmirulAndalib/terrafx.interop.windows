// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1F2A94C9-A3DF-430D-9D0F-ACD85DDC29AF")]
    [NativeTypeName("struct IMFTimedText : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFTimedText
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFTimedText*, Guid*, void**, int>)(lpVtbl[0]))((IMFTimedText*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFTimedText*, uint>)(lpVtbl[1]))((IMFTimedText*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFTimedText*, uint>)(lpVtbl[2]))((IMFTimedText*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT RegisterNotifications(IMFTimedTextNotify* notify)
        {
            return ((delegate* unmanaged<IMFTimedText*, IMFTimedTextNotify*, int>)(lpVtbl[3]))((IMFTimedText*)Unsafe.AsPointer(ref this), notify);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SelectTrack([NativeTypeName("DWORD")] uint trackId, BOOL selected)
        {
            return ((delegate* unmanaged<IMFTimedText*, uint, BOOL, int>)(lpVtbl[4]))((IMFTimedText*)Unsafe.AsPointer(ref this), trackId, selected);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT AddDataSource(IMFByteStream* byteStream, [NativeTypeName("LPCWSTR")] ushort* label, [NativeTypeName("LPCWSTR")] ushort* language, MF_TIMED_TEXT_TRACK_KIND kind, BOOL isDefault, [NativeTypeName("DWORD *")] uint* trackId)
        {
            return ((delegate* unmanaged<IMFTimedText*, IMFByteStream*, ushort*, ushort*, MF_TIMED_TEXT_TRACK_KIND, BOOL, uint*, int>)(lpVtbl[5]))((IMFTimedText*)Unsafe.AsPointer(ref this), byteStream, label, language, kind, isDefault, trackId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT AddDataSourceFromUrl([NativeTypeName("LPCWSTR")] ushort* url, [NativeTypeName("LPCWSTR")] ushort* label, [NativeTypeName("LPCWSTR")] ushort* language, MF_TIMED_TEXT_TRACK_KIND kind, BOOL isDefault, [NativeTypeName("DWORD *")] uint* trackId)
        {
            return ((delegate* unmanaged<IMFTimedText*, ushort*, ushort*, ushort*, MF_TIMED_TEXT_TRACK_KIND, BOOL, uint*, int>)(lpVtbl[6]))((IMFTimedText*)Unsafe.AsPointer(ref this), url, label, language, kind, isDefault, trackId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT AddTrack([NativeTypeName("LPCWSTR")] ushort* label, [NativeTypeName("LPCWSTR")] ushort* language, MF_TIMED_TEXT_TRACK_KIND kind, IMFTimedTextTrack** track)
        {
            return ((delegate* unmanaged<IMFTimedText*, ushort*, ushort*, MF_TIMED_TEXT_TRACK_KIND, IMFTimedTextTrack**, int>)(lpVtbl[7]))((IMFTimedText*)Unsafe.AsPointer(ref this), label, language, kind, track);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT RemoveTrack(IMFTimedTextTrack* track)
        {
            return ((delegate* unmanaged<IMFTimedText*, IMFTimedTextTrack*, int>)(lpVtbl[8]))((IMFTimedText*)Unsafe.AsPointer(ref this), track);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetCueTimeOffset(double* offset)
        {
            return ((delegate* unmanaged<IMFTimedText*, double*, int>)(lpVtbl[9]))((IMFTimedText*)Unsafe.AsPointer(ref this), offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetCueTimeOffset(double offset)
        {
            return ((delegate* unmanaged<IMFTimedText*, double, int>)(lpVtbl[10]))((IMFTimedText*)Unsafe.AsPointer(ref this), offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetTracks(IMFTimedTextTrackList** tracks)
        {
            return ((delegate* unmanaged<IMFTimedText*, IMFTimedTextTrackList**, int>)(lpVtbl[11]))((IMFTimedText*)Unsafe.AsPointer(ref this), tracks);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetActiveTracks(IMFTimedTextTrackList** activeTracks)
        {
            return ((delegate* unmanaged<IMFTimedText*, IMFTimedTextTrackList**, int>)(lpVtbl[12]))((IMFTimedText*)Unsafe.AsPointer(ref this), activeTracks);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetTextTracks(IMFTimedTextTrackList** textTracks)
        {
            return ((delegate* unmanaged<IMFTimedText*, IMFTimedTextTrackList**, int>)(lpVtbl[13]))((IMFTimedText*)Unsafe.AsPointer(ref this), textTracks);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetMetadataTracks(IMFTimedTextTrackList** metadataTracks)
        {
            return ((delegate* unmanaged<IMFTimedText*, IMFTimedTextTrackList**, int>)(lpVtbl[14]))((IMFTimedText*)Unsafe.AsPointer(ref this), metadataTracks);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SetInBandEnabled(BOOL enabled)
        {
            return ((delegate* unmanaged<IMFTimedText*, BOOL, int>)(lpVtbl[15]))((IMFTimedText*)Unsafe.AsPointer(ref this), enabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public BOOL IsInBandEnabled()
        {
            return ((delegate* unmanaged<IMFTimedText*, int>)(lpVtbl[16]))((IMFTimedText*)Unsafe.AsPointer(ref this));
        }
    }
}
