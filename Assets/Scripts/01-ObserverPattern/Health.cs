using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100f;
    [SerializeField] private float drainPerSecond = 2f;

    private float currentHealth = 0;

    private void Awake()
    {
        ResetHealth(); // Initiallize HP
        StartCoroutine(DrainHealth());
    }

    private void OnEnable()
    {
        GetComponent<Level>().onLevelUpAction += ResetHealth;
    }
    private void OnDisable()
    {
        GetComponent<Level>().onLevelUpAction -= ResetHealth;
    }

    private void ResetHealth()
    {
        currentHealth = maxHealth;
    }    
    private IEnumerator DrainHealth()
    {
        while (currentHealth > 0)
        {
            currentHealth -= drainPerSecond;
            yield return new WaitForSeconds(1); 
        }
    }

    public float GetHealth()
    {
        return currentHealth;
    }
}
