using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sponer : MonoBehaviour {

    //出すオブジェクト
    public GameObject ha;

    //オブジェクトの座標
    private float x, y, z;

    //生成までのカウント
    private int trg = 80;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Create();
	}

    /// <summary>
    /// 2秒ごとに作って出すやつ
    /// </summary>
    void Create()
    {
        if (trg > 0)
        {
            trg--;
        }
        else
        {
            for (int i = 0; i < 5; i++)
            {
                x = Random.Range(-8.0f, 8.0f);
                y = Random.Range(-3.0f, 3.0f);
                z = Random.Range(0.0f, 359.0f);

                Instantiate(ha, new Vector3(x, y, 0), transform.rotation = Quaternion.Euler(0, 0, z));
            }

            trg = 80;
        }
    }
}
