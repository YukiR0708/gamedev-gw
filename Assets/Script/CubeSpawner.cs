using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] GameObject _cube;
    [SerializeField] Vector3 _offset = new Vector3(0, 0, 5.0f);
    Transform _spawnPos = default;

    private void Awake()
    {
        _spawnPos = this.transform;

    }
    private void Start()
    {
        while (_spawnPos.position.z < 50)
        {
            Instantiate(_cube, _spawnPos.position, _spawnPos.rotation);
            _spawnPos.position += _offset;
        }
    }

}





