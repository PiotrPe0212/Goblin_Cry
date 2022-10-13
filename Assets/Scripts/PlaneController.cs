using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    [SerializeField] private GameObject MenuPlane;
    [SerializeField] private GameObject ChangingStatePlane;
    [SerializeField] private GameObject GamePlane;
    [SerializeField] private GameObject LosePlane;
    private void Awake()
    {
        GameManager.OnStateChange += PlaneHandler;
    }
    private void OnDestroy()
    {
        GameManager.OnStateChange -= PlaneHandler;
    }

    private void PlaneHandler(GameManager.GameState currentState)
    {
        switch (currentState)
        {
            case GameManager.GameState.MainMenu:
                MenuPlane.SetActive(true);
                break;
            case GameManager.GameState.PlayGame:
                MenuPlane.SetActive(false);
                GamePlane.SetActive(true);
                break;
            case GameManager.GameState.Lose:
                GamePlane.SetActive(false);
                LosePlane.SetActive(true);
                break;
            default:
                throw new System.ArgumentOutOfRangeException(nameof(currentState), currentState, "Wrong argument!");
        }



    }

}
