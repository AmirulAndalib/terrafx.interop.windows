// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='DELETE_USN_JOURNAL_DATA.xml' path='doc/member[@name="DELETE_USN_JOURNAL_DATA"]/*' />
public partial struct DELETE_USN_JOURNAL_DATA
{
    /// <include file='DELETE_USN_JOURNAL_DATA.xml' path='doc/member[@name="DELETE_USN_JOURNAL_DATA.UsnJournalID"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong UsnJournalID;

    /// <include file='DELETE_USN_JOURNAL_DATA.xml' path='doc/member[@name="DELETE_USN_JOURNAL_DATA.DeleteFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint DeleteFlags;
}
