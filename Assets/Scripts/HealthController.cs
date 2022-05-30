using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{

    [SerializeField] Slider _slider;
    [SerializeField] GameObject _gameOverPanel;
    public bool _dead = false;
    
    public void Health()
    {
        _slider.value -= 2;
        if (_slider.value <0.1)
        {
            _gameOverPanel.SetActive(true);
            Time.timeScale = 0;

        }
    }
    
    public void Health2()
    {
        _slider.value -= 5;
        if (_slider.value < 0.1)
        {
            _gameOverPanel.SetActive(true);
            Time.timeScale = 0;

        }
    }
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        _slider.maxValue = 100;
        _slider.value = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
