// Module: BaseBullet
// Purpose: Define the father type of Bullet.
// Invariants: 
// Performance: 
// Dependencies: 
// Known Tricky Cases: canPenetrate; fireRate is from Player state, which is not from the bullet.

using UnityEngine;

public abstract class BaseBullet : MonoBehaviour
{
    public float damage;
    public float speed;
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
