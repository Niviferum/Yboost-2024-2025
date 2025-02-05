using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class UIMainScript : MonoBehaviour
{
    UnityEngine.UI.Slider healthBar;
    RawImage weaponCooldown;
    void Start()
    {
        healthBar = transform.Find("StatusPanel").transform.Find("LifeBackground").GetComponent<UnityEngine.UI.Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
