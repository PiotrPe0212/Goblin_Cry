using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeController : MonoBehaviour
{
    public static LifeController Instance;

    private void Awake()
    {
        Instance = this;
    }

    public int LifeValue = 3;
    public void LifeChange()
    {
        if (LifeValue > 0)
        {
            LifeValue--;
            TextChange();
        }
    }

    private void Update()
    {
        if (LifeValue < 3) print(LifeValue);
    }

    private void TextChange()
    {
        this.GetComponent<Text>().text = LifeValue.ToString();

    }
}
