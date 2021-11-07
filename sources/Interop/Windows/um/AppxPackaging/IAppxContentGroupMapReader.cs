// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("418726D8-DD99-4F5D-9886-157ADD20DE01")]
    [NativeTypeName("struct IAppxContentGroupMapReader : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxContentGroupMapReader : IAppxContentGroupMapReader.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxContentGroupMapReader*, Guid*, void**, int>)(lpVtbl[0]))((IAppxContentGroupMapReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxContentGroupMapReader*, uint>)(lpVtbl[1]))((IAppxContentGroupMapReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxContentGroupMapReader*, uint>)(lpVtbl[2]))((IAppxContentGroupMapReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetRequiredGroup(IAppxContentGroup** requiredGroup)
        {
            return ((delegate* unmanaged<IAppxContentGroupMapReader*, IAppxContentGroup**, int>)(lpVtbl[3]))((IAppxContentGroupMapReader*)Unsafe.AsPointer(ref this), requiredGroup);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetAutomaticGroups(IAppxContentGroupsEnumerator** automaticGroupsEnumerator)
        {
            return ((delegate* unmanaged<IAppxContentGroupMapReader*, IAppxContentGroupsEnumerator**, int>)(lpVtbl[4]))((IAppxContentGroupMapReader*)Unsafe.AsPointer(ref this), automaticGroupsEnumerator);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetRequiredGroup(IAppxContentGroup** requiredGroup);

            [VtblIndex(4)]
            HRESULT GetAutomaticGroups(IAppxContentGroupsEnumerator** automaticGroupsEnumerator);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxContentGroupMapReader*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxContentGroupMapReader*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxContentGroupMapReader*, uint> Release;

            [NativeTypeName("HRESULT (IAppxContentGroup **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxContentGroupMapReader*, IAppxContentGroup**, int> GetRequiredGroup;

            [NativeTypeName("HRESULT (IAppxContentGroupsEnumerator **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxContentGroupMapReader*, IAppxContentGroupsEnumerator**, int> GetAutomaticGroups;
        }
    }
}
