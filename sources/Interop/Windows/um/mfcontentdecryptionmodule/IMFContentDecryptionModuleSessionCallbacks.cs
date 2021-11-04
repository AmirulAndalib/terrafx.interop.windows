// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcontentdecryptionmodule.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3F96EE40-AD81-4096-8470-59A4B770F89A")]
    [NativeTypeName("struct IMFContentDecryptionModuleSessionCallbacks : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFContentDecryptionModuleSessionCallbacks
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFContentDecryptionModuleSessionCallbacks*, Guid*, void**, int>)(lpVtbl[0]))((IMFContentDecryptionModuleSessionCallbacks*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFContentDecryptionModuleSessionCallbacks*, uint>)(lpVtbl[1]))((IMFContentDecryptionModuleSessionCallbacks*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFContentDecryptionModuleSessionCallbacks*, uint>)(lpVtbl[2]))((IMFContentDecryptionModuleSessionCallbacks*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT KeyMessage(MF_MEDIAKEYSESSION_MESSAGETYPE messageType, [NativeTypeName("const BYTE *")] byte* message, [NativeTypeName("DWORD")] uint messageSize, [NativeTypeName("LPCWSTR")] ushort* destinationURL)
        {
            return ((delegate* unmanaged<IMFContentDecryptionModuleSessionCallbacks*, MF_MEDIAKEYSESSION_MESSAGETYPE, byte*, uint, ushort*, int>)(lpVtbl[3]))((IMFContentDecryptionModuleSessionCallbacks*)Unsafe.AsPointer(ref this), messageType, message, messageSize, destinationURL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT KeyStatusChanged()
        {
            return ((delegate* unmanaged<IMFContentDecryptionModuleSessionCallbacks*, int>)(lpVtbl[4]))((IMFContentDecryptionModuleSessionCallbacks*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFContentDecryptionModuleSessionCallbacks*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFContentDecryptionModuleSessionCallbacks*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFContentDecryptionModuleSessionCallbacks*, uint> Release;

            [NativeTypeName("HRESULT (MF_MEDIAKEYSESSION_MESSAGETYPE, const BYTE *, DWORD, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFContentDecryptionModuleSessionCallbacks*, MF_MEDIAKEYSESSION_MESSAGETYPE, byte*, uint, ushort*, int> KeyMessage;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFContentDecryptionModuleSessionCallbacks*, int> KeyStatusChanged;
        }
    }
}
