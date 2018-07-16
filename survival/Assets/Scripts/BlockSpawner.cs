using UnityEngine;

public class BlockSpawner : MonoBehaviour {

    public Transform player;
    public Transform[] spawnPoints;
    public GameObject blockPrefab;

    public int wavesSpawned = 0;

    void Update()
    {
        if(player.position.z >= wavesSpawned*75)
        {
            transform.position = new Vector3(0, 1, FindObjectOfType<PlayerMovement>().rb.position.z + 100);
            SpawnBlocks();
            wavesSpawned++;
        }       
    }

    void SpawnBlocks ()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
            }
        }
	}	
}