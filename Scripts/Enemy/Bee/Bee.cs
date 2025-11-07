// Module: Bee
// Purpose: Create GameOer text
// Invariants: 
// Performance: 
// Dependencies: Enemy and the position of Player
// Known Tricky Cases: 

using System.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Splines;
using UnityEngine.Splines.ExtrusionShapes;

public class Bee : Enemy
{
    public float distanceToPlayer;
    private Vector3 direction = new Vector3();
    public GameObject bulletPrefabs;
    private bool canShoot = true;

    void FixedUpdate()
    {
        if (canShoot)
        {
            StartCoroutine(Shooting());
        }
        
    }

    protected override void Move()
    {
        direction = (target - transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion beeRotation = Quaternion.Euler(0, 0, angle + 90f);
        float distanceBetweenTarget = Mathf.Pow(target.x - transform.position.x, 2) + Mathf.Pow(target.y - transform.position.y, 2);
        if (distanceBetweenTarget >= Mathf.Pow(distanceToPlayer, 2))
        {
            transform.position += direction * speed * Time.deltaTime;
        }
        transform.localRotation = beeRotation;
    }

    IEnumerator Shooting()
    {
        animator.SetTrigger("isAttack");
        canShoot = false;
        yield return new WaitForSeconds(4f);
        canShoot = true;
    }
    public void Shoot()
    {
        Quaternion bulletAngle = Quaternion.Euler(0f, 0f, transform.eulerAngles.z + 90f);
        GameObject bullet = Instantiate(bulletPrefabs, transform.position, bulletAngle);
        bullet.GetComponent<BeeBullet>().setDamage(enemyData.damageToPlayer);
    }
}
