// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2"]/*' />
[Guid("FDC8248B-9F1A-44DB-BD3C-65C384770F86")]
[NativeTypeName("struct IEmailMessage2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailMessage2 : IEmailMessage2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEmailMessage2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, Guid*, void**, int>)(lpVtbl[0]))((IEmailMessage2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, uint>)(lpVtbl[1]))((IEmailMessage2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, uint>)(lpVtbl[2]))((IEmailMessage2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, uint*, Guid**, int>)(lpVtbl[3]))((IEmailMessage2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, HSTRING*, int>)(lpVtbl[4]))((IEmailMessage2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, TrustLevel*, int>)(lpVtbl[5]))((IEmailMessage2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, HSTRING*, int>)(lpVtbl[6]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.get_RemoteId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RemoteId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, HSTRING*, int>)(lpVtbl[7]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.put_RemoteId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_RemoteId(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, HSTRING, int>)(lpVtbl[8]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.get_MailboxId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MailboxId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, HSTRING*, int>)(lpVtbl[9]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.get_ConversationId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ConversationId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, HSTRING*, int>)(lpVtbl[10]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.get_FolderId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_FolderId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, HSTRING*, int>)(lpVtbl[11]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.get_AllowInternetImages"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_AllowInternetImages([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, byte*, int>)(lpVtbl[12]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.put_AllowInternetImages"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_AllowInternetImages([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, byte, int>)(lpVtbl[13]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.get_ChangeNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_ChangeNumber([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, ulong*, int>)(lpVtbl[14]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.get_DownloadState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_DownloadState([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMessageDownloadState *")] EmailMessageDownloadState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, EmailMessageDownloadState*, int>)(lpVtbl[15]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.put_DownloadState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_DownloadState([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMessageDownloadState")] EmailMessageDownloadState value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, EmailMessageDownloadState, int>)(lpVtbl[16]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.get_EstimatedDownloadSizeInBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_EstimatedDownloadSizeInBytes([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, uint*, int>)(lpVtbl[17]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.put_EstimatedDownloadSizeInBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_EstimatedDownloadSizeInBytes([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, uint, int>)(lpVtbl[18]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.get_FlagState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_FlagState([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailFlagState *")] EmailFlagState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, EmailFlagState*, int>)(lpVtbl[19]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.put_FlagState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_FlagState([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailFlagState")] EmailFlagState value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, EmailFlagState, int>)(lpVtbl[20]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.get_HasPartialBodies"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_HasPartialBodies([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, byte*, int>)(lpVtbl[21]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.get_Importance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_Importance([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailImportance *")] EmailImportance* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, EmailImportance*, int>)(lpVtbl[22]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.put_Importance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_Importance([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailImportance")] EmailImportance value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, EmailImportance, int>)(lpVtbl[23]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.get_InResponseToMessageId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_InResponseToMessageId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, HSTRING*, int>)(lpVtbl[24]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.get_IrmInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_IrmInfo([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailIrmInfo **")] IEmailIrmInfo** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, IEmailIrmInfo**, int>)(lpVtbl[25]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.put_IrmInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_IrmInfo([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailIrmInfo *")] IEmailIrmInfo* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, IEmailIrmInfo*, int>)(lpVtbl[26]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.get_IsDraftMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_IsDraftMessage([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, byte*, int>)(lpVtbl[27]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.get_IsRead"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_IsRead([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, byte*, int>)(lpVtbl[28]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.put_IsRead"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_IsRead([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, byte, int>)(lpVtbl[29]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.get_IsSeen"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_IsSeen([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, byte*, int>)(lpVtbl[30]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.put_IsSeen"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_IsSeen([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, byte, int>)(lpVtbl[31]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.get_IsServerSearchMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_IsServerSearchMessage([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, byte*, int>)(lpVtbl[32]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.get_IsSmartSendable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_IsSmartSendable([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, byte*, int>)(lpVtbl[33]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.get_MessageClass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_MessageClass(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, HSTRING*, int>)(lpVtbl[34]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.put_MessageClass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT put_MessageClass(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, HSTRING, int>)(lpVtbl[35]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.get_NormalizedSubject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_NormalizedSubject(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, HSTRING*, int>)(lpVtbl[36]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.get_OriginalCodePage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_OriginalCodePage([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, int*, int>)(lpVtbl[37]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.put_OriginalCodePage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT put_OriginalCodePage([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, int, int>)(lpVtbl[38]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.get_Preview"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_Preview(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, HSTRING*, int>)(lpVtbl[39]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.put_Preview"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT put_Preview(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, HSTRING, int>)(lpVtbl[40]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.get_LastResponseKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_LastResponseKind([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMessageResponseKind *")] EmailMessageResponseKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, EmailMessageResponseKind*, int>)(lpVtbl[41]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.put_LastResponseKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT put_LastResponseKind([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMessageResponseKind")] EmailMessageResponseKind value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, EmailMessageResponseKind, int>)(lpVtbl[42]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.get_Sender"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_Sender([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailRecipient **")] IEmailRecipient** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, IEmailRecipient**, int>)(lpVtbl[43]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.put_Sender"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT put_Sender([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailRecipient *")] IEmailRecipient* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, IEmailRecipient*, int>)(lpVtbl[44]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.get_SentTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT get_SentTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, IReference<DateTime>**, int>)(lpVtbl[45]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.put_SentTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT put_SentTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, IReference<DateTime>*, int>)(lpVtbl[46]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.get_MeetingInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT get_MeetingInfo([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMeetingInfo **")] IEmailMeetingInfo** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, IEmailMeetingInfo**, int>)(lpVtbl[47]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.put_MeetingInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT put_MeetingInfo([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMeetingInfo *")] IEmailMeetingInfo* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, IEmailMeetingInfo*, int>)(lpVtbl[48]))((IEmailMessage2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.GetBodyStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT GetBodyStream([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMessageBodyKind")] EmailMessageBodyKind type, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, EmailMessageBodyKind, IRandomAccessStreamReference**, int>)(lpVtbl[49]))((IEmailMessage2*)Unsafe.AsPointer(ref this), type, result);
    }

    /// <include file='IEmailMessage2.xml' path='doc/member[@name="IEmailMessage2.SetBodyStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT SetBodyStream([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMessageBodyKind")] EmailMessageBodyKind type, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* stream)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage2*, EmailMessageBodyKind, IRandomAccessStreamReference*, int>)(lpVtbl[50]))((IEmailMessage2*)Unsafe.AsPointer(ref this), type, stream);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_RemoteId(HSTRING* value);

        [VtblIndex(8)]
        HRESULT put_RemoteId(HSTRING value);

        [VtblIndex(9)]
        HRESULT get_MailboxId(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_ConversationId(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_FolderId(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_AllowInternetImages([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT put_AllowInternetImages([NativeTypeName("boolean")] byte value);

        [VtblIndex(14)]
        HRESULT get_ChangeNumber([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(15)]
        HRESULT get_DownloadState([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMessageDownloadState *")] EmailMessageDownloadState* value);

        [VtblIndex(16)]
        HRESULT put_DownloadState([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMessageDownloadState")] EmailMessageDownloadState value);

        [VtblIndex(17)]
        HRESULT get_EstimatedDownloadSizeInBytes([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(18)]
        HRESULT put_EstimatedDownloadSizeInBytes([NativeTypeName("UINT32")] uint value);

        [VtblIndex(19)]
        HRESULT get_FlagState([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailFlagState *")] EmailFlagState* value);

        [VtblIndex(20)]
        HRESULT put_FlagState([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailFlagState")] EmailFlagState value);

        [VtblIndex(21)]
        HRESULT get_HasPartialBodies([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(22)]
        HRESULT get_Importance([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailImportance *")] EmailImportance* value);

        [VtblIndex(23)]
        HRESULT put_Importance([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailImportance")] EmailImportance value);

        [VtblIndex(24)]
        HRESULT get_InResponseToMessageId(HSTRING* value);

        [VtblIndex(25)]
        HRESULT get_IrmInfo([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailIrmInfo **")] IEmailIrmInfo** value);

        [VtblIndex(26)]
        HRESULT put_IrmInfo([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailIrmInfo *")] IEmailIrmInfo* value);

        [VtblIndex(27)]
        HRESULT get_IsDraftMessage([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(28)]
        HRESULT get_IsRead([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(29)]
        HRESULT put_IsRead([NativeTypeName("boolean")] byte value);

        [VtblIndex(30)]
        HRESULT get_IsSeen([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(31)]
        HRESULT put_IsSeen([NativeTypeName("boolean")] byte value);

        [VtblIndex(32)]
        HRESULT get_IsServerSearchMessage([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(33)]
        HRESULT get_IsSmartSendable([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(34)]
        HRESULT get_MessageClass(HSTRING* value);

        [VtblIndex(35)]
        HRESULT put_MessageClass(HSTRING value);

        [VtblIndex(36)]
        HRESULT get_NormalizedSubject(HSTRING* value);

        [VtblIndex(37)]
        HRESULT get_OriginalCodePage([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(38)]
        HRESULT put_OriginalCodePage([NativeTypeName("INT32")] int value);

        [VtblIndex(39)]
        HRESULT get_Preview(HSTRING* value);

        [VtblIndex(40)]
        HRESULT put_Preview(HSTRING value);

        [VtblIndex(41)]
        HRESULT get_LastResponseKind([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMessageResponseKind *")] EmailMessageResponseKind* value);

        [VtblIndex(42)]
        HRESULT put_LastResponseKind([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMessageResponseKind")] EmailMessageResponseKind value);

        [VtblIndex(43)]
        HRESULT get_Sender([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailRecipient **")] IEmailRecipient** value);

        [VtblIndex(44)]
        HRESULT put_Sender([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailRecipient *")] IEmailRecipient* value);

        [VtblIndex(45)]
        HRESULT get_SentTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value);

        [VtblIndex(46)]
        HRESULT put_SentTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value);

        [VtblIndex(47)]
        HRESULT get_MeetingInfo([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMeetingInfo **")] IEmailMeetingInfo** value);

        [VtblIndex(48)]
        HRESULT put_MeetingInfo([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMeetingInfo *")] IEmailMeetingInfo* value);

        [VtblIndex(49)]
        HRESULT GetBodyStream([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMessageBodyKind")] EmailMessageBodyKind type, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** result);

        [VtblIndex(50)]
        HRESULT SetBodyStream([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMessageBodyKind")] EmailMessageBodyKind type, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* stream);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RemoteId;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_RemoteId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MailboxId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ConversationId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_FolderId;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AllowInternetImages;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_AllowInternetImages;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_ChangeNumber;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailMessageDownloadState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailMessageDownloadState*, int> get_DownloadState;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailMessageDownloadState) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailMessageDownloadState, int> put_DownloadState;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_EstimatedDownloadSizeInBytes;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_EstimatedDownloadSizeInBytes;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailFlagState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailFlagState*, int> get_FlagState;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailFlagState) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailFlagState, int> put_FlagState;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_HasPartialBodies;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailImportance *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailImportance*, int> get_Importance;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailImportance) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailImportance, int> put_Importance;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_InResponseToMessageId;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailIrmInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailIrmInfo**, int> get_IrmInfo;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailIrmInfo *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailIrmInfo*, int> put_IrmInfo;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsDraftMessage;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsRead;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsRead;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsSeen;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsSeen;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsServerSearchMessage;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsSmartSendable;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MessageClass;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_MessageClass;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_NormalizedSubject;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_OriginalCodePage;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_OriginalCodePage;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Preview;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Preview;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailMessageResponseKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailMessageResponseKind*, int> get_LastResponseKind;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailMessageResponseKind) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailMessageResponseKind, int> put_LastResponseKind;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailRecipient **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailRecipient**, int> get_Sender;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailRecipient *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailRecipient*, int> put_Sender;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>**, int> get_SentTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>*, int> put_SentTime;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMeetingInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailMeetingInfo**, int> get_MeetingInfo;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMeetingInfo *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailMeetingInfo*, int> put_MeetingInfo;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailMessageBodyKind, ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailMessageBodyKind, IRandomAccessStreamReference**, int> GetBodyStream;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailMessageBodyKind, ABI::Windows::Storage::Streams::IRandomAccessStreamReference *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailMessageBodyKind, IRandomAccessStreamReference*, int> SetBodyStream;
    }
}
