using System.Collections;
using UnityEngine;

public class SpawnOfBoxes : MonoBehaviour
{
    [SerializeField]
    private GameObject _box;
    [SerializeField]
    private float _timeBtwSpawn;

    void Start()
    {
        StartCoroutine(SpawnBox());
    }

    IEnumerator SpawnBox()
    {
        while (true)
        {
            Instantiate(_box, gameObject.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(_timeBtwSpawn);
        }
    }
}
