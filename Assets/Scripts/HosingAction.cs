using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HosingAction : MonoBehaviour
{

    protected virtual void ButtonAction(BabyProblems.BabyProblem solution)
    {
        ProblemCheck.Instance.NewPoblemSolution(solution);
        print("clicked");

    } 

    protected virtual void IsItClickedCheck(float Xpos, float Ypos, Vector3 size, BabyProblems.BabyProblem problem)
    {
        if(Helpers.IsMouseInObjectPosition(Xpos, Ypos, MouseController.Instance.CamPos, size))
        ButtonAction(problem);
    }
}
