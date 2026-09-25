using System.ComponentModel.Design.Serialization;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private int currentHealth = 100;
    [SerializeField] private int minHealth = 0;


    //GETTERS Y SETTERS VARIABLES PRIVADES
    public int GetCurrentHealth()
    {
        return currentHealth;
    }

    public void SetCurrentHealth(int newHealth)
    {
        this.currentHealth = newHealth;
    }

    public int GetMaxHealth()
    {
        return maxHealth;
    }

    public void SetMaxHealth(int newMaxHealth)
    {
        this.maxHealth = newMaxHealth;
    }

    public int GetMinHealth()
    {
        return minHealth;
    }

    public void SetMinHealth(int newMinHealth)
    {
        this.minHealth = newMinHealth;
    }



    //MÈTODES ATAC, CURA, MATAR I REVIURE
    public void Attack(int damage)
    {
        currentHealth -= damage;

        if (GetCurrentHealth() <= 0) { currentHealth = 0; }

        Debug.Log(GetCurrentHealth());

    }

    public void Heal(int heal)
    {
        if(GetCurrentHealth() > 0 && GetCurrentHealth() < GetMaxHealth()) { currentHealth += heal; }

        Debug.Log(GetCurrentHealth());
    }

    public void Kill()
    {
        if (GetCurrentHealth() > 0) 
        { 
            currentHealth = GetMinHealth();

        } 
        else { Debug.Log("Inutilizable"); }

        Debug.Log(GetCurrentHealth());
    }

    public void Revive(int totalHeal)
    {
        if (GetCurrentHealth() == 0)
        {
            currentHealth += totalHeal;
        }
    }

    public bool IsAlive()
    {
        return currentHealth > minHealth;
    }

    public bool IsDead()
    {
        return currentHealth == minHealth;
    }


}
