﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> カメラ追従する</summary>
public class CameraControl : MonoBehaviour
{

    private GameObject player = null;
    private Vector3 offset = Vector3.zero;

    void Start(){
        //Playerタグをつけたものを追従
        player = GameObject.FindGameObjectWithTag("Player");

        //カメラとプレイヤーの差分
        offset = transform.position - player.transform.position;
    }

    void LateUpdate(){
        Vector3 newPosition = transform.position;
        newPosition.x = player.transform.position.x + offset.x;
        newPosition.y = player.transform.position.y + offset.y;
        newPosition.z = player.transform.position.z + offset.z;
        transform.position = newPosition;
    }
}