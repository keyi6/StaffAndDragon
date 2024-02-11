using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Game;

public class Enemy : MonoBehaviour
{
    public Image hp;

    public int maxHealth;
    private int currentHealth;

    [SerializeField] private bool triggerActive = false;

    public TextMeshProUGUI collectedItems;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            triggerActive = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            triggerActive = false;
        }
    }

    void Start()
    {
        currentHealth = maxHealth;
        hp.fillAmount = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (triggerActive && Input.GetKeyDown(KeyCode.F))
        {
            currentHealth -= Element.GetAttackValue();

            if (currentHealth <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                hp.fillAmount = (float)currentHealth / (float)maxHealth;
            }
        }
    }
}
