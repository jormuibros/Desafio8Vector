using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int playerLives; //la vida actual del jugador
    //public  Vector3 PlayerDirection; //direccion
    public int itemHealer; //sanacion
    public int enemyDamage; //da�o
    public int playerDeshearted; //variable de corazones para restar
    public float speedPlayer; //velocidad
    public float speedRotation = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
        Heal();
        Damage();
        
        if (playerLives > 0)
        {
            Debug.Log("Jugador esta vivo");
        }
        else
        {
            Debug.Log("Jugador esta muerto");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Move();
       
    }
        
    private void Move()
    {
        float ejeHorizontal = Input.GetAxis("Horizontal");
        float ejeVertical = Input.GetAxis("Vertical");
        transform.Translate(0, 0, ejeVertical*Time.deltaTime*speedPlayer);
        transform.Rotate(0, ejeHorizontal * Time.deltaTime * speedRotation, 0);
    }
    void Heal()
    {
        playerLives = playerLives + itemHealer;
    }

    void Damage()
    {
        playerLives = playerLives - enemyDamage;
    }
}
