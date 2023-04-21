using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDamager : MonoBehaviour
{
	public LayerMask HitLayers;
	public float MaxDistance;
	public GameObject Direction;
	public GameObject Origin;

	public int Damage;
	public void MeleeAttack() {
		Ray _ray = new Ray();
		_ray.direction = Direction.transform.forward;
		_ray.origin = Origin.transform.position;
		Debug.DrawLine(_ray.origin, _ray.origin + (_ray.direction * MaxDistance), Color.green, 2f);
		if (Physics.Raycast(_ray.origin, _ray.direction, out RaycastHit _hit, MaxDistance, HitLayers, QueryTriggerInteraction.Ignore)) {
			IAttribute _attribute = _hit.collider.gameObject.GetComponent<IAttribute>();
			if (_attribute) {
				//Debug.Log("Dealing damage!");
				_attribute.Damage(Damage);
			}
		}
	}
}
