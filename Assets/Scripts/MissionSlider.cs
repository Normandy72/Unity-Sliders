using UnityEngine;
using UnityEngine.UI;

public class MissionSlider : MonoBehaviour
{
    public GameObject containerPanel;
    public GameObject[] missionsPanel;
    public Button sliderButtonLeft;
    public Button sliderButtonRight;
    
    private int _currentIndex = 0;
    private float _containerPositionX;

    private void Start()
    {
        _containerPositionX = containerPanel.transform.position.x;
    }

    public void SlideToLeft()
    {
        if(_currentIndex > 0)
        {
            _currentIndex--;
            var targetPanel = missionsPanel[_currentIndex];
            float targetPositionX = _containerPositionX - targetPanel.transform.position.x;
            var targetPosition = new Vector3(containerPanel.transform.position.x + targetPositionX, containerPanel.transform.position.y, containerPanel.transform.position.z);
            iTween.MoveTo(containerPanel, targetPosition, 0.5f);
        }
    }

    public void SlideToRight()
    {
        if(_currentIndex < missionsPanel.Length)
        {
            _currentIndex++;
            var targetPanel = missionsPanel[_currentIndex];
            float targetPositionX = _containerPositionX - targetPanel.transform.position.x;
            var targetPosition = new Vector3(containerPanel.transform.position.x + targetPositionX, containerPanel.transform.position.y, containerPanel.transform.position.z);
            iTween.MoveTo(containerPanel, targetPosition, 0.5f);
        }
    }
}
