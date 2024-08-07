// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer"]/*' />
[Guid("B47A37BF-3D6B-4F88-83E8-6DCB4012FFB0")]
[NativeTypeName("struct IGestureRecognizer : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGestureRecognizer : IGestureRecognizer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGestureRecognizer));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, Guid*, void**, int>)(lpVtbl[0]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, uint>)(lpVtbl[1]))((IGestureRecognizer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, uint>)(lpVtbl[2]))((IGestureRecognizer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, uint*, Guid**, int>)(lpVtbl[3]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, HSTRING*, int>)(lpVtbl[4]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, TrustLevel*, int>)(lpVtbl[5]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.get_GestureSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_GestureSettings([NativeTypeName("ABI::Windows::UI::Input::GestureSettings *")] GestureSettings* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, GestureSettings*, int>)(lpVtbl[6]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.put_GestureSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_GestureSettings([NativeTypeName("ABI::Windows::UI::Input::GestureSettings")] GestureSettings value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, GestureSettings, int>)(lpVtbl[7]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.get_IsInertial"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsInertial([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, byte*, int>)(lpVtbl[8]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.get_IsActive"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsActive([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, byte*, int>)(lpVtbl[9]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.get_ShowGestureFeedback"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ShowGestureFeedback([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, byte*, int>)(lpVtbl[10]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.put_ShowGestureFeedback"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ShowGestureFeedback([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, byte, int>)(lpVtbl[11]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.get_PivotCenter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_PivotCenter([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, Point*, int>)(lpVtbl[12]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.put_PivotCenter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_PivotCenter([NativeTypeName("ABI::Windows::Foundation::Point")] Point value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, Point, int>)(lpVtbl[13]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.get_PivotRadius"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_PivotRadius(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, float*, int>)(lpVtbl[14]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.put_PivotRadius"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_PivotRadius(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, float, int>)(lpVtbl[15]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.get_InertiaTranslationDeceleration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_InertiaTranslationDeceleration(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, float*, int>)(lpVtbl[16]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.put_InertiaTranslationDeceleration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_InertiaTranslationDeceleration(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, float, int>)(lpVtbl[17]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.get_InertiaRotationDeceleration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_InertiaRotationDeceleration(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, float*, int>)(lpVtbl[18]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.put_InertiaRotationDeceleration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_InertiaRotationDeceleration(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, float, int>)(lpVtbl[19]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.get_InertiaExpansionDeceleration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_InertiaExpansionDeceleration(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, float*, int>)(lpVtbl[20]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.put_InertiaExpansionDeceleration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_InertiaExpansionDeceleration(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, float, int>)(lpVtbl[21]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.get_InertiaTranslationDisplacement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_InertiaTranslationDisplacement(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, float*, int>)(lpVtbl[22]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.put_InertiaTranslationDisplacement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_InertiaTranslationDisplacement(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, float, int>)(lpVtbl[23]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.get_InertiaRotationAngle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_InertiaRotationAngle(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, float*, int>)(lpVtbl[24]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.put_InertiaRotationAngle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_InertiaRotationAngle(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, float, int>)(lpVtbl[25]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.get_InertiaExpansion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_InertiaExpansion(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, float*, int>)(lpVtbl[26]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.put_InertiaExpansion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_InertiaExpansion(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, float, int>)(lpVtbl[27]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.get_ManipulationExact"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_ManipulationExact([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, byte*, int>)(lpVtbl[28]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.put_ManipulationExact"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_ManipulationExact([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, byte, int>)(lpVtbl[29]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.get_CrossSlideThresholds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_CrossSlideThresholds([NativeTypeName("ABI::Windows::UI::Input::CrossSlideThresholds *")] CrossSlideThresholds* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, CrossSlideThresholds*, int>)(lpVtbl[30]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.put_CrossSlideThresholds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_CrossSlideThresholds([NativeTypeName("ABI::Windows::UI::Input::CrossSlideThresholds")] CrossSlideThresholds value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, CrossSlideThresholds, int>)(lpVtbl[31]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.get_CrossSlideHorizontally"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_CrossSlideHorizontally([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, byte*, int>)(lpVtbl[32]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.put_CrossSlideHorizontally"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_CrossSlideHorizontally([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, byte, int>)(lpVtbl[33]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.get_CrossSlideExact"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_CrossSlideExact([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, byte*, int>)(lpVtbl[34]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.put_CrossSlideExact"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT put_CrossSlideExact([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, byte, int>)(lpVtbl[35]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.get_AutoProcessInertia"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_AutoProcessInertia([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, byte*, int>)(lpVtbl[36]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.put_AutoProcessInertia"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT put_AutoProcessInertia([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, byte, int>)(lpVtbl[37]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.get_MouseWheelParameters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_MouseWheelParameters([NativeTypeName("ABI::Windows::UI::Input::IMouseWheelParameters **")] IMouseWheelParameters** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, IMouseWheelParameters**, int>)(lpVtbl[38]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.CanBeDoubleTap"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT CanBeDoubleTap([NativeTypeName("ABI::Windows::UI::Input::IPointerPoint *")] IPointerPoint* value, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, IPointerPoint*, byte*, int>)(lpVtbl[39]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value, result);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.ProcessDownEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT ProcessDownEvent([NativeTypeName("ABI::Windows::UI::Input::IPointerPoint *")] IPointerPoint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, IPointerPoint*, int>)(lpVtbl[40]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.ProcessMoveEvents"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT ProcessMoveEvents([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CPointerPoint_t *")] IVector<Pointer<IPointerPoint>>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, IVector<Pointer<IPointerPoint>>*, int>)(lpVtbl[41]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.ProcessUpEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT ProcessUpEvent([NativeTypeName("ABI::Windows::UI::Input::IPointerPoint *")] IPointerPoint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, IPointerPoint*, int>)(lpVtbl[42]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.ProcessMouseWheelEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT ProcessMouseWheelEvent([NativeTypeName("ABI::Windows::UI::Input::IPointerPoint *")] IPointerPoint* value, [NativeTypeName("boolean")] byte isShiftKeyDown, [NativeTypeName("boolean")] byte isControlKeyDown)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, IPointerPoint*, byte, byte, int>)(lpVtbl[43]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value, isShiftKeyDown, isControlKeyDown);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.ProcessInertia"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT ProcessInertia()
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, int>)(lpVtbl[44]))((IGestureRecognizer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.CompleteGesture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT CompleteGesture()
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, int>)(lpVtbl[45]))((IGestureRecognizer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.add_Tapped"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT add_Tapped([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CTappedEventArgs_t *")] ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<ITappedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<ITappedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[46]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.remove_Tapped"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT remove_Tapped(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, EventRegistrationToken, int>)(lpVtbl[47]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.add_RightTapped"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT add_RightTapped([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CRightTappedEventArgs_t *")] ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<IRightTappedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<IRightTappedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[48]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.remove_RightTapped"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT remove_RightTapped(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, EventRegistrationToken, int>)(lpVtbl[49]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.add_Holding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT add_Holding([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CHoldingEventArgs_t *")] ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<IHoldingEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<IHoldingEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[50]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.remove_Holding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT remove_Holding(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, EventRegistrationToken, int>)(lpVtbl[51]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.add_Dragging"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT add_Dragging([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CDraggingEventArgs_t *")] ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<IDraggingEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<IDraggingEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[52]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.remove_Dragging"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT remove_Dragging(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, EventRegistrationToken, int>)(lpVtbl[53]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.add_ManipulationStarted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT add_ManipulationStarted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CManipulationStartedEventArgs_t *")] ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<IManipulationStartedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<IManipulationStartedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[54]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.remove_ManipulationStarted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT remove_ManipulationStarted(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, EventRegistrationToken, int>)(lpVtbl[55]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.add_ManipulationUpdated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT add_ManipulationUpdated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CManipulationUpdatedEventArgs_t *")] ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<IManipulationUpdatedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<IManipulationUpdatedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[56]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.remove_ManipulationUpdated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT remove_ManipulationUpdated(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, EventRegistrationToken, int>)(lpVtbl[57]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.add_ManipulationInertiaStarting"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT add_ManipulationInertiaStarting([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CManipulationInertiaStartingEventArgs_t *")] ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<IManipulationInertiaStartingEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<IManipulationInertiaStartingEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[58]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.remove_ManipulationInertiaStarting"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT remove_ManipulationInertiaStarting(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, EventRegistrationToken, int>)(lpVtbl[59]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.add_ManipulationCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT add_ManipulationCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CManipulationCompletedEventArgs_t *")] ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<IManipulationCompletedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<IManipulationCompletedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[60]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.remove_ManipulationCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT remove_ManipulationCompleted(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, EventRegistrationToken, int>)(lpVtbl[61]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.add_CrossSliding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT add_CrossSliding([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CCrossSlidingEventArgs_t *")] ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<ICrossSlidingEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<ICrossSlidingEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[62]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IGestureRecognizer.xml' path='doc/member[@name="IGestureRecognizer.remove_CrossSliding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT remove_CrossSliding(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer*, EventRegistrationToken, int>)(lpVtbl[63]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_GestureSettings([NativeTypeName("ABI::Windows::UI::Input::GestureSettings *")] GestureSettings* value);

        [VtblIndex(7)]
        HRESULT put_GestureSettings([NativeTypeName("ABI::Windows::UI::Input::GestureSettings")] GestureSettings value);

        [VtblIndex(8)]
        HRESULT get_IsInertial([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_IsActive([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_ShowGestureFeedback([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_ShowGestureFeedback([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        HRESULT get_PivotCenter([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value);

        [VtblIndex(13)]
        HRESULT put_PivotCenter([NativeTypeName("ABI::Windows::Foundation::Point")] Point value);

        [VtblIndex(14)]
        HRESULT get_PivotRadius(float* value);

        [VtblIndex(15)]
        HRESULT put_PivotRadius(float value);

        [VtblIndex(16)]
        HRESULT get_InertiaTranslationDeceleration(float* value);

        [VtblIndex(17)]
        HRESULT put_InertiaTranslationDeceleration(float value);

        [VtblIndex(18)]
        HRESULT get_InertiaRotationDeceleration(float* value);

        [VtblIndex(19)]
        HRESULT put_InertiaRotationDeceleration(float value);

        [VtblIndex(20)]
        HRESULT get_InertiaExpansionDeceleration(float* value);

        [VtblIndex(21)]
        HRESULT put_InertiaExpansionDeceleration(float value);

        [VtblIndex(22)]
        HRESULT get_InertiaTranslationDisplacement(float* value);

        [VtblIndex(23)]
        HRESULT put_InertiaTranslationDisplacement(float value);

        [VtblIndex(24)]
        HRESULT get_InertiaRotationAngle(float* value);

        [VtblIndex(25)]
        HRESULT put_InertiaRotationAngle(float value);

        [VtblIndex(26)]
        HRESULT get_InertiaExpansion(float* value);

        [VtblIndex(27)]
        HRESULT put_InertiaExpansion(float value);

        [VtblIndex(28)]
        HRESULT get_ManipulationExact([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(29)]
        HRESULT put_ManipulationExact([NativeTypeName("boolean")] byte value);

        [VtblIndex(30)]
        HRESULT get_CrossSlideThresholds([NativeTypeName("ABI::Windows::UI::Input::CrossSlideThresholds *")] CrossSlideThresholds* value);

        [VtblIndex(31)]
        HRESULT put_CrossSlideThresholds([NativeTypeName("ABI::Windows::UI::Input::CrossSlideThresholds")] CrossSlideThresholds value);

        [VtblIndex(32)]
        HRESULT get_CrossSlideHorizontally([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(33)]
        HRESULT put_CrossSlideHorizontally([NativeTypeName("boolean")] byte value);

        [VtblIndex(34)]
        HRESULT get_CrossSlideExact([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(35)]
        HRESULT put_CrossSlideExact([NativeTypeName("boolean")] byte value);

        [VtblIndex(36)]
        HRESULT get_AutoProcessInertia([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(37)]
        HRESULT put_AutoProcessInertia([NativeTypeName("boolean")] byte value);

        [VtblIndex(38)]
        HRESULT get_MouseWheelParameters([NativeTypeName("ABI::Windows::UI::Input::IMouseWheelParameters **")] IMouseWheelParameters** value);

        [VtblIndex(39)]
        HRESULT CanBeDoubleTap([NativeTypeName("ABI::Windows::UI::Input::IPointerPoint *")] IPointerPoint* value, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(40)]
        HRESULT ProcessDownEvent([NativeTypeName("ABI::Windows::UI::Input::IPointerPoint *")] IPointerPoint* value);

        [VtblIndex(41)]
        HRESULT ProcessMoveEvents([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CPointerPoint_t *")] IVector<Pointer<IPointerPoint>>* value);

        [VtblIndex(42)]
        HRESULT ProcessUpEvent([NativeTypeName("ABI::Windows::UI::Input::IPointerPoint *")] IPointerPoint* value);

        [VtblIndex(43)]
        HRESULT ProcessMouseWheelEvent([NativeTypeName("ABI::Windows::UI::Input::IPointerPoint *")] IPointerPoint* value, [NativeTypeName("boolean")] byte isShiftKeyDown, [NativeTypeName("boolean")] byte isControlKeyDown);

        [VtblIndex(44)]
        HRESULT ProcessInertia();

        [VtblIndex(45)]
        HRESULT CompleteGesture();

        [VtblIndex(46)]
        HRESULT add_Tapped([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CTappedEventArgs_t *")] ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<ITappedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(47)]
        HRESULT remove_Tapped(EventRegistrationToken token);

        [VtblIndex(48)]
        HRESULT add_RightTapped([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CRightTappedEventArgs_t *")] ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<IRightTappedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(49)]
        HRESULT remove_RightTapped(EventRegistrationToken token);

        [VtblIndex(50)]
        HRESULT add_Holding([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CHoldingEventArgs_t *")] ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<IHoldingEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(51)]
        HRESULT remove_Holding(EventRegistrationToken token);

        [VtblIndex(52)]
        HRESULT add_Dragging([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CDraggingEventArgs_t *")] ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<IDraggingEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(53)]
        HRESULT remove_Dragging(EventRegistrationToken token);

        [VtblIndex(54)]
        HRESULT add_ManipulationStarted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CManipulationStartedEventArgs_t *")] ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<IManipulationStartedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(55)]
        HRESULT remove_ManipulationStarted(EventRegistrationToken token);

        [VtblIndex(56)]
        HRESULT add_ManipulationUpdated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CManipulationUpdatedEventArgs_t *")] ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<IManipulationUpdatedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(57)]
        HRESULT remove_ManipulationUpdated(EventRegistrationToken token);

        [VtblIndex(58)]
        HRESULT add_ManipulationInertiaStarting([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CManipulationInertiaStartingEventArgs_t *")] ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<IManipulationInertiaStartingEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(59)]
        HRESULT remove_ManipulationInertiaStarting(EventRegistrationToken token);

        [VtblIndex(60)]
        HRESULT add_ManipulationCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CManipulationCompletedEventArgs_t *")] ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<IManipulationCompletedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(61)]
        HRESULT remove_ManipulationCompleted(EventRegistrationToken token);

        [VtblIndex(62)]
        HRESULT add_CrossSliding([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CCrossSlidingEventArgs_t *")] ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<ICrossSlidingEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(63)]
        HRESULT remove_CrossSliding(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::GestureSettings *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GestureSettings*, int> get_GestureSettings;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::GestureSettings) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GestureSettings, int> put_GestureSettings;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsInertial;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsActive;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ShowGestureFeedback;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_ShowGestureFeedback;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Point*, int> get_PivotCenter;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Point, int> put_PivotCenter;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_PivotRadius;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_PivotRadius;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_InertiaTranslationDeceleration;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_InertiaTranslationDeceleration;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_InertiaRotationDeceleration;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_InertiaRotationDeceleration;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_InertiaExpansionDeceleration;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_InertiaExpansionDeceleration;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_InertiaTranslationDisplacement;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_InertiaTranslationDisplacement;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_InertiaRotationAngle;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_InertiaRotationAngle;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_InertiaExpansion;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_InertiaExpansion;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ManipulationExact;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_ManipulationExact;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::CrossSlideThresholds *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CrossSlideThresholds*, int> get_CrossSlideThresholds;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::CrossSlideThresholds) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CrossSlideThresholds, int> put_CrossSlideThresholds;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CrossSlideHorizontally;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CrossSlideHorizontally;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CrossSlideExact;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CrossSlideExact;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AutoProcessInertia;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_AutoProcessInertia;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::IMouseWheelParameters **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMouseWheelParameters**, int> get_MouseWheelParameters;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::IPointerPoint *, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPointerPoint*, byte*, int> CanBeDoubleTap;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::IPointerPoint *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPointerPoint*, int> ProcessDownEvent;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CPointerPoint_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IPointerPoint>>*, int> ProcessMoveEvents;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::IPointerPoint *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPointerPoint*, int> ProcessUpEvent;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::IPointerPoint *, boolean, boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPointerPoint*, byte, byte, int> ProcessMouseWheelEvent;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ProcessInertia;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> CompleteGesture;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CTappedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<ITappedEventArgs>>*, EventRegistrationToken*, int> add_Tapped;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Tapped;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CRightTappedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<IRightTappedEventArgs>>*, EventRegistrationToken*, int> add_RightTapped;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_RightTapped;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CHoldingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<IHoldingEventArgs>>*, EventRegistrationToken*, int> add_Holding;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Holding;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CDraggingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<IDraggingEventArgs>>*, EventRegistrationToken*, int> add_Dragging;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Dragging;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CManipulationStartedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<IManipulationStartedEventArgs>>*, EventRegistrationToken*, int> add_ManipulationStarted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ManipulationStarted;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CManipulationUpdatedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<IManipulationUpdatedEventArgs>>*, EventRegistrationToken*, int> add_ManipulationUpdated;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ManipulationUpdated;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CManipulationInertiaStartingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<IManipulationInertiaStartingEventArgs>>*, EventRegistrationToken*, int> add_ManipulationInertiaStarting;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ManipulationInertiaStarting;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CManipulationCompletedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<IManipulationCompletedEventArgs>>*, EventRegistrationToken*, int> add_ManipulationCompleted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ManipulationCompleted;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CCrossSlidingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IGestureRecognizer>, Pointer<ICrossSlidingEventArgs>>*, EventRegistrationToken*, int> add_CrossSliding;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_CrossSliding;
    }
}
