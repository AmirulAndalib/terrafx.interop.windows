// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MF_CAPTURE_ENGINE_SINK_TYPE
    {
        MF_CAPTURE_ENGINE_SINK_TYPE_RECORD = 0,
        MF_CAPTURE_ENGINE_SINK_TYPE_PREVIEW = 0x1,
        MF_CAPTURE_ENGINE_SINK_TYPE_PHOTO = 0x2,
    }
}
