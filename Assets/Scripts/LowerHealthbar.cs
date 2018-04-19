using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerHealthbar : MonoBehaviour {

    private int lives = 10;

    public void Shrink()
    {
        if (lives > 0)
        {
            lives--;
            transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
        }
    }
}
