using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingPressedButton : MonoBehaviour
{
    private Vector3 _size;
    public bool ButtonClicked;
    public GameObject  parentObj;
    private ButtonScript parentButtopnScript;
    void Start()
    {
        transform.localScale = new Vector3(0, 1, 1);
        parentObj = transform.parent.gameObject;
        parentButtopnScript = parentObj.GetComponent<ButtonScript>();
        _size = parentObj.GetComponent<SpriteRenderer>().size;

    }

    void Update()
    {
        if (!parentButtopnScript.ButtonPressed) transform.localScale = new Vector3(0, 1, 1); 

        ClickCheck(transform.position.x, transform.position.y);
       
    }

    private void ClickCheck(float Xpos, float Ypos)
    {
        if(Helpers.IsMouseInObjectPosition(Xpos, Ypos, MouseController.Instance.CamPos, _size))
        if (transform.localScale.x < 1) transform.localScale = new Vector3(transform.localScale.x + Time.deltaTime/3, 1, 1);
    }
}
