// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.SPVFEATURE;

namespace TerraFX.Interop
{
    public enum SpeechVisemeFeature
    {
        SVF_None = 0,
        SVF_Stressed = SPVFEATURE_STRESSED,
        SVF_Emphasis = SPVFEATURE_EMPHASIS,
    }
}
