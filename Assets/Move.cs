using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    bool _isGoal;
    public bool IsGoal { get => _isGoal; set => value = _isGoal; }
    Rigidbody _rb;
    [SerializeField] float _runSpeed = 0.0f;
    [SerializeField] float _moveSpeed = 0.0f;
    [SerializeField] Transform _floorTransform = default;
    Vector3 _defaultPos = default;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _defaultPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");

        if (!_isGoal)
        {
            //�����X�N���[��
            _rb.velocity = transform.forward * _runSpeed + Vector3.up * _rb.velocity.y;
            //���E�ړ�
            if(hInput != 0)
            {
                _rb.velocity += Vector3.right * hInput * _moveSpeed;
            }
        }

        //���������瓮���Ȃ����Ă��Ƃ̈ʒu�ɖ߂�
        if(transform.position.y < _floorTransform.position.y)
        {
            _isGoal = true;
            transform.position = _defaultPos;
            _isGoal = false;
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
