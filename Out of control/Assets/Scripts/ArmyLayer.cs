using UnityEngine;

public class ArmyLayer : MonoBehaviour
{
    void ChangeLayer()
    {
        if(Random.value < 0.5f)
        {
            GetComponent<SpriteRenderer>().sortingLayerID = SortingLayer.GetLayerValueFromID(1);
        }
        else
        {
            GetComponent<SpriteRenderer>().sortingLayerID = SortingLayer.GetLayerValueFromID(3);
        }
        
    }
}
