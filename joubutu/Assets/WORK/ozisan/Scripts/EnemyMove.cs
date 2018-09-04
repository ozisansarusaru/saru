using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    [SerializeField][Range(5f,10f)]
    private float m_enemySpeed;

    private GameObject m_targetPlayer;

    private Vector3 m_targetPosition;

    private SpriteRenderer m_spriteRenderer;

	// Use this for initialization
	void Start () {
        m_spriteRenderer = GetComponent<SpriteRenderer>();

        if (!m_targetPlayer){
            m_targetPlayer = GameObject.FindWithTag("Player");
            m_targetPosition = m_targetPlayer.transform.position;
        }

        if (transform.position.x > m_targetPosition.x){
            m_enemySpeed = m_enemySpeed * -1f;
            m_spriteRenderer.flipX = false;
        }
        else{
            m_enemySpeed = m_enemySpeed * 1f;
            m_spriteRenderer.flipX = true;
        }
	}
	
	// Update is called once per frame
	void Update () {
        PopukoMove();
	}


    private void PopukoMove(){

        var theta = Mathf.Atan2(transform.position.y - m_targetPosition.y,
                                transform.position.x - m_targetPosition.x);

        var vy = Mathf.Sin(theta) * 5f;


        float hoge = Vector3.Distance(transform.position, m_targetPosition);


        GetComponent<Rigidbody2D>().velocity = new Vector2(m_enemySpeed,-vy);
    }
}
