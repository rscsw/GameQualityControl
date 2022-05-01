using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower1 : MonoBehaviour
{
    private Transform target; // Ÿ�� ��ġ = �� ��ġ 
    public float range = 3f; // ��Ÿ�
    public float atkSpeed = 0.5f; // ���ݼӵ�

    [Header("Attributes")]

    public float fireRate = 1f;
    private float fireCountDown = 0f;

    [Header("Unity Setup Fields")]

    public float tower1_AttackPower; //���ݷ�

    public GameObject bulletPrf; // Bullet ������
    public Transform firePoint; // �Ѿ� ���� ��ġ

    public string enemyTag = "Enemy";


    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, atkSpeed);
    }

    void UpdateTarget() //Ÿ������
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);

            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
        }
        else
        {
            target = null;
        }
    }

    void Update()
    {
        if (target == null)
            return;

        if (fireCountDown <= 0)
        {
            Shoot();
            fireCountDown = 1f / fireRate;
        }

        fireCountDown -= Time.deltaTime;
    }

    void Shoot()
    {
        GameObject bulletGo = (GameObject)Instantiate(bulletPrf, firePoint.position, firePoint.rotation);
        Bullet1 bullet1 = bulletGo.GetComponent<Bullet1>();

        if (bullet1 != null)
            bullet1.Seek(target);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);        
    }
}
