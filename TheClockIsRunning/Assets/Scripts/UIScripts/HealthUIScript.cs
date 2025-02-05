using UnityEngine;
using UnityEngine.UI;

public class HealthUIScript : MonoBehaviour
{
    private Slider healthSlider;
    private HealthManager healthManager;

    private void Start()
    {
        healthSlider = GetComponent<Slider>();
        healthManager = GameObject.Find("Player").GetComponent<HealthManager>();
    }

    public void ChangeHealth()
    {
        healthSlider.value = healthManager.Health;
    }
}
