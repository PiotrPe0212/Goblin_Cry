using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helpers : MonoBehaviour
{
    public static bool IsMouseInObjectPosition(float Xpos, float Ypos, Vector3 camPos, Vector3 size)
    {
        if (Mathf.Clamp(camPos.x, Xpos - size.x / 2, Xpos + size.x / 2) != camPos.x) return false;
        if (Mathf.Clamp(camPos.y, Ypos - size.y / 2, Ypos + size.y / 2) != camPos.y) return false;
        return true;
    }

    private static readonly Dictionary<float, WaitForSeconds> WaitDictionary = new Dictionary<float, WaitForSeconds>();
    public static WaitForSeconds WaitHelper(float time)
    {
        if (WaitDictionary.TryGetValue(time, out var wait)) return wait;
        WaitDictionary[time] = new WaitForSeconds(time);
        return WaitDictionary[time];
    }
}
