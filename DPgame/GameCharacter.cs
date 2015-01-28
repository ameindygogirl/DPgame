using System;

public abstract class GameCharacter
{
    protected int healthPoints;
    protected int attackSpeed;
    protected int maxDamage;
    protected int minDamage;
    protected double hitChance;

    public int HealthPoints
    {
        get { return healthPoints; }
        set { healthPoints = value; }
    }

    public int AttackSpeed
    {
        get { return attackSpeed; }
        set { attackSpeed = value; }
    }

    public int MaxDamage
    {
        get { return maxDamage; }
        set { maxDamage = value; }
    }

    public int MinDamage
    {
        get { return minDamage; }
        set { minDamage = value; }
    }

    public double HitChance
    {
        get { return hitChance; }
        set { hitChance = value; }
    }

    public GameCharacter(int health, int speed, int max, int min, double hit)
    {
        //this.name = "";
        this.healthPoints = health;
        this.attackSpeed = speed;
        this.maxDamage = max;
        this.minDamage = min;
        this.hitChance = hit;
    }

    public bool attack(GameCharacter d)
    {
        if (hitChance >= new Random().nextDouble())
        {
            int hit = new Random().nextInt(maxDamage - minDamage + 1) + minDamage;
            int result = this.HealthPoints - hit;
            this.HealthPoints = result;
            Console.WriteLine("Attack was successful.");
            return true;
        }
        else
        {
            Console.WriteLine("The attack was not successful.");
            return false;
        }
    }
}
