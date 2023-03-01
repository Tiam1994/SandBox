using UnityEngine;

namespace SandBox.Hydrogen
{
	public class Windmill : MonoBehaviour
	{
		[SerializeField] private Transform _blades;

		private float _speed = 100f;

		private void Update() => RotationBlades();

		private void RotationBlades()
		{
			_blades.Rotate(0, 0, _speed * Time.deltaTime);
		}
	}
}
