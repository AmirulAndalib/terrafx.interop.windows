// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='eAVEncH264PictureType.xml' path='doc/member[@name="eAVEncH264PictureType"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum eAVEncH264PictureType
{
    /// <include file='eAVEncH264PictureType.xml' path='doc/member[@name="eAVEncH264PictureType.eAVEncH264PictureType_IDR"]/*' />
    eAVEncH264PictureType_IDR = 0,

    /// <include file='eAVEncH264PictureType.xml' path='doc/member[@name="eAVEncH264PictureType.eAVEncH264PictureType_P"]/*' />
    eAVEncH264PictureType_P,

    /// <include file='eAVEncH264PictureType.xml' path='doc/member[@name="eAVEncH264PictureType.eAVEncH264PictureType_B"]/*' />
    eAVEncH264PictureType_B,
}
