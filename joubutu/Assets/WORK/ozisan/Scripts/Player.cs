using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField][Range(0.1f,0.5f)]
    private float m_moveSpeed;

    void Move(){
        if (Input.GetKey(KeyCode.A)){
            transform.position += new Vector3(-m_moveSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D)){
            transform.position += new Vector3(m_moveSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.W)){
            transform.position += new Vector3(0, m_moveSpeed, 0);
        }
        if (Input.GetKey(KeyCode.S)){
            transform.position += new Vector3(0, -m_moveSpeed, 0);
        }
    }
	
	// Update is called once per frame
	void Update () {
        Move();
    }
}
