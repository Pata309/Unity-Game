using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class PlayerController : MonoBehaviour
{
    public float totalLife = 30.0f;
    public Slider healthBar;
    // Use this for initialization
    void Start()
    {
        // Određivanje maksimalnog broja na slider elementu
        healthBar.maxValue = totalLife;
        // Određivanje trenutnog broja na slider elementu
        healthBar.value = totalLife;
    }
    void OnTriggerEnter(Collider other)
    {
        // Provjera da li je preostalo života
        if (totalLife > 0)
        {
            // Ako je, preostali život se smanjuje
            totalLife = totalLife - 10.0f;
            // Određivanje trenutnog broja na slider elementu
            healthBar.value = totalLife;
        }
    }
}