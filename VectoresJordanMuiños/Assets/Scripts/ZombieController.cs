using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float speedZombie = 2f;
    public float damageZombie;
    private GameObject Player;
    [SerializeField] private float timeZombie = 3f;
    [SerializeField] private Dificult Dificulty;
    [SerializeField] private float NormalTime = 5f;
    [SerializeField] private float HardTime = 10f;
    private enum Dificult
    {
        Easy,
        Normal,
        Hard,
    }
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        switch(Dificulty)
        {
            case Dificult.Easy:
                timeZombie -= Time.deltaTime;
                if (timeZombie > 0)
                {
                    
                    LookAtLerp(Player);
                    //MoveEnemy(Vector3.forward);    
                }
                else
                {
                    Destroy(gameObject);
                }
              
                break;

        }
        switch(Dificulty)
        {
            
            case Dificult.Normal:
                NormalTime -= Time.deltaTime;
            if (NormalTime > 0)
            {
                    MoveTowadsNormal();
                
                //MoveEnemy(Vector3.forward);    
            }
            else
            {
                    Destroy(gameObject);
            }
            
            break;
        }
        switch (Dificulty)
        {

            case Dificult.Hard:
                HardTime -= Time.deltaTime;
                if (HardTime > 0)
                {
                    MoveTowads();
                    LookAtLerp(Player);
                    //MoveEnemy(Vector3.forward);    
                }
                else
                {
                    Destroy(gameObject);
                }

                break;
        }


    }
    /*private void MoveEnemy(Vector3 direction)
    {
        transform.Translate(speedZombie * direction * Time.deltaTime);
    }*/
    private void MoveTowads()
    {
        Vector3 direction = Player.transform.position - transform.position;
        transform.position += speedZombie * direction.normalized * Time.deltaTime;
    }
    private void MoveTowadsNormal()
    {
        Vector3 direction = Player.transform.position - transform.position;
        //transform.position += speedZombie * direction.normalized * Time.deltaTime;
        if (direction.magnitude > 10)
        {
            transform.position += speedZombie * direction.normalized * Time.deltaTime;
        }
    }


    private void LookAtLerp(GameObject lookObject)
    {
        Vector3 direction = lookObject.transform.position - transform.position;
        Quaternion newQuaternion = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, newQuaternion, 1f*Time.deltaTime);
    }
}
