using NSubstitute;
using NUnit.Framework;

public class FireTurretCommandTest {

    [Test]
    public void FireTurretCommandTest_Execute()
    {
        ITurret turret = Substitute.For<ITurret>();
        FireTurretCommand fireTurretCommand = new FireTurretCommand();
        fireTurretCommand.Turret = turret;

        fireTurretCommand.Execute();

        turret.Received().Fire();
    }
}
