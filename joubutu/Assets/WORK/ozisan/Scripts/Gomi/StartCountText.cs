using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartCountText : MonoBehaviour {

    [SerializeField]
    private Text m_text;

    IEnumerator CountTest()
    {
        m_text.text = "さん！";
        yield return new WaitForSeconds(1);
        m_text.text = "にい！";
        yield return new WaitForSeconds(1);
        m_text.text = "いち！";
        yield return new WaitForSeconds(1);
        m_text.text = "START!";
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }

    private void Start()
    {
        //m_text.enabled = false;
        StartCoroutine(CountTest());
    }
}
