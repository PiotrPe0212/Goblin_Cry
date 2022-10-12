using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratingGoblinFace : MonoBehaviour
{
    public FaceElement GFace;
    public FaceElement GEyes;
    private GameObject _goblinHead;
    void Start()
    {
        _goblinHead = new GameObject("Goblin_Head");
        _goblinHead.transform.SetParent(GameObject.Find("GameElements").transform);
        Instantiate(GFace.ElementArray[Random.Range(0, GFace.ElementArray.Length)], transform.position, transform.rotation, _goblinHead.transform);
        Instantiate(GEyes.ElementArray[Random.Range(0, GEyes.ElementArray.Length)], transform.position, transform.rotation, _goblinHead.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
