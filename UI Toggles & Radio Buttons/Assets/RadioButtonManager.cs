using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadioButtonManager : MonoBehaviour {

    private string currentDifficulty = "Easy";

    public void PrintNewGroupValue(Toggle sender)
    {
        if (sender.isOn)
        {
            currentDifficulty = sender.tag;
            print("option changed to = " + currentDifficulty);
        }
    }

	
}
