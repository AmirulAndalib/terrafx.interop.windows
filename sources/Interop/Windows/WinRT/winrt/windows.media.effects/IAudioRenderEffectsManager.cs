// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.effects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioRenderEffectsManager.xml' path='doc/member[@name="IAudioRenderEffectsManager"]/*' />
[Guid("4DC98966-8751-42B2-BFCB-39CA7864BD47")]
[NativeTypeName("struct IAudioRenderEffectsManager : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioRenderEffectsManager : IAudioRenderEffectsManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioRenderEffectsManager));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioRenderEffectsManager*, Guid*, void**, int>)(lpVtbl[0]))((IAudioRenderEffectsManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioRenderEffectsManager*, uint>)(lpVtbl[1]))((IAudioRenderEffectsManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioRenderEffectsManager*, uint>)(lpVtbl[2]))((IAudioRenderEffectsManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioRenderEffectsManager*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioRenderEffectsManager*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioRenderEffectsManager*, HSTRING*, int>)(lpVtbl[4]))((IAudioRenderEffectsManager*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioRenderEffectsManager*, TrustLevel*, int>)(lpVtbl[5]))((IAudioRenderEffectsManager*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioRenderEffectsManager.xml' path='doc/member[@name="IAudioRenderEffectsManager.add_AudioRenderEffectsChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_AudioRenderEffectsChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CEffects__CAudioRenderEffectsManager_IInspectable_t *")] ITypedEventHandler<Pointer<IAudioRenderEffectsManager>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioRenderEffectsManager*, ITypedEventHandler<Pointer<IAudioRenderEffectsManager>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IAudioRenderEffectsManager*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAudioRenderEffectsManager.xml' path='doc/member[@name="IAudioRenderEffectsManager.remove_AudioRenderEffectsChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_AudioRenderEffectsChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioRenderEffectsManager*, EventRegistrationToken, int>)(lpVtbl[7]))((IAudioRenderEffectsManager*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAudioRenderEffectsManager.xml' path='doc/member[@name="IAudioRenderEffectsManager.GetAudioRenderEffects"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetAudioRenderEffects([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CEffects__CAudioEffect_t **")] IVectorView<Pointer<IAudioEffect>>** effects)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioRenderEffectsManager*, IVectorView<Pointer<IAudioEffect>>**, int>)(lpVtbl[8]))((IAudioRenderEffectsManager*)Unsafe.AsPointer(ref this), effects);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_AudioRenderEffectsChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CEffects__CAudioRenderEffectsManager_IInspectable_t *")] ITypedEventHandler<Pointer<IAudioRenderEffectsManager>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_AudioRenderEffectsChanged(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT GetAudioRenderEffects([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CEffects__CAudioEffect_t **")] IVectorView<Pointer<IAudioEffect>>** effects);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CEffects__CAudioRenderEffectsManager_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAudioRenderEffectsManager>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_AudioRenderEffectsChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_AudioRenderEffectsChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CEffects__CAudioEffect_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IAudioEffect>>**, int> GetAudioRenderEffects;
    }
}
