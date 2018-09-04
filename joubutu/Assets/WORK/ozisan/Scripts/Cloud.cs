using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour {

    [SerializeField]
    private float m_cloudMove;

    private Renderer m_renderer;

    private bool m_enabled;


    private void CloudMove()
    {
        transform.position += new Vector3(0, -m_cloudMove, 0);
    }

    private void Start()
    {
        m_enabled = false;
        m_renderer = GetComponent<Renderer>();
    }
    // Update is called once per frame
    void Update () {
        CloudMove();

        //画面外に出たら死亡
        if (!m_enabled && m_renderer.isVisible)
            m_enabled = true;
        if (m_enabled && !m_renderer.isVisible)
            Destroy(gameObject);
    }
}
