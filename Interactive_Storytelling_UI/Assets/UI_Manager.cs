using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public Text score_TXT;
    public float score;
    public bool ImageVisible;

    public Image ToggleableImage;

    // Start is called before the first frame update
    void Start()
    {
        score_TXT.text = 0.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        score_TXT.text = score.ToString();
    }

    public void IncreaseScore()
    {
        score += 10;
    }

    public void DecreaseScore()
    {
        score -= 10;
    }

    public void ResetScore()
    {
        score = 0;
    }

    public void HideShowImage()
    {
        ImageVisible = !ImageVisible;

        if (ImageVisible == true)
        {
            ToggleableImage.enabled = true;
        }
        else
        {
            ToggleableImage.enabled = false;
        }
    }
}
