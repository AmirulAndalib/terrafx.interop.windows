// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("6E4E2102-F9CD-433D-B496-303CE03A6507")]
    [NativeTypeName("struct ITfTextInputProcessorEx : ITfTextInputProcessor")]
    [NativeInheritance("ITfTextInputProcessor")]
    public unsafe partial struct ITfTextInputProcessorEx : ITfTextInputProcessorEx.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfTextInputProcessorEx*, Guid*, void**, int>)(lpVtbl[0]))((ITfTextInputProcessorEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfTextInputProcessorEx*, uint>)(lpVtbl[1]))((ITfTextInputProcessorEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfTextInputProcessorEx*, uint>)(lpVtbl[2]))((ITfTextInputProcessorEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Activate(ITfThreadMgr* ptim, [NativeTypeName("TfClientId")] uint tid)
        {
            return ((delegate* unmanaged<ITfTextInputProcessorEx*, ITfThreadMgr*, uint, int>)(lpVtbl[3]))((ITfTextInputProcessorEx*)Unsafe.AsPointer(ref this), ptim, tid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Deactivate()
        {
            return ((delegate* unmanaged<ITfTextInputProcessorEx*, int>)(lpVtbl[4]))((ITfTextInputProcessorEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT ActivateEx(ITfThreadMgr* ptim, [NativeTypeName("TfClientId")] uint tid, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITfTextInputProcessorEx*, ITfThreadMgr*, uint, uint, int>)(lpVtbl[5]))((ITfTextInputProcessorEx*)Unsafe.AsPointer(ref this), ptim, tid, dwFlags);
        }

        public interface Interface : ITfTextInputProcessor.Interface
        {
            [VtblIndex(5)]
            HRESULT ActivateEx(ITfThreadMgr* ptim, [NativeTypeName("TfClientId")] uint tid, [NativeTypeName("DWORD")] uint dwFlags);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfTextInputProcessorEx*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfTextInputProcessorEx*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfTextInputProcessorEx*, uint> Release;

            [NativeTypeName("HRESULT (ITfThreadMgr *, TfClientId) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfTextInputProcessorEx*, ITfThreadMgr*, uint, int> Activate;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfTextInputProcessorEx*, int> Deactivate;

            [NativeTypeName("HRESULT (ITfThreadMgr *, TfClientId, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfTextInputProcessorEx*, ITfThreadMgr*, uint, uint, int> ActivateEx;
        }
    }
}
