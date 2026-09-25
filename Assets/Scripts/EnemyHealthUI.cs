using System;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthUI : MonoBehaviour
{
    [SerializeField] private EnemyHealth enemyHealth;
    [SerializeField] private Slider healthSlider;
    [SerializeField] private Image bowser;
    [SerializeField] private Button killButton;
    [SerializeField] private Button reviveButton;

    private void Start()
    {
        reviveButton.interactable = false;
    }

    public void ChangeLife()
    {
        healthSlider.maxValue = enemyHealth.GetMaxHealth();
        healthSlider.value = enemyHealth.GetCurrentHealth();
    }

    public void BowserDead()
    {
        if (enemyHealth.IsDead()) { bowser.enabled = false; }
        else { bowser.enabled = true; }
    }

    public void isInteractable() //Només canvio el interactable per que es vegi visualment que està deshabilitat
    {
        if (enemyHealth.IsDead())
        {
            killButton.interactable = false;
            reviveButton.interactable = true;
        }
        else
        {
            killButton.interactable = true;
            reviveButton.interactable = false;
        }
    }

}
