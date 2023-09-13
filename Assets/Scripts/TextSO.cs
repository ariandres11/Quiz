using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace GDV_UI{
    [CreateAssetMenu(menuName = "CustomUI/TextSO", fileName = "Text")]
    public class TextSO : ScriptableObject
    {
        //referencio theme porque el color del texto depende del theme
        public ThemeSO theme;

        public TMP_FontAsset font;
        public float size;

    }

}
