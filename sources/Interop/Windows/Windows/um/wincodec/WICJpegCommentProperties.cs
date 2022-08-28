// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WICJpegCommentProperties.xml' path='doc/member[@name="WICJpegCommentProperties"]/*' />
public enum WICJpegCommentProperties : uint
{
    /// <include file='WICJpegCommentProperties.xml' path='doc/member[@name="WICJpegCommentProperties.WICJpegCommentText"]/*' />
    WICJpegCommentText = 0x1,

    /// <include file='WICJpegCommentProperties.xml' path='doc/member[@name="WICJpegCommentProperties.WICJpegCommentProperties_FORCE_DWORD"]/*' />
    WICJpegCommentProperties_FORCE_DWORD = 0x7fffffff,
}
