// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("46A30204-A696-4B18-8804-246B8F031BB1")]
    [NativeTypeName("struct IMFMediaEngineNeedKeyNotify : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFMediaEngineNeedKeyNotify
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaEngineNeedKeyNotify*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineNeedKeyNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMediaEngineNeedKeyNotify*, uint>)(lpVtbl[1]))((IMFMediaEngineNeedKeyNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMediaEngineNeedKeyNotify*, uint>)(lpVtbl[2]))((IMFMediaEngineNeedKeyNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void NeedKey([NativeTypeName("const BYTE *")] byte* initData, [NativeTypeName("DWORD")] uint cb)
        {
            ((delegate* unmanaged<IMFMediaEngineNeedKeyNotify*, byte*, uint, void>)(lpVtbl[3]))((IMFMediaEngineNeedKeyNotify*)Unsafe.AsPointer(ref this), initData, cb);
        }
    }
}
