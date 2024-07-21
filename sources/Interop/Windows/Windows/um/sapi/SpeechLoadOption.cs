// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows.SPLOADOPTIONS;

namespace TerraFX.Interop.Windows;

/// <include file='SpeechLoadOption.xml' path='doc/member[@name="SpeechLoadOption"]/*' />
public enum SpeechLoadOption
{
    /// <include file='SpeechLoadOption.xml' path='doc/member[@name="SpeechLoadOption.SLOStatic"]/*' />
    SLOStatic = SPLO_STATIC,

    /// <include file='SpeechLoadOption.xml' path='doc/member[@name="SpeechLoadOption.SLODynamic"]/*' />
    SLODynamic = SPLO_DYNAMIC,
}
