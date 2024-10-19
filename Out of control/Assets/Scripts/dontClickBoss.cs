using UnityEngine;

public class dontClickBoss : MonoBehaviour
{
    [SerializeField] GameObject boss;

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).gameObject.activeInHierarchy)
            {
                GameObject.FindGameObjectWithTag("Boss").GetComponent<PolygonCollider2D>().enabled = false;
            }
            else
            {
                boss.GetComponent<PolygonCollider2D>().enabled = true;
            }
        }
    }
}
