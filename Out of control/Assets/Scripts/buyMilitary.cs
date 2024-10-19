using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class buyMilitary : MonoBehaviour
{
    [SerializeField] GameObject admin;
    [SerializeField] AudioClip spawn;
    enum type
    {
        police,
        militar,
        aircraft,
        airfeighter,
        misil,
    }

    [SerializeField] type army;
    [SerializeField] float price;
    [SerializeField] TMP_Text priceText;
    [SerializeField] GameObject prefab;
    [SerializeField] GameObject rocketCanva;
    public void Add_Army_to_Admin()
    {
        if (admin.GetComponent<AdminManager>().Score >= price)
        {
            switch (army)
            {
                case type.police:
                    admin.GetComponent<AdminManager>().policeHelicopterNumber++;
                    admin.GetComponent<AdminManager>().conditionPoliceH -= 0.1f;
                    break;

                case type.militar:
                    admin.GetComponent<AdminManager>().militarHelicopterNumber++;
                    admin.GetComponent<AdminManager>().conditionMilitarH -= 0.1f;
                    break;

                case type.aircraft:
                    admin.GetComponent<AdminManager>().AirCraftNumber++;
                    admin.GetComponent<AdminManager>().conditionAirCraft -= 0.1f;
                    break;

                case type.airfeighter:
                    admin.GetComponent<AdminManager>().AirfeighterNumber++;
                    admin.GetComponent<AdminManager>().conditionAirfeighter -= 0.1f;
                    break;

                case type.misil:
                    admin.GetComponent<AdminManager>().MisilNumber++;
                    rocketCanva.SetActive(true);
                    break;

            }

            //Prefab
            float y = Random.Range(140,149);
            if(army != type.misil)
            {
                Instantiate(prefab, new Vector3(115, y, 0), Quaternion.Euler(0, 0, 0));
            }

            admin.GetComponent<AudioSource>().PlayOneShot(spawn);
            admin.GetComponent<AdminManager>().Score -= price;
            price *= 1.25f;
        }

        price = (int)price;

        priceText.text = "$" + price.ToString();
    }

    private void Update()
    {
        if (admin.GetComponent<AdminManager>().Score >= price)
        {
            transform.GetComponent<Image>().color = new Color32(64, 142, 86, 255);
        }
        else
        {
            transform.GetComponent<Image>().color = Color.gray;
        }
    }

    private void Start()
    {
       rocketCanva.SetActive(false);
    }

}
