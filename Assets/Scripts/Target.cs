using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Target : MonoBehaviour
{
    private bool isDestroyed = false;

    public virtual bool ShouldDestroy()
    {
        return false;
    }

    public abstract void HandleImpact();

    public bool GetIsDestroyed()
    {
        return isDestroyed;
    }

    public void MarkAsDestroyed()
    {
        isDestroyed = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
