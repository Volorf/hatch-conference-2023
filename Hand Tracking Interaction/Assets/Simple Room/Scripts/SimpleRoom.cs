using UnityEngine;

namespace Volorf.SimpleVRRoom
{
    public class SimpleRoom : MonoBehaviour
    {
        enum Theme
        {
            Dark,
            Light
        }

        [SerializeField] Theme currentTheme = Theme.Dark;
        [SerializeField] Color darkBG;
        [SerializeField] Color lightBG;

        [SerializeField] Material[] darkMaterials = new Material[5];
        [SerializeField] Material[] lightMaterials = new Material[5];
        [SerializeField] MeshRenderer roomRenderer;

        void OnValidate()
        {
            SetColors();
        }

        void Start()
        {
            SetColors();
        }

        void SetColors()
        {
            bool isDark = currentTheme == Theme.Dark;
        
            if (Camera.main)
            {
                Camera.main.backgroundColor = isDark ? darkBG : lightBG;
            }
        
            roomRenderer.materials = isDark ? darkMaterials : lightMaterials;
        }
    }
}

