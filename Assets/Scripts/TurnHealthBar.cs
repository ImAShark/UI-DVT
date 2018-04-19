using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnHealthBar : MonoBehaviour {

    public int lives = 10;

    public void Rotate()
    {
        if (lives > 0)
        {
            lives--;
            transform.Rotate(0, 0, 15);
        }
    }
}
