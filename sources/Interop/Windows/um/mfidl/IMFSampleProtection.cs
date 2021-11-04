// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8E36395F-C7B9-43C4-A54D-512B4AF63C95")]
    [NativeTypeName("struct IMFSampleProtection : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFSampleProtection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSampleProtection*, Guid*, void**, int>)(lpVtbl[0]))((IMFSampleProtection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSampleProtection*, uint>)(lpVtbl[1]))((IMFSampleProtection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSampleProtection*, uint>)(lpVtbl[2]))((IMFSampleProtection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetInputProtectionVersion([NativeTypeName("DWORD *")] uint* pdwVersion)
        {
            return ((delegate* unmanaged<IMFSampleProtection*, uint*, int>)(lpVtbl[3]))((IMFSampleProtection*)Unsafe.AsPointer(ref this), pdwVersion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetOutputProtectionVersion([NativeTypeName("DWORD *")] uint* pdwVersion)
        {
            return ((delegate* unmanaged<IMFSampleProtection*, uint*, int>)(lpVtbl[4]))((IMFSampleProtection*)Unsafe.AsPointer(ref this), pdwVersion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetProtectionCertificate([NativeTypeName("DWORD")] uint dwVersion, byte** ppCert, [NativeTypeName("DWORD *")] uint* pcbCert)
        {
            return ((delegate* unmanaged<IMFSampleProtection*, uint, byte**, uint*, int>)(lpVtbl[5]))((IMFSampleProtection*)Unsafe.AsPointer(ref this), dwVersion, ppCert, pcbCert);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT InitOutputProtection([NativeTypeName("DWORD")] uint dwVersion, [NativeTypeName("DWORD")] uint dwOutputId, byte* pbCert, [NativeTypeName("DWORD")] uint cbCert, byte** ppbSeed, [NativeTypeName("DWORD *")] uint* pcbSeed)
        {
            return ((delegate* unmanaged<IMFSampleProtection*, uint, uint, byte*, uint, byte**, uint*, int>)(lpVtbl[6]))((IMFSampleProtection*)Unsafe.AsPointer(ref this), dwVersion, dwOutputId, pbCert, cbCert, ppbSeed, pcbSeed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT InitInputProtection([NativeTypeName("DWORD")] uint dwVersion, [NativeTypeName("DWORD")] uint dwInputId, byte* pbSeed, [NativeTypeName("DWORD")] uint cbSeed)
        {
            return ((delegate* unmanaged<IMFSampleProtection*, uint, uint, byte*, uint, int>)(lpVtbl[7]))((IMFSampleProtection*)Unsafe.AsPointer(ref this), dwVersion, dwInputId, pbSeed, cbSeed);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSampleProtection*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSampleProtection*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSampleProtection*, uint> Release;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSampleProtection*, uint*, int> GetInputProtectionVersion;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSampleProtection*, uint*, int> GetOutputProtectionVersion;

            [NativeTypeName("HRESULT (DWORD, BYTE **, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSampleProtection*, uint, byte**, uint*, int> GetProtectionCertificate;

            [NativeTypeName("HRESULT (DWORD, DWORD, BYTE *, DWORD, BYTE **, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSampleProtection*, uint, uint, byte*, uint, byte**, uint*, int> InitOutputProtection;

            [NativeTypeName("HRESULT (DWORD, DWORD, BYTE *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSampleProtection*, uint, uint, byte*, uint, int> InitInputProtection;
        }
    }
}
