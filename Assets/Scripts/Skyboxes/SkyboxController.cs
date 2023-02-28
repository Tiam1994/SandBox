using UnityEngine;

namespace SandBox.Skyboxes
{
	public class SkyboxController : MonoBehaviour
	{
		private float _speed = 0.5f;
		private float _duration = 0f;

		private void Update() => UpdateSkybox();

		private void UpdateSkybox()
		{
			if (_duration >= 1)
			{
				return;
			}

			RenderSettings.skybox.SetFloat("_Blend", _duration);
			_duration += _speed * Time.deltaTime;
		}
	}
}
