using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public bool startShooting = true;

    private Vector3 placeToMoveWhenYouClickTheLeftButton;
    private Vector3 placeToMoveWhenYouClickTheRightButton;
    
    private void Update()
    {
        placeToMoveWhenYouClickTheLeftButton = player.transform.position + new Vector3(-speed, 0, 0);
        placeToMoveWhenYouClickTheRightButton = player.transform.position + new Vector3(speed, 0, 0);

        if(Input.GetKey(KeyCode.D))
        {
            player.transform.position = Vector3.Lerp(transform.position, placeToMoveWhenYouClickTheRightButton, Time.deltaTime);
            startShooting = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.position = Vector3.Lerp(transform.position, placeToMoveWhenYouClickTheLeftButton, Time.deltaTime);
            startShooting = false;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            player.transform.position += new Vector3(0, 0, 0);
            startShooting = true;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            player.transform.position += new Vector3(0, 0, 0);
            startShooting = true;
        }
    }
}
