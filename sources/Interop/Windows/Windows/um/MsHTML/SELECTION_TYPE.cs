// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SELECTION_TYPE.xml' path='doc/member[@name="SELECTION_TYPE"]/*' />
public enum SELECTION_TYPE
{
    /// <include file='SELECTION_TYPE.xml' path='doc/member[@name="SELECTION_TYPE.SELECTION_TYPE_None"]/*' />
    SELECTION_TYPE_None = 0,

    /// <include file='SELECTION_TYPE.xml' path='doc/member[@name="SELECTION_TYPE.SELECTION_TYPE_Caret"]/*' />
    SELECTION_TYPE_Caret = 1,

    /// <include file='SELECTION_TYPE.xml' path='doc/member[@name="SELECTION_TYPE.SELECTION_TYPE_Text"]/*' />
    SELECTION_TYPE_Text = 2,

    /// <include file='SELECTION_TYPE.xml' path='doc/member[@name="SELECTION_TYPE.SELECTION_TYPE_Control"]/*' />
    SELECTION_TYPE_Control = 3,

    /// <include file='SELECTION_TYPE.xml' path='doc/member[@name="SELECTION_TYPE.SELECTION_TYPE_Max"]/*' />
    SELECTION_TYPE_Max = 2147483647,
}
