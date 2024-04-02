using System.Collections;
using UnityEngine;
public class PopupManager : MonoBehaviour
{
    [SerializeField] private Transform[] transforms;
    [SerializeField] private GameObject prefab;
    private void Awake() => Random.InitState(System.DateTime.Now.Second + System.DateTime.Now.Millisecond);
    private void Start() => StartCoroutine(Deletion());
    private IEnumerator Deletion()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(15, 120));
            Instantiate(prefab, transforms[Random.Range(0, transforms.Length)].position, Quaternion.identity, transform);
        }
    }
}