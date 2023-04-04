using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Slider timerSlider;
    public TextMeshProUGUI timerText;
    public float maxTime;
    private bool stopTimer;

    private void Start()
    {
        stopTimer = false;
        timerSlider.maxValue = maxTime;
        timerSlider.value = maxTime;
    }

    private void Update()
    {
        float time = maxTime - Time.time;

        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60f);

        string textTime = string.Format("{0:00} : {1:00}", minutes, seconds);

        if(time <= 0)
        {
            stopTimer = true;
        }

        if(stopTimer == false)
        {
            timerText.text = textTime;
            timerSlider.value = time;
        }
    }
}
