using UnityEngine;
using UnityEngine.UI;

public class RandomPartDrop : MonoBehaviour
{

    [SerializeField] Sprite part1, part2, part3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int nro = Random.Range(0, 3);

        switch (nro) 
        {
            case 0:
                GetComponent<Image>().sprite = part1; 
                break;
            case 1:
                GetComponent<Image>().sprite = part2;
                break;
            case 2:
                GetComponent<Image>().sprite = part3;
                break;

        }

    }

    
}
