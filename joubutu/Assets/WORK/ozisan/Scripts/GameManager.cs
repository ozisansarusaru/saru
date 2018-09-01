using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum GameState
{
    Start,
    Prepare,
    Playing,
    End
}

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    // 現在の状態
    private GameState currentGameState;


    // 例

    public Text label;
    public Button button;

    private Text m_text;

    void Awake()
    {
        Instance = this;
        SetCurrentState(GameState.Start);
    }


    // 外からこのメソッドを使って状態を変更
    public void SetCurrentState(GameState state)
    {
        currentGameState = state;
        OnGameStateChanged(currentGameState);
    }

    // 状態が変わったら何をするか
    void OnGameStateChanged(GameState state)
    {
        switch (state)
        {
            case GameState.Start:
                StartAction();
                break;
            case GameState.Prepare:
                StartCoroutine(PrepareCoroutine());
                break;
            case GameState.Playing:
                PlayingAction();
                break;
            case GameState.End:
                EndAction();
                break;
            default:
                break;
        }
    }

    // Startになったときの処理
    void StartAction()
    {
    }

    // Prepareになったときの処理
    IEnumerator PrepareCoroutine()
    {
        label.text = "3";
        yield return new WaitForSeconds(1);
        label.text = "2";
        yield return new WaitForSeconds(1);
        label.text = "1";
        yield return new WaitForSeconds(1);
        label.text = "";
        SetCurrentState(GameState.Playing);
    }
    // Playingになったときの処理
    void PlayingAction()
    {
        label.text = "ゲーム中";
    }
    // Endになったときの処理
    void EndAction()
    {
    }
}
