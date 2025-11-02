// ==================================================
// Module: BaseBullet
// Purpose: define the spawn time and speed espacially whether can penentrate
// Author: Shuheng
// Date: 2025/10/11
// Dependencies: None
// ==================================================

using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public abstract class BaseBullet : MonoBehaviour
{
    public float damage;
    public float speed;
    public float fireRate; // spawn interval time;
    public GameObject player;
    public float lifeTime = 3f;
    public bool canPenetrate = false;

    public void Init(BulletData bulletData)
    {
        this.speed = bulletData.speed;
        this.lifeTime = bulletData.lifeTime;
        this.canPenetrate = bulletData.canPenetrate;
    }

    public void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        damage = player.GetComponent<PlayerState>().shootDamage;
        speed = player.GetComponent<PlayerState>().shootSpeed;
        fireRate = player.GetComponent<PlayerState>().fireRate;
    }

    protected virtual void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    protected virtual void Update()
    {
        Move();
    }

    protected abstract void Move(); // realize movement in the child.

    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            var enemy = other.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }

            OnHitEnemy(other);
        }
    }

    protected virtual void OnHitEnemy(Collider2D other)
    {
        if(!canPenetrate)
            Destroy(gameObject);
    }
}
