using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour {

    //移動方向を決める
    private bool trg = true;

    //移動時間
    private int time = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Move();
	}
    /// <summary>
    /// 顔が動く処理
    /// </summary>
    void Move()
    {
        //trg切り替え
        if(time < 10)
        {
            time++;
        }
        else
        {
            if (trg)
            {
                trg = false;
            }
            else
            {
                trg = true;
            }
            time = 0;
            
        }

        if(trg)
        {
            transform.position -= new Vector3(0f, 0.015f, 0f);
        }
        else
        {
            transform.position += new Vector3(0f, 0.015f, 0f);
        }
    }
}
