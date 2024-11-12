using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpAmmo : MonoBehaviour
{
    public int ammoUp;
    public MeshRenderer meshRenderer;
    public Collider objectCollider;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        objectCollider = GetComponent<Collider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        PlayerRPG player = other.GetComponent<PlayerRPG>();

        if (player != null)
        {
            player.RangedAmmo += ammoUp;
            Debug.Log($"New Ammo: {player.RangedAmmo}");
            Debug.Log("More AMMO! WOOT!");
            meshRenderer.enabled = false;
            objectCollider.enabled = false;
            StartCoroutine(UPRespawn());

        }
    }
    public IEnumerator UPRespawn()
    {


        yield return new WaitForSeconds(4); //waits a few seconds
        meshRenderer.enabled = true;
        objectCollider.enabled = true;
        Debug.Log("Ammo Respawned");
    }
}
