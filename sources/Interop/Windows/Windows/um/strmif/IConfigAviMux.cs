// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("5ACD6AA0-F482-11CE-8B67-00AA00A3F1A6")]
    [NativeTypeName("struct IConfigAviMux : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IConfigAviMux : IConfigAviMux.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IConfigAviMux*, Guid*, void**, int>)(lpVtbl[0]))((IConfigAviMux*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IConfigAviMux*, uint>)(lpVtbl[1]))((IConfigAviMux*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IConfigAviMux*, uint>)(lpVtbl[2]))((IConfigAviMux*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetMasterStream([NativeTypeName("LONG")] int iStream)
        {
            return ((delegate* unmanaged<IConfigAviMux*, int, int>)(lpVtbl[3]))((IConfigAviMux*)Unsafe.AsPointer(ref this), iStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetMasterStream([NativeTypeName("LONG *")] int* pStream)
        {
            return ((delegate* unmanaged<IConfigAviMux*, int*, int>)(lpVtbl[4]))((IConfigAviMux*)Unsafe.AsPointer(ref this), pStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetOutputCompatibilityIndex(BOOL fOldIndex)
        {
            return ((delegate* unmanaged<IConfigAviMux*, BOOL, int>)(lpVtbl[5]))((IConfigAviMux*)Unsafe.AsPointer(ref this), fOldIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetOutputCompatibilityIndex(BOOL* pfOldIndex)
        {
            return ((delegate* unmanaged<IConfigAviMux*, BOOL*, int>)(lpVtbl[6]))((IConfigAviMux*)Unsafe.AsPointer(ref this), pfOldIndex);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetMasterStream([NativeTypeName("LONG")] int iStream);

            [VtblIndex(4)]
            HRESULT GetMasterStream([NativeTypeName("LONG *")] int* pStream);

            [VtblIndex(5)]
            HRESULT SetOutputCompatibilityIndex(BOOL fOldIndex);

            [VtblIndex(6)]
            HRESULT GetOutputCompatibilityIndex(BOOL* pfOldIndex);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IConfigAviMux*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IConfigAviMux*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IConfigAviMux*, uint> Release;

            [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
            public delegate* unmanaged<IConfigAviMux*, int, int> SetMasterStream;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IConfigAviMux*, int*, int> GetMasterStream;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IConfigAviMux*, BOOL, int> SetOutputCompatibilityIndex;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IConfigAviMux*, BOOL*, int> GetOutputCompatibilityIndex;
        }
    }
}
