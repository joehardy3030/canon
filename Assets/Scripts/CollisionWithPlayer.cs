using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithPlayer : MonoBehaviour
{
    int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter (Collision collision)
    {
        print("Collided with " + collision.collider.gameObject.tag);
        if (collision.collider.gameObject.tag == "pick_me")
        {
            Destroy(collision.collider.gameObject);
            score++;
            print("Score" +score);
        }

    }
} 
