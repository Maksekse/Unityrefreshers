using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;

    [SerializeField]
    private Vector3 spawnLocation;

    [SerializeField]
    private bool spawnOnStart;

    [Header("UI Config")]
    [SerializeField]
    private Button SpawnButton;

    private void Awake()
    {
    }
    private void Start()
    {
        if (spawnOnStart)
        {
            SpawnObject();
        }
        SpawnButton.onClick.AddListener(SpawnObject);
    }

    private void SpawnObject()
    {
        Instantiate(prefab, spawnLocation, Quaternion.identity);
    }
}
