using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    bool _isGoal;
    Rigidbody _rb;
    [SerializeField] float _speed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!_isGoal)
        {
            _rb.velocity = transform.forward * _speed;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Goal")
        {
            _isGoal = true;
        }
    }
}
