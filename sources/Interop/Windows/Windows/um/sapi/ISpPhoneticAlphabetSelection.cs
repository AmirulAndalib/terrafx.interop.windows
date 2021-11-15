// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("B2745EFD-42CE-48CA-81F1-A96E02538A90")]
    [NativeTypeName("struct ISpPhoneticAlphabetSelection : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISpPhoneticAlphabetSelection : ISpPhoneticAlphabetSelection.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpPhoneticAlphabetSelection*, Guid*, void**, int>)(lpVtbl[0]))((ISpPhoneticAlphabetSelection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpPhoneticAlphabetSelection*, uint>)(lpVtbl[1]))((ISpPhoneticAlphabetSelection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpPhoneticAlphabetSelection*, uint>)(lpVtbl[2]))((ISpPhoneticAlphabetSelection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT IsAlphabetUPS(BOOL* pfIsUPS)
        {
            return ((delegate* unmanaged<ISpPhoneticAlphabetSelection*, BOOL*, int>)(lpVtbl[3]))((ISpPhoneticAlphabetSelection*)Unsafe.AsPointer(ref this), pfIsUPS);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetAlphabetToUPS(BOOL fForceUPS)
        {
            return ((delegate* unmanaged<ISpPhoneticAlphabetSelection*, BOOL, int>)(lpVtbl[4]))((ISpPhoneticAlphabetSelection*)Unsafe.AsPointer(ref this), fForceUPS);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT IsAlphabetUPS(BOOL* pfIsUPS);

            [VtblIndex(4)]
            HRESULT SetAlphabetToUPS(BOOL fForceUPS);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpPhoneticAlphabetSelection*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpPhoneticAlphabetSelection*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpPhoneticAlphabetSelection*, uint> Release;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpPhoneticAlphabetSelection*, BOOL*, int> IsAlphabetUPS;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpPhoneticAlphabetSelection*, BOOL, int> SetAlphabetToUPS;
        }
    }
}