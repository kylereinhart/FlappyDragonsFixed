using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static float mscoreValue = 0;
    TMP_Text mScore;
    
    // Start is called before the first frame update
    void Start()
    {
        mScore = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex < 2)
        {
            mscoreValue += Time.deltaTime;
            mScore.text = "Score " + (int)mscoreValue;
        }

        else
        {
            mScore.text = "" + (int) mscoreValue;
        }
        
    }
}
