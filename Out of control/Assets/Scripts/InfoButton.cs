using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InfoButton : MonoBehaviour
{
    [SerializeField] GameObject infoGame;

    [Header("Info")]
    [SerializeField] bool square;
    [SerializeField] Sprite icon;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        infoGame.SetActive(false);
    }

    public void openInfoCanva(string text)
    {
        infoGame.SetActive(true);
        infoGame.transform.GetChild(0).GetChild(1).GetComponent<Image>().sprite = icon;
        if (square)
        {
            infoGame.transform.GetChild(0).GetChild(1).transform.localScale = new Vector3(0.4921822f, 0.1210637f, 0.3026667f);
        }
        else
        {
            infoGame.transform.GetChild(0).GetChild(1).transform.localScale = new Vector3(0.6208423f, 0.08789101f, 0.219733f);
        }

        infoGame.transform.GetChild(0).GetChild(2).GetComponent<TMP_Text>().text = text;

    }

    public void closeInfoCanva()
    {
        infoGame.SetActive(false);
    }
}
