using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{private Transform player;
private Vector3 tempos;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        tempos=transform.position;
        tempos.x= player.position.x;
        tempos.y= player.position.y;
        transform.position=tempos;;
    }
}
