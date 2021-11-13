// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("00000016-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IMessageFilter : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMessageFilter : IMessageFilter.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMessageFilter*, Guid*, void**, int>)(lpVtbl[0]))((IMessageFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMessageFilter*, uint>)(lpVtbl[1]))((IMessageFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMessageFilter*, uint>)(lpVtbl[2]))((IMessageFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("DWORD")]
        public uint HandleInComingCall([NativeTypeName("DWORD")] uint dwCallType, HTASK htaskCaller, [NativeTypeName("DWORD")] uint dwTickCount, [NativeTypeName("LPINTERFACEINFO")] INTERFACEINFO* lpInterfaceInfo)
        {
            return ((delegate* unmanaged<IMessageFilter*, uint, HTASK, uint, INTERFACEINFO*, uint>)(lpVtbl[3]))((IMessageFilter*)Unsafe.AsPointer(ref this), dwCallType, htaskCaller, dwTickCount, lpInterfaceInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("DWORD")]
        public uint RetryRejectedCall(HTASK htaskCallee, [NativeTypeName("DWORD")] uint dwTickCount, [NativeTypeName("DWORD")] uint dwRejectType)
        {
            return ((delegate* unmanaged<IMessageFilter*, HTASK, uint, uint, uint>)(lpVtbl[4]))((IMessageFilter*)Unsafe.AsPointer(ref this), htaskCallee, dwTickCount, dwRejectType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("DWORD")]
        public uint MessagePending(HTASK htaskCallee, [NativeTypeName("DWORD")] uint dwTickCount, [NativeTypeName("DWORD")] uint dwPendingType)
        {
            return ((delegate* unmanaged<IMessageFilter*, HTASK, uint, uint, uint>)(lpVtbl[5]))((IMessageFilter*)Unsafe.AsPointer(ref this), htaskCallee, dwTickCount, dwPendingType);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            [return: NativeTypeName("DWORD")]
            uint HandleInComingCall([NativeTypeName("DWORD")] uint dwCallType, HTASK htaskCaller, [NativeTypeName("DWORD")] uint dwTickCount, [NativeTypeName("LPINTERFACEINFO")] INTERFACEINFO* lpInterfaceInfo);

            [VtblIndex(4)]
            [return: NativeTypeName("DWORD")]
            uint RetryRejectedCall(HTASK htaskCallee, [NativeTypeName("DWORD")] uint dwTickCount, [NativeTypeName("DWORD")] uint dwRejectType);

            [VtblIndex(5)]
            [return: NativeTypeName("DWORD")]
            uint MessagePending(HTASK htaskCallee, [NativeTypeName("DWORD")] uint dwTickCount, [NativeTypeName("DWORD")] uint dwPendingType);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMessageFilter*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMessageFilter*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMessageFilter*, uint> Release;

            [NativeTypeName("DWORD (DWORD, HTASK, DWORD, LPINTERFACEINFO) __attribute__((stdcall))")]
            public delegate* unmanaged<IMessageFilter*, uint, HTASK, uint, INTERFACEINFO*, uint> HandleInComingCall;

            [NativeTypeName("DWORD (HTASK, DWORD, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IMessageFilter*, HTASK, uint, uint, uint> RetryRejectedCall;

            [NativeTypeName("DWORD (HTASK, DWORD, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IMessageFilter*, HTASK, uint, uint, uint> MessagePending;
        }
    }
}
