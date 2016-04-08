using NSubstitute;
using NUnit.Framework;

public class KillEnemyCommandTest {

    [Test]
    public void KillEnemyCommandTest_Execute_Destroys_Enemy()
    {
        IDestroyable enemy = Substitute.For<IDestroyable>();
        Score score = new Score();

        KillEnemyCommand killEnemyCommand = new KillEnemyCommand();
        killEnemyCommand.Enemy = enemy;
        killEnemyCommand.Score = score;

        killEnemyCommand.Execute();

        enemy.Received().Destroy();
    }

    [Test]
    public void KillEnemyCommandTest_Execute_Increments_Score() {
        IDestroyable enemy = Substitute.For<IDestroyable>();
        Score score = new Score();

        KillEnemyCommand killEnemyCommand = new KillEnemyCommand();
        killEnemyCommand.Enemy = enemy;
        killEnemyCommand.Score = score;

        int initialScore = score.Amount;

        killEnemyCommand.Execute();

        Assert.Greater(score.Amount, initialScore);
    }
}
