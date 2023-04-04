using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Progressbar : MonoBehaviour
{
    public Slider slider;
    int progress = 0;

    public void UpdateProgress()
    {
        progress++;

        slider.value = progress;
    }

    public void RemoveProgress()
    {
        progress--;

        slider.value = progress;
    }
}
