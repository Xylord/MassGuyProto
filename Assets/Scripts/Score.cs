using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour
{

    public Text countText;
    private int count;
    // Use this for initialization
    void Start()
    {
        count = 0;
        countText.text = "Count: " + count;
    }

    // Update is called once per frame
    void Update()
    {
        count += 1;
        countText.text = "Count: " + count.ToString();
        SetCountText();

        // For Testing put in parenthesis conditions to increment Scores. 
        if (Input.GetKeyDown(KeyCode.A))
            count += 1000;

    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }
}
