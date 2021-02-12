// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SpCompressedLexicon" /> struct.</summary>
    public static unsafe class SpCompressedLexiconTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="SpCompressedLexicon" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(SpCompressedLexicon).GUID, Is.EqualTo(CLSID_SpCompressedLexicon));
        }

        /// <summary>Validates that the <see cref="SpCompressedLexicon" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SpCompressedLexicon>(), Is.EqualTo(sizeof(SpCompressedLexicon)));
        }

        /// <summary>Validates that the <see cref="SpCompressedLexicon" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SpCompressedLexicon).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SpCompressedLexicon" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(SpCompressedLexicon), Is.EqualTo(1));
        }
    }
}
