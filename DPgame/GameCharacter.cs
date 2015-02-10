using System;

public abstract class GameCharacter
{
    protected string name;
    protected int healthPoints;
    protected int attackSpeed;
    protected int maxDamage;
    protected int minDamage;
    protected double hitChance;
    protected double defenseChance;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

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

    public double DefenseChance
    {
        get { return defenseChance; }
        set { defenseChance = value; }
    }

    public string attack(GameCharacter d)
    {
        if (hitChance >= new Random().NextDouble())
        {
            int hit = new Random().Next(maxDamage - minDamage + 1) + minDamage;
            int result = this.HealthPoints - hit;
            this.HealthPoints = result;
            return "Attack was successful.";
            
        }
        else
        {
            return "The attack was not successful.";
            
        }
    }

    public bool defense(GameCharacter d)
    {
        if (defenseChance >= new Random().NextDouble())
        {           
            Console.WriteLine("Defense was successful.");
            return true;
        }
        else
        {
            Console.WriteLine("The defense was not successful.");
            return false;
        }
    }
}
