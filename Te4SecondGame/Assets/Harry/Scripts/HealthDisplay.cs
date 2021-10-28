using Mirror;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : NetworkBehaviour
{
    [SerializeField] private HealthScripts health = null;
    [SerializeField] private Image healthBarImage = null;
    [SerializeField] private Image healthBarImagetwo = null;

    private void OnEnable()
    {
        health.EventHealthChanged += HandleHealthChanged;
    }

    private void OnDisable()
    {
        health.EventHealthChanged -= HandleHealthChanged;
    }

    [ClientRpc]
    private void HandleHealthChanged(int currentHealth, int maxHealth)
    {
        healthBarImage.fillAmount = (float)currentHealth/(float)maxHealth;
        healthBarImagetwo.fillAmount = (float)currentHealth / (float)maxHealth;
    }
}
