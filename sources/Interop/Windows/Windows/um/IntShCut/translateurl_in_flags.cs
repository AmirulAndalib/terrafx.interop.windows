// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IntShCut.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='TRANSLATEURL_IN_FLAGS.xml' path='doc/member[@name="TRANSLATEURL_IN_FLAGS"]/*' />
public enum TRANSLATEURL_IN_FLAGS
{
    /// <include file='TRANSLATEURL_IN_FLAGS.xml' path='doc/member[@name="TRANSLATEURL_IN_FLAGS.TRANSLATEURL_FL_GUESS_PROTOCOL"]/*' />
    TRANSLATEURL_FL_GUESS_PROTOCOL = 0x0001,

    /// <include file='TRANSLATEURL_IN_FLAGS.xml' path='doc/member[@name="TRANSLATEURL_IN_FLAGS.TRANSLATEURL_FL_USE_DEFAULT_PROTOCOL"]/*' />
    TRANSLATEURL_FL_USE_DEFAULT_PROTOCOL = 0x0002,
}
