using NSubstitute;
using NUnit.Framework;

public class SpawnEnemyCommandTest {

    [Test]
    public void SpawnEnemyCommandTest_Execute()
    {
        IEnemySpawner enemySpawner = Substitute.For<IEnemySpawner>();
        SpawnEnemyCommand spawnEnemyCommand = new SpawnEnemyCommand();

        spawnEnemyCommand.EnemySpawner = enemySpawner;

        spawnEnemyCommand.Execute();

        enemySpawner.Received().Spawn();
    }

}
