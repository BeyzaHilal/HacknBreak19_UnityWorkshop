using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject BulletPrefab;
    
    public float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
           transform.Translate(Vector3.right*speed*Time.deltaTime); 
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left*speed*Time.deltaTime); 
        }

        // Fire
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector2 position = transform.GetChild(0).GetComponent<Transform>().position;
            Instantiate(BulletPrefab, position, Quaternion.identity);
            SoundController.instance.PlayFireSound();
        }
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Player Collision Enter");
        if (other.gameObject.CompareTag("Asteroid"))    // GameOver
        {
            SoundController.instance.PlayCollisionSound();
            GameController.instance.GameOver();
            Destroy(other.gameObject);
            Destroy(gameObject);     // Player has been destroyed.
        }
    }
}
