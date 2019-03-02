using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UrlLegalSlug;

namespace UrlLegalSlugTest
{
    [TestClass]
    public class SlugProducerTests
    {
        [TestMethod]
        [TestCategory("ClassTest")]
        public void SlugProducer_GetUrlSlug_WhenUrlContainsNoIllegalCharacters_ReturnsAsIs()
        {
            // Arrange
            var expectedSlug = "abcdegfhijklmnopqrstuvwxyz0123456789";

            // Act
            var actualSlug = SlugProducer.GetUrlSlug(expectedSlug);

            // Assert
            Assert.AreEqual(expectedSlug, actualSlug, $"We were expecting the Url slug to be: {expectedSlug}, but found the actual Url slug to be {actualSlug}");
        }
    }
}
