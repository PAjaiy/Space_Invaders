using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform positionToInstantiate;
    public PlayerMovement mover;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && mover.startShooting == true)
        {
            Instantiate(bullet, positionToInstantiate.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.Space) && mover.startShooting == false)
        {
        }
    }
}
