using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Birdy : MonoBehaviour
{
    public bool isDead; // default hali false
    public float velocity = 1f;
    public  Rigidbody2D rb2D;
    public GameManager managerGame;

    public GameObject DeathScreen;
    private void Start()
    {
        Time.timeScale = 1;
    }
    
   
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))// kuþun sýcramasý
        {
            transform.rotation = Quaternion.Euler(0, 0, 10); // eðim
            rb2D.velocity = Vector2.up * velocity;

        }

        if (rb2D.velocity.y < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        
        if(collision.gameObject.name == "scoreArea" || collision.gameObject.tag == "Burger")
        {
            managerGame.UpdateScore();

            Debug.Log(collision.gameObject.tag);
        }
        
      

    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathArea")
        {
            isDead = true;
            Time.timeScale = 0; // daha fazla kuþu hareket ettirme
            DeathScreen.SetActive(true);
        }
    }
}
