using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    private Vector3 offset;
  

    // Smooth factor will be used
    public float smoothFactor = 0.5f;

    public bool lookAtTarget = true;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;   
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPosition = player.transform.position + offset;
        transform.position = newPosition;

        // Camera Rotation Change
        if (lookAtTarget)
        {
            transform.LookAt(player.transform);
        }



    }
}
