using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Transform levelPart_1;
    private void Awake()
    {
        SpawnLevelPart(new Vector3(1, 2));
        SpawnLevelPart(new Vector3(1, 2) + new Vector3(3, 1));
        SpawnLevelPart(new Vector3(3, 2) + new Vector3(3+2, 1));
    }
    private void SpawnLevelPart(Vector3 spawnPosition)
    {
        Instantiate(levelPart_1, spawnPosition, Quaternion.identity);
    }
}
