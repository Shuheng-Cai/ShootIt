using UnityEngine;

public class BeeBullet : MonoBehaviour
{
    public float lifeTime;
    public int speed;
    private Vector3 moveDirection;
    private float damage;
    public void setDamage(float damage)
    {
        this.damage = damage;
    }
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        Move();
    }
    private void Move()
    {

        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    
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
}
