using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fura : MonoBehaviour {

    public float spd = 3.0f;
    public float rot = 10.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Move();
	}

    /// <summary>
    /// 振子運動みたいなやつ
    /// </summary>
    void Move()
    {
        transform.rotation = Quaternion.Euler(0, 0, Mathf.Sin(Time.time * spd) * rot);
    }
}
