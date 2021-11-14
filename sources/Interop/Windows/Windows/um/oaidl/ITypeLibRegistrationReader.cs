// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("ED6A8A2A-B160-4E77-8F73-AA7435CD5C27")]
    [NativeTypeName("struct ITypeLibRegistrationReader : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITypeLibRegistrationReader : ITypeLibRegistrationReader.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITypeLibRegistrationReader*, Guid*, void**, int>)(lpVtbl[0]))((ITypeLibRegistrationReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITypeLibRegistrationReader*, uint>)(lpVtbl[1]))((ITypeLibRegistrationReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITypeLibRegistrationReader*, uint>)(lpVtbl[2]))((ITypeLibRegistrationReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT EnumTypeLibRegistrations(IEnumUnknown** ppEnumUnknown)
        {
            return ((delegate* unmanaged<ITypeLibRegistrationReader*, IEnumUnknown**, int>)(lpVtbl[3]))((ITypeLibRegistrationReader*)Unsafe.AsPointer(ref this), ppEnumUnknown);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT EnumTypeLibRegistrations(IEnumUnknown** ppEnumUnknown);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeLibRegistrationReader*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeLibRegistrationReader*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeLibRegistrationReader*, uint> Release;

            [NativeTypeName("HRESULT (IEnumUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeLibRegistrationReader*, IEnumUnknown**, int> EnumTypeLibRegistrations;
        }
    }
}
