using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public TextMeshProUGUI valueText;
    public void OnSliderChanged(float value)
    {
        valueText.text = value.ToString();
    }
}
