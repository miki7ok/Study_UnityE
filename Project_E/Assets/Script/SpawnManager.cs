using UnityEditor.UI;
using UnityEngine;

public class SpawnManager: MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject targetPrefab;
    public void SpawnTarget()
    {
        Instantiate(targetPrefab, this.transform.position, this.transform.rotation);
    }
}
