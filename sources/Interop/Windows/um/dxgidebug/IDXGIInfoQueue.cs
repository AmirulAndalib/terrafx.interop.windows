// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxgidebug.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D67441C7-672A-476F-9E82-CD55B44949CE")]
    [NativeTypeName("struct IDXGIInfoQueue : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDXGIInfoQueue
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, uint>)(lpVtbl[1]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, uint>)(lpVtbl[2]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetMessageCountLimit([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("UINT64")] ulong MessageCountLimit)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong, int>)(lpVtbl[3]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, MessageCountLimit);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void ClearStoredMessages([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            ((delegate* unmanaged<IDXGIInfoQueue*, Guid, void>)(lpVtbl[4]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetMessage([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("UINT64")] ulong MessageIndex, DXGI_INFO_QUEUE_MESSAGE* pMessage, [NativeTypeName("SIZE_T *")] nuint* pMessageByteLength)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong, DXGI_INFO_QUEUE_MESSAGE*, nuint*, int>)(lpVtbl[5]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, MessageIndex, pMessage, pMessageByteLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("UINT64")]
        public ulong GetNumStoredMessagesAllowedByRetrievalFilters([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong>)(lpVtbl[6]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("UINT64")]
        public ulong GetNumStoredMessages([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong>)(lpVtbl[7]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesDiscardedByMessageCountLimit([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong>)(lpVtbl[8]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("UINT64")]
        public ulong GetMessageCountLimit([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong>)(lpVtbl[9]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesAllowedByStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong>)(lpVtbl[10]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesDeniedByStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong>)(lpVtbl[11]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT AddStorageFilterEntries([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_FILTER* pFilter)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_FILTER*, int>)(lpVtbl[12]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_FILTER*, nuint*, int>)(lpVtbl[13]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter, pFilterByteLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public void ClearStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            ((delegate* unmanaged<IDXGIInfoQueue*, Guid, void>)(lpVtbl[14]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT PushEmptyStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, int>)(lpVtbl[15]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT PushDenyAllStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, int>)(lpVtbl[16]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT PushCopyOfStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, int>)(lpVtbl[17]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT PushStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_FILTER* pFilter)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_FILTER*, int>)(lpVtbl[18]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public void PopStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            ((delegate* unmanaged<IDXGIInfoQueue*, Guid, void>)(lpVtbl[19]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public uint GetStorageFilterStackSize([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, uint>)(lpVtbl[20]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT AddRetrievalFilterEntries([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_FILTER* pFilter)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_FILTER*, int>)(lpVtbl[21]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT GetRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_FILTER*, nuint*, int>)(lpVtbl[22]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter, pFilterByteLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public void ClearRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            ((delegate* unmanaged<IDXGIInfoQueue*, Guid, void>)(lpVtbl[23]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT PushEmptyRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, int>)(lpVtbl[24]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT PushDenyAllRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, int>)(lpVtbl[25]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT PushCopyOfRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, int>)(lpVtbl[26]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT PushRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_FILTER* pFilter)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_FILTER*, int>)(lpVtbl[27]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public void PopRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            ((delegate* unmanaged<IDXGIInfoQueue*, Guid, void>)(lpVtbl[28]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public uint GetRetrievalFilterStackSize([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, uint>)(lpVtbl[29]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT AddMessage([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID, [NativeTypeName("LPCSTR")] sbyte* pDescription)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_MESSAGE_CATEGORY, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, int, sbyte*, int>)(lpVtbl[30]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, Category, Severity, ID, pDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT AddApplicationMessage(DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, [NativeTypeName("LPCSTR")] sbyte* pDescription)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, sbyte*, int>)(lpVtbl[31]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Severity, pDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT SetBreakOnCategory([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category, BOOL bEnable)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_MESSAGE_CATEGORY, BOOL, int>)(lpVtbl[32]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, Category, bEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT SetBreakOnSeverity([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, BOOL bEnable)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, BOOL, int>)(lpVtbl[33]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, Severity, bEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT SetBreakOnID([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID, BOOL bEnable)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, int, BOOL, int>)(lpVtbl[34]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, ID, bEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public BOOL GetBreakOnCategory([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_MESSAGE_CATEGORY, int>)(lpVtbl[35]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, Category);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public BOOL GetBreakOnSeverity([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, int>)(lpVtbl[36]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, Severity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public BOOL GetBreakOnID([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, int, int>)(lpVtbl[37]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, ID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public void SetMuteDebugOutput([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, BOOL bMute)
        {
            ((delegate* unmanaged<IDXGIInfoQueue*, Guid, BOOL, void>)(lpVtbl[38]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, bMute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public BOOL GetMuteDebugOutput([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, int>)(lpVtbl[39]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, uint> Release;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, UINT64) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong, int> SetMessageCountLimit;

            [NativeTypeName("void (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, void> ClearStoredMessages;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, UINT64, DXGI_INFO_QUEUE_MESSAGE *, SIZE_T *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong, DXGI_INFO_QUEUE_MESSAGE*, nuint*, int> GetMessage;

            [NativeTypeName("UINT64 (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong> GetNumStoredMessagesAllowedByRetrievalFilters;

            [NativeTypeName("UINT64 (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong> GetNumStoredMessages;

            [NativeTypeName("UINT64 (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong> GetNumMessagesDiscardedByMessageCountLimit;

            [NativeTypeName("UINT64 (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong> GetMessageCountLimit;

            [NativeTypeName("UINT64 (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong> GetNumMessagesAllowedByStorageFilter;

            [NativeTypeName("UINT64 (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong> GetNumMessagesDeniedByStorageFilter;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_FILTER*, int> AddStorageFilterEntries;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_FILTER *, SIZE_T *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_FILTER*, nuint*, int> GetStorageFilter;

            [NativeTypeName("void (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, void> ClearStorageFilter;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, int> PushEmptyStorageFilter;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, int> PushDenyAllStorageFilter;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, int> PushCopyOfStorageFilter;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_FILTER*, int> PushStorageFilter;

            [NativeTypeName("void (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, void> PopStorageFilter;

            [NativeTypeName("UINT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, uint> GetStorageFilterStackSize;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_FILTER*, int> AddRetrievalFilterEntries;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_FILTER *, SIZE_T *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_FILTER*, nuint*, int> GetRetrievalFilter;

            [NativeTypeName("void (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, void> ClearRetrievalFilter;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, int> PushEmptyRetrievalFilter;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, int> PushDenyAllRetrievalFilter;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, int> PushCopyOfRetrievalFilter;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_FILTER*, int> PushRetrievalFilter;

            [NativeTypeName("void (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, void> PopRetrievalFilter;

            [NativeTypeName("UINT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, uint> GetRetrievalFilterStackSize;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_CATEGORY, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, DXGI_INFO_QUEUE_MESSAGE_ID, LPCSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_MESSAGE_CATEGORY, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, int, sbyte*, int> AddMessage;

            [NativeTypeName("HRESULT (DXGI_INFO_QUEUE_MESSAGE_SEVERITY, LPCSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, sbyte*, int> AddApplicationMessage;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_CATEGORY, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_MESSAGE_CATEGORY, BOOL, int> SetBreakOnCategory;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, BOOL, int> SetBreakOnSeverity;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_ID, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, int, BOOL, int> SetBreakOnID;

            [NativeTypeName("BOOL (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_CATEGORY) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_MESSAGE_CATEGORY, int> GetBreakOnCategory;

            [NativeTypeName("BOOL (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_SEVERITY) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, int> GetBreakOnSeverity;

            [NativeTypeName("BOOL (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_ID) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, int, int> GetBreakOnID;

            [NativeTypeName("void (DXGI_DEBUG_ID, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, BOOL, void> SetMuteDebugOutput;

            [NativeTypeName("BOOL (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIInfoQueue*, Guid, int> GetMuteDebugOutput;
        }
    }
}
