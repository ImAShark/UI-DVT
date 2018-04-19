using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DealDamage : MonoBehaviour {

    public Button theButton;
    public Text changeThisText;
    public int lives;

	// Use this for initialization
	void Start () {
        changeThisText.text = "Lives: " + lives;
	}

    public void KillHim()
    {
        if (lives > 0)
        {
            print("auw");
            lives--;
            changeThisText.text = "Lives: " + lives;
        }
    }
	
}
