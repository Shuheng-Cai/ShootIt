using System.Security.Cryptography;
using UnityEditor.Animations;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/EnemyData")]
public class EnemyData : ScriptableObject
{
    public int enemyId;
    public float maxLife;
    public float damageToPlayer;
    public GameObject prefeb;
    public int baseWeight; // weight to spawn
    public float growthPerTenSecond;
    public int updateWave; // the wave of update
}
