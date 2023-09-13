using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



namespace GDV_UI{
    public class Text : MonoBehaviour
    {
        public TextSO textData;
        public Style style;
        private TextMeshProUGUI textMeshProUGUI;

        private void Awake (){
            Init();
        }
        private void Init(){
            Setup();
            Configure();
        }

        private void Setup(){
            textMeshProUGUI = GetComponentInChildren<TextMeshProUGUI>();
        }
        private void Configure (){
            //El color va a referenciar a style que contiene los colores definidos por le tema
            textMeshProUGUI.color = textData.theme.GetTextColor(style);
            textMeshProUGUI.font = textData.font;
            textMeshProUGUI.fontSize = textData.size;

        }
        void OnValidate(){
            Init();
        }

    }
}

