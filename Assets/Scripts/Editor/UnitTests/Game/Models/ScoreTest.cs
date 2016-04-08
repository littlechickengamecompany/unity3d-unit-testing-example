using NSubstitute;
using NUnit.Framework;

public class ScoreTest {

    [Test]
    public void ScoreTest_AddScore_IncrementsScore()
    {
        Score score = new Score();
        score.AddScore(10);
        Assert.AreEqual(10, score.Amount);
    }

    [Test]
    public void ScoreTest_AddScore_DispatchesScoreChangedSignal() {
        Score score = new Score();
        bool hasSignalFired = false;
        score.ScoreChanged.AddOnce(delegate () {
            hasSignalFired = true;
        });

        score.AddScore(10);

        Assert.IsTrue(hasSignalFired);
    }

}
