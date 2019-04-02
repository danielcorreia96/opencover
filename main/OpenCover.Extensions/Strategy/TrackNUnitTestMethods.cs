using System.Collections.Generic;

namespace OpenCover.Extensions.Strategy
{
    /// <summary>
    /// Track NUnit test methods
    /// </summary>
    public class TrackNUnitTestMethods : TrackedMethodStrategyBase
    {
        private const string NUnitStrategyName = "NUnitTest";

        private static readonly IList<string> TrackedAttributeTypeNames = new List<string>
        {
            "NUnit.Framework.TestAttribute",
            "NUnit.Framework.TestCaseAttribute",
            "NUnit.Framework.TheoryAttribute",
            "NUnitExtension.OutSystems.Framework.IterativeTestCaseAttribute",
            "NUnitExtension.OutSystems.Framework.DashboardTestFixtureAttribute",
            "NUnitExtension.OutSystems.Framework.IDashboardTestFixture",
            "OutSystems.PackageManager.UnitTests.TestBase",
            "OutSystems.PackageManager.UnitTests.EnzymeTestBase",
        };

        public TrackNUnitTestMethods() : base(NUnitStrategyName, TrackedAttributeTypeNames)
        {            
        }
    }
}
