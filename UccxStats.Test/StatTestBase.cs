using System.IO;

namespace UccxStats.Test
{
    public class StatTestBase
    {
        protected UccxStats Stats { get; set; }
        protected MockStats MockStatRetriever { get; set; }
        protected string Json { get; set; }

        protected StatTestBase(string fileName)
        {
            using (var reader = new StreamReader("TestArtifacts/" + fileName))
            {
                Json = reader.ReadToEnd();
            }
            MockStatRetriever = new MockStats(Json);

            Stats = new UccxStats(MockStatRetriever);
        }
    }
}