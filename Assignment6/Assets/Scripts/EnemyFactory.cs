/*
 * Gerard Lamoureux
 * EnemyFactory
 * Assignment 6
 * Handles all of the Enemy Factories
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyFactory
{
    public string factoryType = "none";
    public abstract GameObject CreateEnemyPrefab(string enemyType);
    public abstract GameObject AddEnemyScript(GameObject prefab, string enemyType);
    public abstract GameObject CreateEnemy(string enemyType);
}

public class NormalEnemyFactory : EnemyFactory
{
    public NormalEnemyFactory()
    {
        factoryType = "NormalEnemyFactory";
    }

    public override GameObject CreateEnemy(string enemyType)
    {
        GameObject prefab = CreateEnemyPrefab(enemyType);
        prefab = AddEnemyScript(prefab, enemyType);
        return prefab;
    }

    public override GameObject CreateEnemyPrefab(string enemyType)
    {
        if (enemyType.Equals("Zombie"))
        {
            return Resources.Load<GameObject>("Zombie");
        }
        if (enemyType.Equals("ZombieDog"))
        {
            return Resources.Load<GameObject>("ZombieDog");
        }
        if (enemyType.Equals("BossZombie"))
        {
            return Resources.Load<GameObject>("BossZombie");
        }
        throw new MissingComponentException();
    }

    public override GameObject AddEnemyScript(GameObject prefab, string enemyType)
    {
        if (enemyType.Equals("Zombie"))
        {
            prefab.AddComponent<NormalZombie>();
        }
        if (enemyType.Equals("ZombieDog"))
        {
            prefab.AddComponent<NormalZombieDog>();
        }
        if (enemyType.Equals("BossZombie"))
        {
            prefab.AddComponent<NormalBossZombie>();
        }
        return prefab;
    }
}

public class EliteEnemyFactory : EnemyFactory
{
    public EliteEnemyFactory()
    {
        factoryType = "EliteEnemyFactory";
    }

    public override GameObject CreateEnemy(string enemyType)
    {
        GameObject prefab = CreateEnemyPrefab(enemyType);
        prefab = AddEnemyScript(prefab, enemyType);
        return prefab;
    }

    public override GameObject CreateEnemyPrefab(string enemyType)
    {
        if (enemyType.Equals("Zombie"))
        {
            return Resources.Load<GameObject>("Zombie");
        }
        if (enemyType.Equals("ZombieDog"))
        {
            return Resources.Load<GameObject>("ZombieDog");
        }
        if (enemyType.Equals("BossZombie"))
        {
            return Resources.Load<GameObject>("BossZombie");
        }
        throw new MissingComponentException();
    }

    public override GameObject AddEnemyScript(GameObject prefab, string enemyType)
    {
        if (enemyType.Equals("Zombie"))
        {
            prefab.AddComponent<EliteZombie>();
        }
        if (enemyType.Equals("ZombieDog"))
        {
            prefab.AddComponent<EliteZombieDog>();
        }
        if (enemyType.Equals("BossZombie"))
        {
            prefab.AddComponent<EliteBossZombie>();
        }
        return prefab;
    }
}

public class SuperEnemyFactory : EnemyFactory
{
    public SuperEnemyFactory()
    {
        factoryType = "SuperEnemyFactory";
    }

    public override GameObject CreateEnemy(string enemyType)
    {
        GameObject prefab = CreateEnemyPrefab(enemyType);
        prefab = AddEnemyScript(prefab, enemyType);
        return prefab;
    }

    public override GameObject CreateEnemyPrefab(string enemyType)
    {
        if (enemyType.Equals("Zombie"))
        {
            return Resources.Load<GameObject>("Zombie");
        }
        if (enemyType.Equals("ZombieDog"))
        {
            return Resources.Load<GameObject>("ZombieDog");
        }
        if (enemyType.Equals("BossZombie"))
        {
            return Resources.Load<GameObject>("BossZombie");
        }
        throw new MissingComponentException();
    }

    public override GameObject AddEnemyScript(GameObject prefab, string enemyType)
    {
        if (enemyType.Equals("Zombie"))
        {
            prefab.AddComponent<SuperZombie>();
        }
        if (enemyType.Equals("ZombieDog"))
        {
            prefab.AddComponent<SuperZombieDog>();
        }
        if (enemyType.Equals("BossZombie"))
        {
            prefab.AddComponent<SuperBossZombie>();
        }
        return prefab;
    }
}