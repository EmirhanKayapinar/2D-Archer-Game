using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public int _score;
    [SerializeField] Text _scoreText;
    public void Score()
    {
        _score += 50;
    }

    public void Score2()
    {
        _score += 100;
    }
    private void FixedUpdate()
    {
        _scoreText.text = $"Score: {_score.ToString()}";
    }
}
