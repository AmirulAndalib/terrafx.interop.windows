// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("157733FD-A592-42E5-B594-248468C5A81B")]
    [NativeTypeName("struct IAccessibilityDockingServiceCallback : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAccessibilityDockingServiceCallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAccessibilityDockingServiceCallback*, Guid*, void**, int>)(lpVtbl[0]))((IAccessibilityDockingServiceCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAccessibilityDockingServiceCallback*, uint>)(lpVtbl[1]))((IAccessibilityDockingServiceCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAccessibilityDockingServiceCallback*, uint>)(lpVtbl[2]))((IAccessibilityDockingServiceCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Undocked(UNDOCK_REASON undockReason)
        {
            return ((delegate* unmanaged<IAccessibilityDockingServiceCallback*, UNDOCK_REASON, int>)(lpVtbl[3]))((IAccessibilityDockingServiceCallback*)Unsafe.AsPointer(ref this), undockReason);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAccessibilityDockingServiceCallback*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAccessibilityDockingServiceCallback*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAccessibilityDockingServiceCallback*, uint> Release;

            [NativeTypeName("HRESULT (UNDOCK_REASON) __attribute__((stdcall))")]
            public delegate* unmanaged<IAccessibilityDockingServiceCallback*, UNDOCK_REASON, int> Undocked;
        }
    }
}
