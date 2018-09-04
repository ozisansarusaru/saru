using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjHA : MonoBehaviour {

    //Rigidbody2D コンポーネント
    private Rigidbody2D rigidbody2d;

    //オブジェクトの動く方向
    private float x;

    //消えるまでの時間
    private int trg = 240;

    // Use this for initialization
    void Start () {

        Init();

        Move();
	}
	
	// Update is called once per frame
	void Update () {

        Dead();
	}

    /// <summary>
    /// 初期にやる系のやつ
    /// </summary>
    void Init()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// 動き関連
    /// </summary>
    void Move()
    {
        x = Random.Range(-2f, 2f);

        rigidbody2d.velocity = new Vector2(x, 2);
    }

    /// <summary>
    /// 一定時間たったら消えるやつ
    /// </summary>
    void Dead()
    {
        trg--;

        if(trg < 0)
        {
            Destroy(this.gameObject);
        }
    }
}
