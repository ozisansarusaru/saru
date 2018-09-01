using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTest : MonoBehaviour {

    public void OnStartButton()
    {
        GameManager.Instance.SetCurrentState(GameState.Prepare);
    }
}
