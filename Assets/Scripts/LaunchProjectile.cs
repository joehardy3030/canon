using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{
    public GameObject projectile;
    public GameObject target;
    float time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 2.0)
        {
            time = 0;
         //   if (Input.GetKeyDown(KeyCode.P))
          //  {
                transform.LookAt(target.transform);
                GameObject t = (GameObject)Instantiate(projectile, transform.position, Quaternion.identity);
                Destroy(t, 3);
                t.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
        //    }
        }
    }
}
