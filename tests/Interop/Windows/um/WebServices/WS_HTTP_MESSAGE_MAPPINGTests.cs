// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="WS_HTTP_MESSAGE_MAPPING" /> struct.</summary>
    public static unsafe class WS_HTTP_MESSAGE_MAPPINGTests
    {
        /// <summary>Validates that the <see cref="WS_HTTP_MESSAGE_MAPPING" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<WS_HTTP_MESSAGE_MAPPING>(), Is.EqualTo(sizeof(WS_HTTP_MESSAGE_MAPPING)));
        }

        /// <summary>Validates that the <see cref="WS_HTTP_MESSAGE_MAPPING" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(WS_HTTP_MESSAGE_MAPPING).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="WS_HTTP_MESSAGE_MAPPING" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(WS_HTTP_MESSAGE_MAPPING), Is.EqualTo(40));
            }
            else
            {
                Assert.That(sizeof(WS_HTTP_MESSAGE_MAPPING), Is.EqualTo(24));
            }
        }
    }
}
