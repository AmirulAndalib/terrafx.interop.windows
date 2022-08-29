// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='VIEW_OBJECT_ALPHA_MODE.xml' path='doc/member[@name="VIEW_OBJECT_ALPHA_MODE"]/*' />
public enum VIEW_OBJECT_ALPHA_MODE
{
    /// <include file='VIEW_OBJECT_ALPHA_MODE.xml' path='doc/member[@name="VIEW_OBJECT_ALPHA_MODE.VIEW_OBJECT_ALPHA_MODE_IGNORE"]/*' />
    VIEW_OBJECT_ALPHA_MODE_IGNORE = 0,

    /// <include file='VIEW_OBJECT_ALPHA_MODE.xml' path='doc/member[@name="VIEW_OBJECT_ALPHA_MODE.VIEW_OBJECT_ALPHA_MODE_PREMULTIPLIED"]/*' />
    VIEW_OBJECT_ALPHA_MODE_PREMULTIPLIED = 1,

    /// <include file='VIEW_OBJECT_ALPHA_MODE.xml' path='doc/member[@name="VIEW_OBJECT_ALPHA_MODE.VIEW_OBJECT_ALPHA_MODE_Max"]/*' />
    VIEW_OBJECT_ALPHA_MODE_Max = 2147483647,
}
