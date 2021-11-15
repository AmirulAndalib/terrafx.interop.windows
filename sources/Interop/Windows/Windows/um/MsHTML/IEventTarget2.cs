// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("30510839-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IEventTarget2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEventTarget2 : IEventTarget2.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEventTarget2*, Guid*, void**, int>)(lpVtbl[0]))((IEventTarget2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEventTarget2*, uint>)(lpVtbl[1]))((IEventTarget2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEventTarget2*, uint>)(lpVtbl[2]))((IEventTarget2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetRegisteredEventTypes(SAFEARRAY** ppEventTypeArray)
        {
            return ((delegate* unmanaged<IEventTarget2*, SAFEARRAY**, int>)(lpVtbl[3]))((IEventTarget2*)Unsafe.AsPointer(ref this), ppEventTypeArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetListenersForType([NativeTypeName("LPCWSTR")] ushort* pszEventType, SAFEARRAY** ppEventHandlerArray)
        {
            return ((delegate* unmanaged<IEventTarget2*, ushort*, SAFEARRAY**, int>)(lpVtbl[4]))((IEventTarget2*)Unsafe.AsPointer(ref this), pszEventType, ppEventHandlerArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT RegisterForDOMEventListeners(IDOMEventRegistrationCallback* pCallback)
        {
            return ((delegate* unmanaged<IEventTarget2*, IDOMEventRegistrationCallback*, int>)(lpVtbl[5]))((IEventTarget2*)Unsafe.AsPointer(ref this), pCallback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT UnregisterForDOMEventListeners(IDOMEventRegistrationCallback* pCallback)
        {
            return ((delegate* unmanaged<IEventTarget2*, IDOMEventRegistrationCallback*, int>)(lpVtbl[6]))((IEventTarget2*)Unsafe.AsPointer(ref this), pCallback);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetRegisteredEventTypes(SAFEARRAY** ppEventTypeArray);

            [VtblIndex(4)]
            HRESULT GetListenersForType([NativeTypeName("LPCWSTR")] ushort* pszEventType, SAFEARRAY** ppEventHandlerArray);

            [VtblIndex(5)]
            HRESULT RegisterForDOMEventListeners(IDOMEventRegistrationCallback* pCallback);

            [VtblIndex(6)]
            HRESULT UnregisterForDOMEventListeners(IDOMEventRegistrationCallback* pCallback);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IEventTarget2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IEventTarget2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IEventTarget2*, uint> Release;

            [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
            public delegate* unmanaged<IEventTarget2*, SAFEARRAY**, int> GetRegisteredEventTypes;

            [NativeTypeName("HRESULT (LPCWSTR, SAFEARRAY **) __attribute__((stdcall))")]
            public delegate* unmanaged<IEventTarget2*, ushort*, SAFEARRAY**, int> GetListenersForType;

            [NativeTypeName("HRESULT (IDOMEventRegistrationCallback *) __attribute__((stdcall))")]
            public delegate* unmanaged<IEventTarget2*, IDOMEventRegistrationCallback*, int> RegisterForDOMEventListeners;

            [NativeTypeName("HRESULT (IDOMEventRegistrationCallback *) __attribute__((stdcall))")]
            public delegate* unmanaged<IEventTarget2*, IDOMEventRegistrationCallback*, int> UnregisterForDOMEventListeners;
        }
    }
}