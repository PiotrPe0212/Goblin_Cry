using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : HosingAction
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            print(touch.position.x);
            if (touch.position.x == this.transform.position.x) print("ok");
        }
    }
}
