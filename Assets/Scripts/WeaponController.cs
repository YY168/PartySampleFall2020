using UnityEngine;

public class WeaponController : MonoBehaviour {

	[Header("Settings")]
	public int damage;
	public float bulletSpeed;
	public float fireInterval = .5f;
	public string damageTag = "Enemy";

	[Header("Configurations")]
	public Transform fireOrigin;
	public GameObject bulletPrototype;

	[Header("Status (Do not modify these fields through Editor)")]
	public float lastFireTime;

	public void Trigger() {
		if (CanFire()) {
			Fire();
		}
	}

	public bool CanFire() {
		var time = Time.time;
		return lastFireTime + fireInterval <= time;
	}

	private void Fire() {
		lastFireTime = Time.time;
		var bullet = Instantiate(bulletPrototype, fireOrigin ? fireOrigin.position : transform.position, transform.rotation);
		var controller = bullet.GetComponent<BulletController>();
		controller.damage = damage;
		controller.damageTag = damageTag;
		var velocity = bullet.transform.up * bulletSpeed;
		controller.GetComponent<Rigidbody2D>().velocity = velocity;
	}
}
