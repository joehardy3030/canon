using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageWeapons : MonoBehaviour
{
    Camera playersCamera;
    Ray rayFromPlayer;
    // Start is called before the first frame update
    void Start()
    {
        playersCamera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        rayFromPlayer = playersCamera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        Debug.DrawRay(rayFromPlayer.origin, rayFromPlayer.direction * 100, Color.red);
        //Debug.Log("Update");
    }
}
