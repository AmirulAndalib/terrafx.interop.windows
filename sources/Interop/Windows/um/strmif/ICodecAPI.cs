// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("901DB4C7-31CE-41A2-85DC-8FA0BF41B8DA")]
    [NativeTypeName("struct ICodecAPI : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ICodecAPI : ICodecAPI.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICodecAPI*, Guid*, void**, int>)(lpVtbl[0]))((ICodecAPI*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICodecAPI*, uint>)(lpVtbl[1]))((ICodecAPI*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICodecAPI*, uint>)(lpVtbl[2]))((ICodecAPI*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT IsSupported([NativeTypeName("const GUID *")] Guid* Api)
        {
            return ((delegate* unmanaged<ICodecAPI*, Guid*, int>)(lpVtbl[3]))((ICodecAPI*)Unsafe.AsPointer(ref this), Api);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT IsModifiable([NativeTypeName("const GUID *")] Guid* Api)
        {
            return ((delegate* unmanaged<ICodecAPI*, Guid*, int>)(lpVtbl[4]))((ICodecAPI*)Unsafe.AsPointer(ref this), Api);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetParameterRange([NativeTypeName("const GUID *")] Guid* Api, VARIANT* ValueMin, VARIANT* ValueMax, VARIANT* SteppingDelta)
        {
            return ((delegate* unmanaged<ICodecAPI*, Guid*, VARIANT*, VARIANT*, VARIANT*, int>)(lpVtbl[5]))((ICodecAPI*)Unsafe.AsPointer(ref this), Api, ValueMin, ValueMax, SteppingDelta);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetParameterValues([NativeTypeName("const GUID *")] Guid* Api, VARIANT** Values, [NativeTypeName("ULONG *")] uint* ValuesCount)
        {
            return ((delegate* unmanaged<ICodecAPI*, Guid*, VARIANT**, uint*, int>)(lpVtbl[6]))((ICodecAPI*)Unsafe.AsPointer(ref this), Api, Values, ValuesCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetDefaultValue([NativeTypeName("const GUID *")] Guid* Api, VARIANT* Value)
        {
            return ((delegate* unmanaged<ICodecAPI*, Guid*, VARIANT*, int>)(lpVtbl[7]))((ICodecAPI*)Unsafe.AsPointer(ref this), Api, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetValue([NativeTypeName("const GUID *")] Guid* Api, VARIANT* Value)
        {
            return ((delegate* unmanaged<ICodecAPI*, Guid*, VARIANT*, int>)(lpVtbl[8]))((ICodecAPI*)Unsafe.AsPointer(ref this), Api, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetValue([NativeTypeName("const GUID *")] Guid* Api, VARIANT* Value)
        {
            return ((delegate* unmanaged<ICodecAPI*, Guid*, VARIANT*, int>)(lpVtbl[9]))((ICodecAPI*)Unsafe.AsPointer(ref this), Api, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT RegisterForEvent([NativeTypeName("const GUID *")] Guid* Api, [NativeTypeName("LONG_PTR")] nint userData)
        {
            return ((delegate* unmanaged<ICodecAPI*, Guid*, nint, int>)(lpVtbl[10]))((ICodecAPI*)Unsafe.AsPointer(ref this), Api, userData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT UnregisterForEvent([NativeTypeName("const GUID *")] Guid* Api)
        {
            return ((delegate* unmanaged<ICodecAPI*, Guid*, int>)(lpVtbl[11]))((ICodecAPI*)Unsafe.AsPointer(ref this), Api);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SetAllDefaults()
        {
            return ((delegate* unmanaged<ICodecAPI*, int>)(lpVtbl[12]))((ICodecAPI*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT SetValueWithNotify([NativeTypeName("const GUID *")] Guid* Api, VARIANT* Value, Guid** ChangedParam, [NativeTypeName("ULONG *")] uint* ChangedParamCount)
        {
            return ((delegate* unmanaged<ICodecAPI*, Guid*, VARIANT*, Guid**, uint*, int>)(lpVtbl[13]))((ICodecAPI*)Unsafe.AsPointer(ref this), Api, Value, ChangedParam, ChangedParamCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT SetAllDefaultsWithNotify(Guid** ChangedParam, [NativeTypeName("ULONG *")] uint* ChangedParamCount)
        {
            return ((delegate* unmanaged<ICodecAPI*, Guid**, uint*, int>)(lpVtbl[14]))((ICodecAPI*)Unsafe.AsPointer(ref this), ChangedParam, ChangedParamCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetAllSettings(IStream* __MIDL__ICodecAPI0000)
        {
            return ((delegate* unmanaged<ICodecAPI*, IStream*, int>)(lpVtbl[15]))((ICodecAPI*)Unsafe.AsPointer(ref this), __MIDL__ICodecAPI0000);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT SetAllSettings(IStream* __MIDL__ICodecAPI0001)
        {
            return ((delegate* unmanaged<ICodecAPI*, IStream*, int>)(lpVtbl[16]))((ICodecAPI*)Unsafe.AsPointer(ref this), __MIDL__ICodecAPI0001);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT SetAllSettingsWithNotify(IStream* __MIDL__ICodecAPI0002, Guid** ChangedParam, [NativeTypeName("ULONG *")] uint* ChangedParamCount)
        {
            return ((delegate* unmanaged<ICodecAPI*, IStream*, Guid**, uint*, int>)(lpVtbl[17]))((ICodecAPI*)Unsafe.AsPointer(ref this), __MIDL__ICodecAPI0002, ChangedParam, ChangedParamCount);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT IsSupported([NativeTypeName("const GUID *")] Guid* Api);

            [VtblIndex(4)]
            HRESULT IsModifiable([NativeTypeName("const GUID *")] Guid* Api);

            [VtblIndex(5)]
            HRESULT GetParameterRange([NativeTypeName("const GUID *")] Guid* Api, VARIANT* ValueMin, VARIANT* ValueMax, VARIANT* SteppingDelta);

            [VtblIndex(6)]
            HRESULT GetParameterValues([NativeTypeName("const GUID *")] Guid* Api, VARIANT** Values, [NativeTypeName("ULONG *")] uint* ValuesCount);

            [VtblIndex(7)]
            HRESULT GetDefaultValue([NativeTypeName("const GUID *")] Guid* Api, VARIANT* Value);

            [VtblIndex(8)]
            HRESULT GetValue([NativeTypeName("const GUID *")] Guid* Api, VARIANT* Value);

            [VtblIndex(9)]
            HRESULT SetValue([NativeTypeName("const GUID *")] Guid* Api, VARIANT* Value);

            [VtblIndex(10)]
            HRESULT RegisterForEvent([NativeTypeName("const GUID *")] Guid* Api, [NativeTypeName("LONG_PTR")] nint userData);

            [VtblIndex(11)]
            HRESULT UnregisterForEvent([NativeTypeName("const GUID *")] Guid* Api);

            [VtblIndex(12)]
            HRESULT SetAllDefaults();

            [VtblIndex(13)]
            HRESULT SetValueWithNotify([NativeTypeName("const GUID *")] Guid* Api, VARIANT* Value, Guid** ChangedParam, [NativeTypeName("ULONG *")] uint* ChangedParamCount);

            [VtblIndex(14)]
            HRESULT SetAllDefaultsWithNotify(Guid** ChangedParam, [NativeTypeName("ULONG *")] uint* ChangedParamCount);

            [VtblIndex(15)]
            HRESULT GetAllSettings(IStream* __MIDL__ICodecAPI0000);

            [VtblIndex(16)]
            HRESULT SetAllSettings(IStream* __MIDL__ICodecAPI0001);

            [VtblIndex(17)]
            HRESULT SetAllSettingsWithNotify(IStream* __MIDL__ICodecAPI0002, Guid** ChangedParam, [NativeTypeName("ULONG *")] uint* ChangedParamCount);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ICodecAPI*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICodecAPI*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICodecAPI*, uint> Release;

            [NativeTypeName("HRESULT (const GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICodecAPI*, Guid*, int> IsSupported;

            [NativeTypeName("HRESULT (const GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICodecAPI*, Guid*, int> IsModifiable;

            [NativeTypeName("HRESULT (const GUID *, VARIANT *, VARIANT *, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICodecAPI*, Guid*, VARIANT*, VARIANT*, VARIANT*, int> GetParameterRange;

            [NativeTypeName("HRESULT (const GUID *, VARIANT **, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICodecAPI*, Guid*, VARIANT**, uint*, int> GetParameterValues;

            [NativeTypeName("HRESULT (const GUID *, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICodecAPI*, Guid*, VARIANT*, int> GetDefaultValue;

            [NativeTypeName("HRESULT (const GUID *, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICodecAPI*, Guid*, VARIANT*, int> GetValue;

            [NativeTypeName("HRESULT (const GUID *, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICodecAPI*, Guid*, VARIANT*, int> SetValue;

            [NativeTypeName("HRESULT (const GUID *, LONG_PTR) __attribute__((stdcall))")]
            public delegate* unmanaged<ICodecAPI*, Guid*, nint, int> RegisterForEvent;

            [NativeTypeName("HRESULT (const GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICodecAPI*, Guid*, int> UnregisterForEvent;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<ICodecAPI*, int> SetAllDefaults;

            [NativeTypeName("HRESULT (const GUID *, VARIANT *, GUID **, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICodecAPI*, Guid*, VARIANT*, Guid**, uint*, int> SetValueWithNotify;

            [NativeTypeName("HRESULT (GUID **, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICodecAPI*, Guid**, uint*, int> SetAllDefaultsWithNotify;

            [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICodecAPI*, IStream*, int> GetAllSettings;

            [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICodecAPI*, IStream*, int> SetAllSettings;

            [NativeTypeName("HRESULT (IStream *, GUID **, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICodecAPI*, IStream*, Guid**, uint*, int> SetAllSettingsWithNotify;
        }
    }
}
