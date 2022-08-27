// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='MF_MEDIA_ENGINE_SEEK_MODE.xml' path='doc/member[@name="MF_MEDIA_ENGINE_SEEK_MODE"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum MF_MEDIA_ENGINE_SEEK_MODE
{
    /// <include file='MF_MEDIA_ENGINE_SEEK_MODE.xml' path='doc/member[@name="MF_MEDIA_ENGINE_SEEK_MODE.MF_MEDIA_ENGINE_SEEK_MODE_NORMAL"]/*' />
    MF_MEDIA_ENGINE_SEEK_MODE_NORMAL = 0,

    /// <include file='MF_MEDIA_ENGINE_SEEK_MODE.xml' path='doc/member[@name="MF_MEDIA_ENGINE_SEEK_MODE.MF_MEDIA_ENGINE_SEEK_MODE_APPROXIMATE"]/*' />
    MF_MEDIA_ENGINE_SEEK_MODE_APPROXIMATE = 1,
}
