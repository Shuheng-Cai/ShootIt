// ==================================================
// Module: Shooting
// Purpose: control player to shoot
// Author: Shuheng
// Date: 2025/10/11
// Dependencies: BaseBullet
// ==================================================

using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shooting : MonoBehaviour
{
    public BulletData currentBulletData; // bulletPrefabs;
    public int bulletType;
    public Vector2 shootPosition; // record the shooting postion(Player transform)
    public bool canShoot; // whether player can shoot
    public Quaternion bulletRotation;
    private int faceDir;
    private float scalex;
    public void MouseToPlayer()
    {
        Vector2 mousePosition = Mouse.current.position.ReadValue();
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(mousePosition);
        mouseWorldPos.z = 0f;
        Vector3 direction = mouseWorldPos - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        bulletRotation = Quaternion.Euler(0, 0, angle);

        if (faceDir * direction.x < 0)
        {
            faceDir = -faceDir;
            transform.localScale = new Vector3(faceDir * scalex, transform.localScale.y);
        }
    }

    void Start()
    {
        scalex = transform.localScale.x;
        canShoot = true;
        bulletType = 0;
        faceDir = 1;
    }
    
    public void Update()
    {
        shootPosition = gameObject.transform.position;
        MouseToPlayer();

        if (canShoot)
        {
            StartCoroutine(Shoot());
        }
    }

    // after spawn seconds, shoot once
    IEnumerator Shoot()
    {
        canShoot = false;
        GameObject bullet = Instantiate(currentBulletData.bulletPrefeb, transform.position, bulletRotation);
        bullet.GetComponent<BaseBullet>().Init(currentBulletData);
        bullet.SetActive(true);
        yield return new WaitForSeconds(bullet.GetComponent<BaseBullet>().fireRate);
        canShoot = true;
    }
}
