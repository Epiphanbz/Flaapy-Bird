using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public void empty()
    {

    }
    public enum GAME_STATUS
    {
        Ready,
        InGame,
        GameOver
    }

    private GAME_STATUS status;

    public GameObject panelReady;
    public GameObject panelInGame;
    public GameObject panelGameOver;
    public PipelineManger pipelineManger;


    void Start()
    {
        this.panelReady.SetActive(true);
    }

    void Update()
    {
        
    }

    public void StaratGame()
    {
        this.status = GAME_STATUS.InGame;
        UpdateUI();
        pipelineManger.StartRun();
        Debug.LogFormat("StartGame : {0}", this.status);
    }

    public void UpdateUI()
    {
        this.panelReady.SetActive(this.status == GAME_STATUS.Ready);
        this.panelInGame.SetActive(this.status == GAME_STATUS.InGame);
        this.panelGameOver.SetActive(this.status == GAME_STATUS.GameOver);
    }
}
