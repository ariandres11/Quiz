

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace GDV_UI
{
    public class CustomButton: CustomUIComponent
    {
        public ThemeSO theme;
        public Style style;
        public UnityEvent onClick;

        private Button button;
        private TextMeshProUGUI buttonText;

        public override void Setup(){
            /*En un futuro se le puede cambiar el nombre para evitar confusion*/
            button = GetComponentInChildren<Button>();
            buttonText = GetComponentInChildren<TextMeshProUGUI>();
        }

        public override void Configure(){
            
            /* Color block sirve para los botones porque deja elegir varios colores para cada accion con el boton.
            Ej) highligthed, pressed y disabled.*/
            ColorBlock cb = button.colors;

            //El color cuando no se interactua con el boton
            cb.normalColor = theme.GetBackgroundColor(style);
            button.colors = cb;

            buttonText.color = theme.GetTextColor(style);

        }

        public void OnClick(){
            onClick.Invoke();
        }

    }
}