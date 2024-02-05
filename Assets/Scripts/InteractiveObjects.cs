using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractiveObjects : MonoBehaviour
{
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

    private void Update()
    {
        if (triggerActive && Input.GetKeyDown(KeyCode.F))
        {
            collectedItems.text += gameObject.tag + " ";
            Destroy(gameObject);
        }
    }
}
