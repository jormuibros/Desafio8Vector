using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControler : MonoBehaviour
{
    public Vector3 bulletDirection;
    public float bulletSpeed;
    public int bulletDamage;
    public float TimeBullet = 3f;
    public Vector3 bulletScale;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeBullet -= Time.deltaTime;
        if (TimeBullet > 0)
        {
            BulletMovement();
        }
        else
        {
            Destroy(gameObject);
        }
       if (Input.GetKeyDown(KeyCode.Space))
       {
         transform.localScale = bulletScale*2;
       }
    }

    void BulletMovement()
    {
        transform.Translate(bulletDirection * bulletSpeed * Time.deltaTime);
    }
    }
    