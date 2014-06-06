﻿using Cake.Core.IO;
using Xunit;

namespace Cake.MSBuild.Tests
{
    public sealed class MSBuildSettingsExtensionsTests
    {
        public sealed class TheWithTargetMethod
        {
            [Fact]
            public void Should_Add_Target_To_Configuration()
            {
                // Given
                var solution = new FilePath("/src/Solution.sln");
                var settings = new MSBuildSettings(solution);

                // When
                settings.WithTarget("Target");

                // Then
                Assert.True(settings.Targets.Contains("Target"));
            }

            [Fact]
            public void Should_Return_The_Same_Configuration()
            {
                // Given
                var solution = new FilePath("/src/Solution.sln");
                var settings = new MSBuildSettings(solution);

                // When
                var result = settings.WithTarget("Target");          

                // Then
                Assert.Equal(settings, result);
            }
        }

        public sealed class TheUseToolVersionMethod
        {
            [Fact]
            public void Should_Set_Tool_Version()
            {
                // Given
                var solution = new FilePath("/src/Solution.sln");
                var settings = new MSBuildSettings(solution);

                // When
                settings.UseToolVersion(MSBuildToolVersion.NET35);

                // Then
                Assert.Equal(MSBuildToolVersion.NET35, settings.ToolVersion);
            }

            [Fact]
            public void Should_Return_The_Same_Configuration()
            {
                // Given
                var solution = new FilePath("/src/Solution.sln");
                var settings = new MSBuildSettings(solution);

                // When
                var result = settings.UseToolVersion(MSBuildToolVersion.NET35);

                // Then
                Assert.Equal(settings, result);
            }
        }

        public sealed class TheSetPlatformTargetMethod
        {
            [Fact]
            public void Should_Set_Platform_Target()
            {
                // Given
                var solution = new FilePath("/src/Solution.sln");
                var settings = new MSBuildSettings(solution);

                // When
                settings.SetPlatformTarget(PlatformTarget.x64);

                // Then
                Assert.Equal(PlatformTarget.x64, settings.PlatformTarget);
            }

            [Fact]
            public void Should_Return_The_Same_Configuration()
            {
                // Given
                var solution = new FilePath("/src/Solution.sln");
                var settings = new MSBuildSettings(solution);

                // When
                var result = settings.SetPlatformTarget(PlatformTarget.x64);

                // Then
                Assert.Equal(settings, result);
            }
        }

        public sealed class TheWithPropertyMethod
        {
            [Fact]
            public void Should_Add_Property_To_Configuration()
            {
                // Given
                var solution = new FilePath("/src/Solution.sln");
                var settings = new MSBuildSettings(solution);

                // When
                settings.WithProperty("PropertyName", "Value");

                // Then
                Assert.True(settings.Properties.ContainsKey("PropertyName"));
            }

            [Fact]
            public void Should_Return_The_Same_Configuration()
            {
                // Given
                var solution = new FilePath("/src/Solution.sln");
                var settings = new MSBuildSettings(solution);

                // When
                var result = settings.WithProperty("PropertyName", "Value");

                // Then
                Assert.Equal(settings, result);
            }
        }

        public sealed class TheSetConfigurationMethod
        {
            [Fact]
            public void Should_Set_Configuration()
            {
                // Given
                var solution = new FilePath("/src/Solution.sln");
                var settings = new MSBuildSettings(solution);

                // When
                settings.SetConfiguration("TheConfiguration");

                // Then
                Assert.Equal("TheConfiguration", settings.Configuration);  
            }

            [Fact]
            public void Should_Return_The_Same_Configuration()
            {
                // Given
                var solution = new FilePath("/src/Solution.sln");
                var settings = new MSBuildSettings(solution);

                // When
                var result = settings.SetConfiguration("TheConfiguration");

                // Then
                Assert.Equal(settings, result);
            }
        }
    }
}
