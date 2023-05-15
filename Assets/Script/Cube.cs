using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    ScoreManager _scoreM = default;

    private void Awake()
    {
        _scoreM = FindObjectOfType<ScoreManager>().GetComponent<ScoreManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _scoreM.AddScore();
            Destroy(gameObject);
        }
    }
}
