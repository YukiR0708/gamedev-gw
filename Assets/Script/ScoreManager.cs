using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    int _nowScore = default;
    [SerializeField]int _getScore = default;
    [SerializeField] Text _scoreTxt = default;
    private void Update()
    {
        //スコア表示
        _scoreTxt.text = $"Score:{_nowScore}";
    }

    public void AddScore()
    {
        _nowScore += _getScore;
    }
}
