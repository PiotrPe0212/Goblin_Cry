using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProblemCheck : MonoBehaviour
{

    public static ProblemCheck Instance;
    private float _currentTime;
    [SerializeField] private int TimeToCry = 5;

    private void Awake()
    {
        Instance = this;
        GameManager.OnStateChange += TimerStart;
    }
    private void OnDestroy()
    {
        GameManager.OnStateChange -= TimerStart;
    }

    public BabyProblems.BabyProblem ChosenSolution;

    public  void NewPoblemSolution(BabyProblems.BabyProblem newSolution)
    {
        ProblemCheck.Instance.ChosenSolution = newSolution;
        print(newSolution);
        TimerForCry(TimeToCry);

    }
    private void ProblemComparison()
    {
        if (ProblemGenerator.Instance.CurrentProblem != ChosenSolution) return;
        ProblemGenerator.Instance.ProblemReset();
        //addingPoiunt calling
    }

    private void Update()
    {
        if (GameManager.Instance.State == GameManager.GameState.PlayGame) return;
        if (Time.time < _currentTime) ProblemComparison();
        else NeedNotFulfilled();

    }

    private void TimerForCry(int delay)
    {
       _currentTime = Time.time + delay;
    }

    private void NeedNotFulfilled()
    {
        LifeController.Instance.LifeChange();
        TimerForCry(TimeToCry);
    }

    private void TimerStart(GameManager.GameState currentState)
    {
        if( currentState == GameManager.GameState.PlayGame)
        TimerForCry(TimeToCry);
    }
}
