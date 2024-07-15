// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='NATIVE_DISPLAY_ORIENTATION.xml' path='doc/member[@name="NATIVE_DISPLAY_ORIENTATION"]/*' />
public enum NATIVE_DISPLAY_ORIENTATION
{
    /// <include file='NATIVE_DISPLAY_ORIENTATION.xml' path='doc/member[@name="NATIVE_DISPLAY_ORIENTATION.NDO_LANDSCAPE"]/*' />
    NDO_LANDSCAPE = 0,

    /// <include file='NATIVE_DISPLAY_ORIENTATION.xml' path='doc/member[@name="NATIVE_DISPLAY_ORIENTATION.NDO_PORTRAIT"]/*' />
    NDO_PORTRAIT = (NDO_LANDSCAPE + 1),
}
