using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HosingAction : MonoBehaviour
{
    
    protected virtual void ButtonAction(ProblemGenerator.BabyProblem solution)
    {
        ProblemGenerator.Instance.ChosenSolution = solution;
    }
}
