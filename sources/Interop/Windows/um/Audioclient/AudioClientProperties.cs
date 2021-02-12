// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct AudioClientProperties
    {
        [NativeTypeName("UINT32")]
        public uint cbSize;

        [NativeTypeName("BOOL")]
        public int bIsOffload;

        public AUDIO_STREAM_CATEGORY eCategory;

        public AUDCLNT_STREAMOPTIONS Options;
    }
}
