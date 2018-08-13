using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackScroll : MonoBehaviour {

    /// <summary>スクロールスピード </summary>
    [SerializeField]
    private float m_scrollSpeed;

    /// <summary> タイルサイズ</summary>
    [SerializeField]
    private float m_tileSize;

    private Vector3 startPos;

    // Use this for initialization
    void Start () {
        startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        float newPos = Mathf.Repeat(Time.time * m_scrollSpeed, m_tileSize);

        transform.position = startPos + Vector3.up * newPos;
	}
}
