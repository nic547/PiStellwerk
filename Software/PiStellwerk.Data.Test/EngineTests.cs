﻿// <copyright file="EngineTests.cs" company="Dominic Ritz">
// Copyright (c) Dominic Ritz. All rights reserved.
// Licensed under the GNU GPL license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Linq;
using System.Text.Json;
using NUnit.Framework;

namespace PiStellwerk.Data.Test
{
    /// <summary>
    /// Contains tests related to <see cref="Engine"/>.
    /// </summary>
    public class EngineTests
    {
        /// <summary>
        /// Test that after serializing and deserializing via json the "new" engine object has the same values as the "old" one.
        /// </summary>
        [Test]
        public void EnginesMatchAfterJson()
        {
            var expectedEngine = CreateTestEngine();
            var json = JsonSerializer.Serialize(expectedEngine);
            var resultEngine = JsonSerializer.Deserialize<Engine>(json);

            Assert.That(resultEngine.Equals(expectedEngine));
        }

        /// <summary>
        /// Test that tags of a cloned engine do not have reference equality.
        /// </summary>
        [Test]
        public void ClonedTagsAreNotReferenceEqual()
        {
            var e1 = new Engine();
            var testTag = "testTag";
            e1.Tags.Add(testTag);

            Assert.True(ReferenceEquals(e1.Tags.First(), testTag));

            var e2 = e1.DeepClone();

            Assert.False(ReferenceEquals(e1.Tags.Single(), e2.Tags.Single()));
        }

        private static Engine CreateTestEngine()
        {
            return new Engine()
            {
                Name = "RE 777",
                TopSpeed = 356,
                Id = 7777,
                Address = 77,
                SpeedSteps = 128,
                SpeedDisplayType = SpeedDisplayType.TopSpeed,
            };
        }
    }
}
