using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HealthScripts : NetworkBehaviour
{
    [SerializeField] private int maxHealth = 100;
     

    [SyncVar]
    private int currentHealth;

    public delegate void HealthChangedDelegate(int currentHealth, int maxHealth);

    public event HealthChangedDelegate EventHealthChanged;

    #region Server

    private void SetHealth(int value)
    {

        currentHealth = value;
        EventHealthChanged?.Invoke(currentHealth, maxHealth);

    }

    public override void OnStartServer()
    {

        SetHealth(maxHealth);

    }

    [Command]
    public void CmdDamage(int damagePerHit)
    {
        SetHealth(Mathf.Max(currentHealth - damagePerHit, 0));
    }

    #endregion


    #region Client

    [ClientCallback]
    private void Update() 
    {
        if (hasAuthority && Input.GetKey(KeyCode.I))
        {
            CmdDamage(2);
        }
    }
    #endregion
}
