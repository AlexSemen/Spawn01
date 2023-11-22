using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spavner : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Enemy _enemy;
    [SerializeField] private bool _directionRight;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer.flipY = _directionRight;
    }

    public void SpamEnemy()
    {
        Enemy enemy = Instantiate(_enemy, _spawnPoint.position, Quaternion.identity);
        enemy.SetDirectionRight(_directionRight);
    }
}
