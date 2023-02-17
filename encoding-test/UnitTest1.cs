using encoding_project.Service;

namespace encoding_test
{
    public class Tests
    {
        [Test]
        public void ShouldEncode()
        {
            var knownResult = "aG9sYQ==";
            var result = EncodingService.EncodeString("hola");

            Assert.AreEqual(knownResult, result);
        }
    }
}