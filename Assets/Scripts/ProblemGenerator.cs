using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProblemGenerator : MonoBehaviour
{

    public static ProblemGenerator Instance;

    public static event System.Action<BabyProblem> OnProblemChange;

    private void Awake()
    {
        Instance = this;
    }
    public BabyProblem CurrentProblem;
    public BabyProblem ChosenSolution;
    private float _behaviorTime;
    void Start()
    {
        
    }

    public static void NewPoblemSolution (BabyProblem newSolution)
    {
        ProblemGenerator.Instance.ChosenSolution = newSolution;



    }

    private void ProblemComparison()
    {
        if (CurrentProblem != ChosenSolution) return;
        CurrentProblem = BabyProblem.None;
        //addingPoiunt calling
    }

    private void ProblemGenerating()
    {
        CurrentProblem = (BabyProblem)Random.Range(0, System.Enum.GetValues(typeof(BabyProblem)).Length);
        BehaviorTimer(3);
    }

    private void BehaviorTimer(int delay)
    {
        _behaviorTime = Time.time + delay;
    }
    void Update()
    {
        if (GameManager.Instance.State == GameManager.GameState.PlayGame) return;

          if(CurrentProblem == BabyProblem.None) ProblemGenerating();
        else
        {
            if (Time.time >= _behaviorTime) { ProblemGenerating();
                print(-1);
            }// +mistake counter 
            else ProblemComparison();

        }
      
    }

    public enum BabyProblem
    {
        None,
        Hungry,
        Diaper,
        Temperature,
        Sleepy,
        NeedHug

    }
}
