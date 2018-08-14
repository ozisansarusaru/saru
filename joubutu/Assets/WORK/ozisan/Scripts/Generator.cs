using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {

    /// <summary> 生成する背景</summary>
    [SerializeField]
    private GameObject m_BackGround;

    IEnumerator Generate()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            Instantiate(m_BackGround,transform.position,Quaternion.identity);
        }
    }

    void Start(){
        StartCoroutine(Generate());
    }
}
