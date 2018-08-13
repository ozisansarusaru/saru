using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUp : MonoBehaviour {


    /// <summary>上に昇るスピード</summary>
    [SerializeField]
    private Vector3 m_moveSpeed;

    void PlayerMove(){
        transform.position += m_moveSpeed;
    }	

	// Update is called once per frame
	void Update () {
        PlayerMove();
	}
}
