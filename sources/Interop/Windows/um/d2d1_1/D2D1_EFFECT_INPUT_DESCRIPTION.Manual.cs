// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1helper.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows;

namespace TerraFX.Interop
{
    public unsafe partial struct D2D1_EFFECT_INPUT_DESCRIPTION
    {
        public D2D1_EFFECT_INPUT_DESCRIPTION([NativeTypeName("ID2D1Effect *")] ID2D1Effect* effect, [NativeTypeName("UINT32")] uint inputIndex, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F inputRectangle)
        {
            this = EffectInputDescription(effect, inputIndex, inputRectangle);
        }
    }
}
