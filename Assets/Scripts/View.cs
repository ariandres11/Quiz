using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

namespace GDV_UI
{
    public class View : CustomUIComponent
    {
        public ViewSO viewData;

        public GameObject containerTop;
        public GameObject containerCenter;
        public GameObject containerBottom;

        //referencias a las imagenes de cada container
        private Image imageTop;

        private Image imageCenter;

        private Image imageBottom;

        private VerticalLayoutGroup verticalLayoutGroup;

        
        public override void Setup(){
            verticalLayoutGroup = GetComponent<VerticalLayoutGroup>();
            imageTop = containerTop.GetComponent<Image>();
            imageCenter = containerCenter.GetComponent<Image>();
            imageBottom = containerBottom.GetComponent<Image>();

        }
        public override void Configure(){
            verticalLayoutGroup.padding = viewData.padding;
            verticalLayoutGroup.spacing = viewData.spacing;
            //coloca el color que se le diga desde el theme
            imageTop.color = viewData.theme.primary_bg;
            imageCenter.color = viewData.theme.secondary;
            imageBottom.color = viewData.theme.primary_bg;
        } 
        



    }
}


