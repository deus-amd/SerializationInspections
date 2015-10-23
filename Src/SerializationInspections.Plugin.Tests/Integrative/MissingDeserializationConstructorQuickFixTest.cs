﻿using JetBrains.ReSharper.FeaturesTestFramework.Intentions;
using NUnit.Framework;
using SerializationInspections.Plugin.Quickfixes;

namespace SerializationInspections.Plugin.Tests.Integrative
{
    [TestFixture]
    public class MissingDeserializationConstructorQuickFixTest : CSharpQuickFixTestBase<MissingDeserializationConstructorQuickFix>
    {
        protected override string RelativeTestDataPath => @"QuickFixes\MissingDeserializationConstructorQuickFix";

        [Test]
        public void TestExceptionClass()
        {
            DoNamedTest2();
        }

        [Test]
        public void TestExceptionWithExistingMembers()
        {
            DoNamedTest2();
        }

        [Test]
        public void TestCustomSerializable()
        {
            DoNamedTest2();
        }

        [Test]
        public void TestCustomSerializableStruct()
        {
            DoNamedTest2();
        }

        [Test]
        public void TestCustomSerializableWithPrivateDeserializationConstructorInBase()
        {
            DoNamedTest2();
        }
    }
}