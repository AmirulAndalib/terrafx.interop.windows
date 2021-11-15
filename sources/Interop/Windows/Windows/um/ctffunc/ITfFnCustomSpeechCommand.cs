// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("FCA6C349-A12F-43A3-8DD6-5A5A4282577B")]
    [NativeTypeName("struct ITfFnCustomSpeechCommand : ITfFunction")]
    [NativeInheritance("ITfFunction")]
    public unsafe partial struct ITfFnCustomSpeechCommand : ITfFnCustomSpeechCommand.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfFnCustomSpeechCommand*, Guid*, void**, int>)(lpVtbl[0]))((ITfFnCustomSpeechCommand*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfFnCustomSpeechCommand*, uint>)(lpVtbl[1]))((ITfFnCustomSpeechCommand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfFnCustomSpeechCommand*, uint>)(lpVtbl[2]))((ITfFnCustomSpeechCommand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return ((delegate* unmanaged<ITfFnCustomSpeechCommand*, ushort**, int>)(lpVtbl[3]))((ITfFnCustomSpeechCommand*)Unsafe.AsPointer(ref this), pbstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetSpeechCommandProvider(IUnknown* pspcmdProvider)
        {
            return ((delegate* unmanaged<ITfFnCustomSpeechCommand*, IUnknown*, int>)(lpVtbl[4]))((ITfFnCustomSpeechCommand*)Unsafe.AsPointer(ref this), pspcmdProvider);
        }

        public interface Interface : ITfFunction.Interface
        {
            [VtblIndex(4)]
            HRESULT SetSpeechCommandProvider(IUnknown* pspcmdProvider);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfFnCustomSpeechCommand*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfFnCustomSpeechCommand*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfFnCustomSpeechCommand*, uint> Release;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfFnCustomSpeechCommand*, ushort**, int> GetDisplayName;

            [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfFnCustomSpeechCommand*, IUnknown*, int> SetSpeechCommandProvider;
        }
    }
}