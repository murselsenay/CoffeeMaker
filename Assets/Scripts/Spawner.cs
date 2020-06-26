using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject grainedBeans;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnGrainedBeans());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator spawnGrainedBeans()
    {
        while (true)
        {
            float offsetx = Random.Range(-0.5f, 0.5f);
            float offsetz = Random.Range(-0.5f, 0.5f);
            Instantiate(grainedBeans, new Vector3(transform.position.x + offsetx, transform.position.y, transform.position.z + offsetz), Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
        
    }
}
