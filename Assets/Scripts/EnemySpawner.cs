using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject [] _enemy;
    int _randomIndex;
    float _randomSpawnTime;
    [SerializeField] float _minDeger,_maxDeger;
    [SerializeField] Transform _spawnTransform;
    float _currentTime;
    

    void InstatiateEnemy()
    {
        if (_currentTime>_randomSpawnTime)
        {
            _randomIndex = Random.Range(0,_enemy.Length);
            Instantiate(_enemy[_randomIndex], _spawnTransform.position, _spawnTransform.rotation);
            _currentTime = 0;
            _randomSpawnTime = Random.Range(_minDeger, _maxDeger);
            _spawnTransform.position = new Vector3(Random.Range(5, 17), -10);
        }
    }


    private void FixedUpdate()
    {
        _currentTime += Time.deltaTime;
        InstatiateEnemy();
    }

    private void Start()
    {
        _randomSpawnTime = Random.Range(_minDeger, _maxDeger);
        _randomIndex = Random.Range(0, _enemy.Length);
        _spawnTransform.position = new Vector3(Random.Range(5, 17), -10);

    }
}
