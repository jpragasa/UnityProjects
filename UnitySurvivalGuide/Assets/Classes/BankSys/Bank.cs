using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Bank
{
    protected string branchName;
    protected string location;
    protected float cashInVault;

    public void CheckBalance()
    {
        Debug.Log("Checking Balance at " + this.branchName);
    }

    public void Withdraw()
    {
        Debug.Log("Withdrawing from " + this.branchName);
    }

    public void Deposit()
    {
        Debug.Log("Depositing to " + this.branchName);
    }
}
