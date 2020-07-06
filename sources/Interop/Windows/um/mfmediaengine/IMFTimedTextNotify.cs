// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DF6B87B6-CE12-45DB-ABA7-432FE054E57D")]
    public unsafe partial struct IMFTimedTextNotify
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFTimedTextNotify*, Guid*, void**, int>)(lpVtbl[0]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFTimedTextNotify*, uint>)(lpVtbl[1]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFTimedTextNotify*, uint>)(lpVtbl[2]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this));
        }

        public void TrackAdded([NativeTypeName("DWORD")] uint trackId)
        {
            ((delegate* stdcall<IMFTimedTextNotify*, uint, void>)(lpVtbl[3]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this), trackId);
        }

        public void TrackRemoved([NativeTypeName("DWORD")] uint trackId)
        {
            ((delegate* stdcall<IMFTimedTextNotify*, uint, void>)(lpVtbl[4]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this), trackId);
        }

        public void TrackSelected([NativeTypeName("DWORD")] uint trackId, [NativeTypeName("BOOL")] int selected)
        {
            ((delegate* stdcall<IMFTimedTextNotify*, uint, int, void>)(lpVtbl[5]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this), trackId, selected);
        }

        public void TrackReadyStateChanged([NativeTypeName("DWORD")] uint trackId)
        {
            ((delegate* stdcall<IMFTimedTextNotify*, uint, void>)(lpVtbl[6]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this), trackId);
        }

        public void Error(MF_TIMED_TEXT_ERROR_CODE errorCode, [NativeTypeName("HRESULT")] int extendedErrorCode, [NativeTypeName("DWORD")] uint sourceTrackId)
        {
            ((delegate* stdcall<IMFTimedTextNotify*, MF_TIMED_TEXT_ERROR_CODE, int, uint, void>)(lpVtbl[7]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this), errorCode, extendedErrorCode, sourceTrackId);
        }

        public void Cue(MF_TIMED_TEXT_CUE_EVENT cueEvent, double currentTime, [NativeTypeName("IMFTimedTextCue *")] IMFTimedTextCue* cue)
        {
            ((delegate* stdcall<IMFTimedTextNotify*, MF_TIMED_TEXT_CUE_EVENT, double, IMFTimedTextCue*, void>)(lpVtbl[8]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this), cueEvent, currentTime, cue);
        }

        public void Reset()
        {
            ((delegate* stdcall<IMFTimedTextNotify*, void>)(lpVtbl[9]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this));
        }
    }
}