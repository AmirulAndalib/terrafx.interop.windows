// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BB08F7A9-607A-4384-8623-056892B64371")]
    [NativeTypeName("struct ITfCompartment : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfCompartment : ITfCompartment.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfCompartment*, Guid*, void**, int>)(lpVtbl[0]))((ITfCompartment*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfCompartment*, uint>)(lpVtbl[1]))((ITfCompartment*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfCompartment*, uint>)(lpVtbl[2]))((ITfCompartment*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetValue([NativeTypeName("TfClientId")] uint tid, [NativeTypeName("const VARIANT *")] VARIANT* pvarValue)
        {
            return ((delegate* unmanaged<ITfCompartment*, uint, VARIANT*, int>)(lpVtbl[3]))((ITfCompartment*)Unsafe.AsPointer(ref this), tid, pvarValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetValue(VARIANT* pvarValue)
        {
            return ((delegate* unmanaged<ITfCompartment*, VARIANT*, int>)(lpVtbl[4]))((ITfCompartment*)Unsafe.AsPointer(ref this), pvarValue);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetValue([NativeTypeName("TfClientId")] uint tid, [NativeTypeName("const VARIANT *")] VARIANT* pvarValue);

            [VtblIndex(4)]
            HRESULT GetValue(VARIANT* pvarValue);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfCompartment*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfCompartment*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfCompartment*, uint> Release;

            [NativeTypeName("HRESULT (TfClientId, const VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfCompartment*, uint, VARIANT*, int> SetValue;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfCompartment*, VARIANT*, int> GetValue;
        }
    }
}
