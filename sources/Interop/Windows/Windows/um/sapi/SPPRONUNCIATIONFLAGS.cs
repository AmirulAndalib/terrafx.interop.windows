// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SPPRONUNCIATIONFLAGS.xml' path='doc/member[@name="SPPRONUNCIATIONFLAGS"]/*' />
public enum SPPRONUNCIATIONFLAGS
{
    /// <include file='SPPRONUNCIATIONFLAGS.xml' path='doc/member[@name="SPPRONUNCIATIONFLAGS.ePRONFLAG_USED"]/*' />
    ePRONFLAG_USED = (1 << 0),
}
