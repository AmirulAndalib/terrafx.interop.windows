// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("36B73883-C2C8-11CF-8B46-00805F6CEF60")]
    [NativeTypeName("struct ISeekingPassThru : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISeekingPassThru
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISeekingPassThru*, Guid*, void**, int>)(lpVtbl[0]))((ISeekingPassThru*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISeekingPassThru*, uint>)(lpVtbl[1]))((ISeekingPassThru*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISeekingPassThru*, uint>)(lpVtbl[2]))((ISeekingPassThru*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Init(BOOL bSupportRendering, IPin* pPin)
        {
            return ((delegate* unmanaged<ISeekingPassThru*, BOOL, IPin*, int>)(lpVtbl[3]))((ISeekingPassThru*)Unsafe.AsPointer(ref this), bSupportRendering, pPin);
        }
    }
}
