using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HosingAction : MonoBehaviour
{

    protected virtual void ButtonAction(ProblemGenerator.BabyProblem solution)
    {
        ProblemGenerator.Instance.ChosenSolution = solution;

    } 

    protected virtual void IsItClickedCheck(float Xpos, float Ypos, Vector3 size, ProblemGenerator.BabyProblem problem)
    {
        if(Helpers.IsMouseInObjectPosition(Xpos, Ypos, MouseController.Instance.CamPos, size))
        ButtonAction(problem);
    }
}
