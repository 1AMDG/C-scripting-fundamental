using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public CapsuleCollider playerCollider;
    public float moveSpeed = 5f;
    //private GameObject enemy;
    // private GameObject enemyScript;

    // Start is called before the first frame update
    void Start()
    {
        playerCollider = this.GetComponent<CapsuleCollider>();
        playerCollider.height = 1.0f;
        playerCollider.center = new Vector3(0f, 0.5f, 0f);

        //enemy = GameObject.Find("Battle_Dummy");
       // enemyScript = enemy.GetComponent<Enemy>();  
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

        transform.Translate(movement * Time.deltaTime * moveSpeed);

      
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            // enemyScript = collision.gameObject.GetComponent<Enemy>();
            // enemyScript.enemyHealth--;
        }
    }
}
