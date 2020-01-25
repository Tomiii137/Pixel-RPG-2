﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float camOffset = -10f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, camOffset);
    }
}
