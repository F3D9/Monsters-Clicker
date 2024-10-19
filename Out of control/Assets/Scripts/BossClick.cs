using UnityEngine;

public class BossClick : MonoBehaviour
{
    [SerializeField] GameObject Admin;
    [SerializeField] GameObject damageUI;
    

    Vector3 mouse = new Vector3();

    // Update is called once per frame
    void Update()
    {
        mouse = (Vector3)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse.z = 0;
    }

    private void OnMouseDown()
    {
        Admin.GetComponent<AdminManager>().Score += Admin.GetComponent<AdminManager>().ClickScore;
        Instantiate(damageUI,mouse,Quaternion.Euler(0,0,0));
        GetComponent<Animator>().SetBool("Damage",true);
        
        
    }
    

    void DamageFalse()
    {
        GetComponent<Animator>().SetBool("Damage", false);
    }

    
}
