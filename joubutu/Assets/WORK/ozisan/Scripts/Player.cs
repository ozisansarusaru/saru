using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField][Range(0.1f,0.5f)]
    private float m_moveSpeed;

    private SpriteRenderer m_spriteRenderer;

    private AudioSource m_audioSource;

    private Rigidbody2D m_rigidbody2D;

    [SerializeField]
    private AudioClip m_playerDethe;

    private int trg = 0;

    void Move(){
        if (Input.GetKey(KeyCode.A)){
            transform.position += new Vector3(-m_moveSpeed, 0, 0);
            m_spriteRenderer.flipX = true;
        }
        if (Input.GetKey(KeyCode.D)){
            transform.position += new Vector3(m_moveSpeed, 0, 0);
            m_spriteRenderer.flipX = false;
        }
        if (Input.GetKey(KeyCode.W)){
            transform.position += new Vector3(0, m_moveSpeed, 0);
        }
        if (Input.GetKey(KeyCode.S)){
            transform.position += new Vector3(0, -m_moveSpeed, 0);
        }

        if(m_rigidbody2D.IsSleeping())
        m_audioSource.Play();
    }

    private void OnTriggerEnter2D(Collider2D arg_col)
    {
        if (arg_col.tag == "Enemy")
        {
            if (trg == 0)
            {
                FadeManager.Instance.LoadScene("GameOver", 2.0f);
                m_audioSource.clip = m_playerDethe;
                m_audioSource.Play();
                trg = 1;
            }
        }
    }

    private void Start(){
        m_spriteRenderer = GetComponent<SpriteRenderer>();
        m_audioSource = GetComponent<AudioSource>();
        m_rigidbody2D = GetComponent<Rigidbody2D>();      
    }

    // Update is called once per frame
    void Update () {
        Move();
    }
}
