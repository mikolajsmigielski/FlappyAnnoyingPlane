using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    public Sprite[] sprites;
    public float Duration = 1f;
    void Start()
    {
        StartCoroutine(ChangeSpritesCorutine());
    }

    
    IEnumerator ChangeSpritesCorutine()
    {
        var renderer = GetComponent<SpriteRenderer>();
        for (int i = 0; true; i++)
        {
            renderer.sprite = sprites[i % sprites.Length];
            
            yield return new WaitForSeconds(Duration);
        }
    }
}
