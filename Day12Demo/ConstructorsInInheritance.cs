namespace Day12Demo;

public class ConstructorsInInheritance
{
    public static void Test()
    {
        //Weapon weapon = new(50, 40);
        //weapon.Show();

        RocketLauncher rocketLauncher = new (50, 40, 1000, 200);
        rocketLauncher.Show();
    }
}

public class Weapon
{
    int _bulletCount, _damageIntensity;

    public Weapon(int bulletCount, int damageIntensity)
    {
        _bulletCount = bulletCount;
        _damageIntensity = damageIntensity;
    }

    virtual public void Show()
    {
        Console.WriteLine($"Weapon: BulletCount={_bulletCount}, DamageIntensity={_damageIntensity}");
    }
}

public class RocketLauncher : Weapon
{
    int _rocketRange, _blastRadius;

    public RocketLauncher(int bulletCount, int damageIntensity, int rocketRange, int blastRadius) : base(bulletCount, damageIntensity)
    {
        _rocketRange = rocketRange;
        _blastRadius = blastRadius;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"RocketLauncher: RocketRange={_rocketRange}, BlastRadius={_blastRadius}");
    }
}
