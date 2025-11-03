// ==================================================
// Module: Enemy
// Purpose: define the enemy: life and chase the target; take damage
// Author: Shuheng
// Date: 2025/10/11
// Dependencies: take damage by bullet; 
// ==================================================

using UnityEditor.Animations;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public Vector3 target; 
    private Transform targetTransform;
    [HideInInspector] public float life;
    [HideInInspector] public float speed;
    [HideInInspector] public float damage;
    [HideInInspector] private float scalex;
    [HideInInspector] private int faceDir = 1;
    public Animator animator;
    public EnemyData enemyData;
    

    protected virtual void Start()
    {
        scalex = transform.localScale.x;
        damage = enemyData.damageToPlayer;
        life = enemyData.maxLife;
        animator = transform.GetComponent<Animator>();
        if (targetTransform == null)
        {
            GameObject player = GameObject.FindWithTag("Player");
            if (player != null)
            {
                targetTransform = player.transform;
            }
        }
    }

    protected virtual void Update()
    {
        target = targetTransform.position;
        FaceDir();
        Move();
        Died();
    }

    public void TakeDamage(float damage)
    {
        life = life - damage;
    }

    protected abstract void Move();

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            var player = collision.GetComponent<PlayerState>();
            if (player != null)
            {
                player.TakeDamage(damage);
            }

            OnHitEnemy(collision);
        }
    }
    protected virtual void OnHitEnemy(Collider2D other)
    {
        Destroy(gameObject);
    }

    protected virtual void Died()
    {
        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }
    
    protected virtual void FaceDir()
    {
        if(faceDir * (transform.position.x - target.x) <= 0)
        {
            faceDir = -faceDir;
            transform.localScale = new Vector3(faceDir * scalex, transform.localScale.y);
        }
    }
}
