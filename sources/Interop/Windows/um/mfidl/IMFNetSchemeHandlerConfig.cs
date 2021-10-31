// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7BE19E73-C9BF-468A-AC5A-A5E8653BEC87")]
    [NativeTypeName("struct IMFNetSchemeHandlerConfig : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFNetSchemeHandlerConfig
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFNetSchemeHandlerConfig*, Guid*, void**, int>)(lpVtbl[0]))((IMFNetSchemeHandlerConfig*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFNetSchemeHandlerConfig*, uint>)(lpVtbl[1]))((IMFNetSchemeHandlerConfig*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFNetSchemeHandlerConfig*, uint>)(lpVtbl[2]))((IMFNetSchemeHandlerConfig*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetNumberOfSupportedProtocols([NativeTypeName("ULONG *")] uint* pcProtocols)
        {
            return ((delegate* unmanaged<IMFNetSchemeHandlerConfig*, uint*, int>)(lpVtbl[3]))((IMFNetSchemeHandlerConfig*)Unsafe.AsPointer(ref this), pcProtocols);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetSupportedProtocolType([NativeTypeName("ULONG")] uint nProtocolIndex, MFNETSOURCE_PROTOCOL_TYPE* pnProtocolType)
        {
            return ((delegate* unmanaged<IMFNetSchemeHandlerConfig*, uint, MFNETSOURCE_PROTOCOL_TYPE*, int>)(lpVtbl[4]))((IMFNetSchemeHandlerConfig*)Unsafe.AsPointer(ref this), nProtocolIndex, pnProtocolType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT ResetProtocolRolloverSettings()
        {
            return ((delegate* unmanaged<IMFNetSchemeHandlerConfig*, int>)(lpVtbl[5]))((IMFNetSchemeHandlerConfig*)Unsafe.AsPointer(ref this));
        }
    }
}
