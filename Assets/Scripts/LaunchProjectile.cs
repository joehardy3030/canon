using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{
    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.P))
        {
            GameObject t = (GameObject)Instantiate(projectile, transform.position, Quaternion.identity);
            Destroy(t, 3);
            t.GetComponent<Rigidbody>().AddForce(transform.forward * 500);
        }
    }
}
