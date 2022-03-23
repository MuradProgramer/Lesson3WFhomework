using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3WFhomework.Views
{
    public interface IMainView
    {
        EventHandler<EventArgs> FormLoadEventHandler { get; set; }

        // Gas Station
        EventHandler<EventArgs> CmbGasolineSelectedIndexChangedEventHandler { get; set; }
        EventHandler<EventArgs> RbQuantityCheckedChangedEventHandler { get; set; }
        EventHandler<EventArgs> RbPriceCheckedChangedEventHandler { get; set; }
        EventHandler<EventArgs> TxtbQuantityTextChangedEventHandler { get; set; }
        EventHandler<EventArgs> TxtbPriceTextChangedEventHandler { get; set; }

        // Mini-Cafe
        EventHandler<EventArgs> TxtbCountTextChangedEventHandler { get; set; }
        EventHandler<EventArgs> CkbCheckedChangedEventHandler { get; set; }
        EventHandler<EventArgs> BtnCalculateClickEventHandler { get; set; }
        EventHandler<EventArgs> BtnPayClickEventHandler { get; set; }

        

        string LitrText { get; set; }

        string GasolinePriceText { get; set; }

        string ManatText { get; set; }

        string CountHotDogText { get; set; }

        string CountHamburgerText { get; set; }

        string CountColaText { get; set; }

        string CountPropertyText { get; set; }

        string Pay1Text { get; set; }

        string Pay2Text { get; set; }

        string PayFinalText { get; set; }

        string CmbbGasolineText { get; set; }

        bool RbQuantityChecked { get; set; }

        bool RbPriceChecked { get; set; }

        bool HotDogCountEnabled { get; set; }
        bool HambCountEnabled { get; set; }
        bool PttCountEnabled { get; set; }
        bool ColaCountEnabled { get; set; }

        bool CkbHotDogChecked { get; set; }
        bool CkbHambChecked { get; set; }
        bool CkbPttChecked { get; set; }
        bool CkbColChecked { get; set; }
    }
}
