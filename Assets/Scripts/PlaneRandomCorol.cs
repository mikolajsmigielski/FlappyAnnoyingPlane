using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneRandomCorol : MonoBehaviour
{
    public string[] Animations;
    // Start is called before the first frame update
    void Start()
    {
        var index = Random.Range(0, Animations.Length);
        GetComponent<Animator>().Play(Animations[index]);
    }

    
    
}
