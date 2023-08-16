using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject Prefab;
    [SerializeField] private GameObject SpawnPosition;
    [SerializeField] private float Delay;

    void Start()
    {
        Invoke("SpawnEnemy", Delay);
    }

    void SpawnEnemy()
    {
        Instantiate(Prefab, new Vector2(Random.Range(-10f,10f), SpawnPosition.transform.position.y), transform.rotation);
        Invoke("SpawnEnemy", Delay);
    }
}
