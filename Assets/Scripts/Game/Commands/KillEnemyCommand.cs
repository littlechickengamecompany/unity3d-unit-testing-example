using strange.extensions.command.impl;

public class KillEnemyCommand : Command {

	[Inject]
    public IDestroyable Enemy { get; set; }

    [Inject]
    public Score Score { get; set; }

    public override void Execute() {
        Enemy.Destroy();
        Score.AddScore(10);
    }

}
