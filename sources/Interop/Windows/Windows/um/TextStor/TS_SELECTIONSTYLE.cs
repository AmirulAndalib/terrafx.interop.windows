// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/TextStor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='TS_SELECTIONSTYLE.xml' path='doc/member[@name="TS_SELECTIONSTYLE"]/*' />
public partial struct TS_SELECTIONSTYLE
{
    /// <include file='TS_SELECTIONSTYLE.xml' path='doc/member[@name="TS_SELECTIONSTYLE.ase"]/*' />
    public TsActiveSelEnd ase;

    /// <include file='TS_SELECTIONSTYLE.xml' path='doc/member[@name="TS_SELECTIONSTYLE.fInterimChar"]/*' />
    public BOOL fInterimChar;
}
