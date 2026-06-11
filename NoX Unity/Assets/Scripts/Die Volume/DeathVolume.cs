using UnityEngine;

public class DeathVolume : MonoBehaviour
{
    public void Start()
    {
        if (GameManager.instance != null)
        {
            GameManager.instance.deathVolumeList.Add(this);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Death otherDeathComponent = collision.GetComponent<Death>();

        if (otherDeathComponent != null)
        {
            otherDeathComponent.Die();
            Destroy(gameObject);
        }
    }
}
