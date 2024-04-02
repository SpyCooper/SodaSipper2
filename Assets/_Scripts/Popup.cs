using System.Collections;
using UnityEngine;

public class Popup : MonoBehaviour
{
    private float startingSize;
    private void Start() => StartCoroutine(Deletion());
    private IEnumerator Deletion()
    {
        startingSize = transform.localScale.x;
        for (int i = 0; i < 300; i++)
        {
            yield return new WaitForSeconds(0.010f);
            transform.localScale = startingSize * new Vector3((300f - i) / 300f, (300f - i) / 300f, (300f - i) / 300f);
        }
        Destroy(gameObject);
    }
    public void OnClick()
    {
        GameManager.Instance.AddSetAmt(1000);
        Destroy(gameObject);
    }
}