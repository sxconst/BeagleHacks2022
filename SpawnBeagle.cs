using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBeagle : MonoBehaviour
{
    public GameObject[] spawnLocations;
    public GameObject beagle;
    public static float beagleRespawnTime = 1f;
    public static int currentBeagles;

    private void Awake()
    {
        spawnLocations = GameObject.FindGameObjectsWithTag("SpawnPoint");
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(deployBeagles());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void deployABeagle()
    {
        int spawn = Random.Range(0, spawnLocations.Length);
        GameObject a = Instantiate(beagle) as GameObject;
        a.transform.position = new Vector2(spawnLocations[spawn].transform.position.x, spawnLocations[spawn].transform.position.y);
        currentBeagles++;
    }

    IEnumerator deployBeagles()
    {
        while (currentBeagles < 20)
        {
            yield return new WaitForSeconds(beagleRespawnTime);
            deployABeagle();
        }
    }
}
