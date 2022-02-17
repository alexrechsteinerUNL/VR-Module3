using UnityEngine;
//adapted from https://thehardestwork.com/2020/12/10/how-to-build-a-spawner-in-unity/
public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public GameObject parent;
    public int numberToSpawn;
    public int limit = 20;
    public float rate;

    float spawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = rate;
    }

    // Update is called once per frame
    void Update()
    {
        if (parent.transform.childCount < limit)
        {
            spawnTimer -= Time.deltaTime;
            if (spawnTimer <= 0f)
            {
                for (int i = 0; i < numberToSpawn; i++)
                {
                    Instantiate(objectToSpawn, new Vector3(this.transform.position.x + GetModifier(), this.transform.position.y + GetModifier())
                        , Quaternion.identity, parent.transform);
                }
                spawnTimer = rate;
            }
        }
    }

    float GetModifier()
    {
        float modifier = Random.Range(0f, 50f);
        if (Random.Range(0, 50) > 0)
            return -modifier;
        else
            return modifier;
    }
}