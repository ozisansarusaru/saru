using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudGenerator : MonoBehaviour {

    [SerializeField]
    private GameObject m_cloud;

    [SerializeField][Range(1f, 5f)]
    private float m_birthTime;

    private float randomPosx;

    IEnumerator Gene()
    {
        while (true)
        {
            yield return new WaitForSeconds(m_birthTime);
            CloudBirth();
        }
    }

     private void CloudBirth()
    {
        randomPosx = Random.Range(-9f, 9f);
        
        Instantiate(m_cloud, new Vector3(randomPosx,transform.position.y,transform.position.z), Quaternion.identity);
    }

    private void Start()
    {
        StartCoroutine(Gene());
    }
}
