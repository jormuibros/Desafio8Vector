using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombiegenerator : MonoBehaviour
{
    public GameObject[] ZombiePrefab;
    [SerializeField] private float repeatinZombie = 1f;
   

// Start is called before the first frame update
void Start()
    {
        InvokeRepeating("SpawnZombie", 1f, repeatinZombie);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnZombie()
    {
        //Instantiate(BulletPrefab, transform);
        int enemyIndex = Random.Range(0, ZombiePrefab.Length);
        Instantiate(ZombiePrefab[enemyIndex], transform);
    }
}
