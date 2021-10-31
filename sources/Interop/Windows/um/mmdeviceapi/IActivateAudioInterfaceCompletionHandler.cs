// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("41D949AB-9862-444A-80F6-C261334DA5EB")]
    [NativeTypeName("struct IActivateAudioInterfaceCompletionHandler : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IActivateAudioInterfaceCompletionHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IActivateAudioInterfaceCompletionHandler*, Guid*, void**, int>)(lpVtbl[0]))((IActivateAudioInterfaceCompletionHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IActivateAudioInterfaceCompletionHandler*, uint>)(lpVtbl[1]))((IActivateAudioInterfaceCompletionHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IActivateAudioInterfaceCompletionHandler*, uint>)(lpVtbl[2]))((IActivateAudioInterfaceCompletionHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT ActivateCompleted(IActivateAudioInterfaceAsyncOperation* activateOperation)
        {
            return ((delegate* unmanaged<IActivateAudioInterfaceCompletionHandler*, IActivateAudioInterfaceAsyncOperation*, int>)(lpVtbl[3]))((IActivateAudioInterfaceCompletionHandler*)Unsafe.AsPointer(ref this), activateOperation);
        }
    }
}
