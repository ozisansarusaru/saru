using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour {

    /// <summary>消滅時間</summary>
    [SerializeField]
    private float m_desTime;

    /// <summary>スピード</summary>
    [SerializeField]
    private float m_speed;

    private Vector3 moveVector;


    /// <summary>
    /// 生成時に向かって移動する
    /// </summary>
    private void Move(){
        transform.position += moveVector;
    }

    //指定した時間後に消滅
    IEnumerator Destroy(){
        yield return new WaitForSeconds(m_desTime);
        Destroy(gameObject);
    }

	void Start(){
        moveVector = new Vector3(0, m_speed, 0);
    }

	// Update is called once per frame
	void Update () {
        Move();
        StartCoroutine(Destroy());
	}
}
