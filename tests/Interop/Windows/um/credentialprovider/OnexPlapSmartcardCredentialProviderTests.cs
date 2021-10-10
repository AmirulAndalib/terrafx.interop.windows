// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="OnexPlapSmartcardCredentialProvider" /> struct.</summary>
    public static unsafe class OnexPlapSmartcardCredentialProviderTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="OnexPlapSmartcardCredentialProvider" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(OnexPlapSmartcardCredentialProvider).GUID, Is.EqualTo(IID_OnexPlapSmartcardCredentialProvider));
        }

        /// <summary>Validates that the <see cref="OnexPlapSmartcardCredentialProvider" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<OnexPlapSmartcardCredentialProvider>(), Is.EqualTo(sizeof(OnexPlapSmartcardCredentialProvider)));
        }

        /// <summary>Validates that the <see cref="OnexPlapSmartcardCredentialProvider" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(OnexPlapSmartcardCredentialProvider).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="OnexPlapSmartcardCredentialProvider" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(OnexPlapSmartcardCredentialProvider), Is.EqualTo(1));
        }
    }
}
