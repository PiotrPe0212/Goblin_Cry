using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameState State;
    public static event System.Action<GameState> OnStateChange; 
  
    private void Awake()
    {
        Instance = this; 
        
    }
    void Start()
    {
        GameStateUpdate(State);
    }

    public void GameStateUpdate(GameState newState)
    {
        State = newState;
        OnStateChange?.Invoke(newState); 
    }

    public enum GameState
    {
        MainMenu,
        PlayGame,
        Lose
    }
}
