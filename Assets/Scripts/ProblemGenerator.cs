using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProblemGenerator : MonoBehaviour
{

    public static ProblemGenerator Instance;

    public static event System.Action<BabyProblems.BabyProblem> OnProblemChange;

    private void Awake()
    {
        Instance = this;
    }
    public BabyProblems.BabyProblem CurrentProblem;

    private void Start()
    {
        ProblemGenerating();
    }

    private void ProblemGenerating()
    {
        CurrentProblem = (BabyProblems.BabyProblem)Random.Range(0, System.Enum.GetValues(typeof(BabyProblems.BabyProblem)).Length);
    }

    void Update()
    {
        if (GameManager.Instance.State == GameManager.GameState.PlayGame) return;

        if (CurrentProblem == BabyProblems.BabyProblem.None) ProblemGenerating();
   
    }

    public void ProblemReset()
    {
        CurrentProblem = BabyProblems.BabyProblem.None;
    }

    
}
