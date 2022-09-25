using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : HosingAction
{
    [SerializeField] private ProblemGenerator.BabyProblem ButtonSolution;
    public int TimeToHoldButton = 3;
    public  bool ButtonPressed = false;
    private Vector3 _size;
    private float _loadingTime;

    void Start()
    {
     
        SpriteRenderer rend = gameObject.GetComponent<SpriteRenderer>();
        _size = rend.bounds.size;

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LoadTimer(TimeToHoldButton);
            ButtonPressed = true;
        }
        if (Input.GetMouseButtonUp(0)) ButtonPressed = false;
        if (!Input.GetMouseButton(0)) return;
        if (Time.time < _loadingTime) return;
        IsItClickedCheck(transform.position.x, transform.position.y, _size, ButtonSolution);

    }
    

    private void LoadTimer(int delay)
    {
        _loadingTime = Time.time + delay;
    }


}

