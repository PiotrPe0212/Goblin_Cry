using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(FaceElement), menuName = "Game/FaceElement")]
public class FaceElement : ScriptableObject
{
   public enum FaceElem
    {
        Eyes,
        Nose,
        Ears,
        Mouth,
        Hair
    }

    public GameObject[] ElementArray;
}
