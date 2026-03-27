using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject enemyPrefab;

    void Start()
    {
        InvokeRepeating(nameof(RandomSpawn), 0, 5);

        StartCoroutine(Hello());
        StartCoroutine(Goodbye());
    }
    void RandomSpawn()
    {
        var index = Random.Range(0, spawnPoints.Length);
        var spawnPoint = spawnPoints[index];
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
    }
    IEnumerator Goodbye()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            Debug.Log("Bye" + " " + Time.frameCount);
        }
    }
    IEnumerator Hello()
    {
        Debug.Log("Hello" + Time.frameCount);
        yield return null;
    }

}
