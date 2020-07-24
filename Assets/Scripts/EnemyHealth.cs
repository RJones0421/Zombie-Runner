using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    [SerializeField] float hitPoints = 100f;

    public void TakeDamage(float weaponDamage)
    {
        hitPoints -= weaponDamage;
        GetComponentInParent<EnemyAI>().OnDamageTaken();
        if (hitPoints <= 0)
        {
            Destroy(gameObject);
        }
    }

}
