using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using BusinessObject;
using DataAccess;

namespace Businesslogic
{
    public class PreferencesBL
    {
        public void SetColorBL()
        {
            PreferencesDA objPreferencesDA = new PreferencesDA();
            string[] color = new string[3]{"","",""};
            color = objPreferencesDA.SetColorDA();
            for (int i = 0; i < 3; i++) 
            {
                switch(color[i])
                {
                    case "Aqua":
                        if(i == 0)
                        {
                            PreferencesBO.Empty = Color.Aqua;
                            PreferencesBO.EmptyColor = "Aqua      ";
                        }
                        if(i == 1)
                        {
                            PreferencesBO.Normal = Color.Aqua;
                            PreferencesBO.NormalColor = "Aqua      ";
                        }
                        if(i == 2)
                        {
                            PreferencesBO.Low = Color.Aqua;
                            PreferencesBO.LowColor = "Aqua      ";
                        }
                        break;
                    case "Mavi":
                        if(i == 0)
                        {
                            PreferencesBO.Empty = Color.LightBlue;
                            PreferencesBO.EmptyColor = "Mavi      ";
                        }
                        if(i == 1)
                        {
                            PreferencesBO.Normal = Color.LightBlue;
                            PreferencesBO.NormalColor = "Mavi      ";
                        }
                        if(i == 2)
                        {
                            PreferencesBO.Low = Color.LightBlue;
                            PreferencesBO.LowColor = "Mavi      ";
                        }
                        break;
                    case "Ciyan":
                        if(i == 0)
                        {
                            PreferencesBO.Empty = Color.Cyan;
                            PreferencesBO.EmptyColor = "Ciyan     ";
                        }
                        if(i == 1)
                        {
                            PreferencesBO.Normal = Color.Cyan;
                            PreferencesBO.NormalColor = "Ciyan     ";
                        }
                        if(i == 2)
                        {
                            PreferencesBO.Low = Color.Cyan;
                            PreferencesBO.LowColor = "Ciyan     ";
                        }
                        break;
                    case "Fuşya":
                        if(i == 0)
                        {
                            PreferencesBO.Empty = Color.Fuchsia;
                            PreferencesBO.EmptyColor = "Fuşya     ";
                        }
                        if(i == 1)
                        {
                            PreferencesBO.Normal = Color.Fuchsia;
                            PreferencesBO.NormalColor = "Fuşya     ";
                        }
                        if(i == 2)
                        {
                            PreferencesBO.Low = Color.Fuchsia;
                            PreferencesBO.LowColor = "Fuşya     ";
                        }
                        break;
                    case "Altın":
                        if(i == 0)
                        {
                            PreferencesBO.Empty = Color.Gold;
                            PreferencesBO.EmptyColor = "Altın     ";
                        }
                        if(i == 1)
                        {
                            PreferencesBO.Normal = Color.Gold;
                            PreferencesBO.NormalColor = "Altın     ";
                        }
                        if(i == 2)
                        {
                            PreferencesBO.Low = Color.Gold;
                            PreferencesBO.LowColor = "Altın     ";
                        }
                        break;
                    case "Gri":
                        if(i == 0)
                        {
                            PreferencesBO.Empty = Color.Gray;
                            PreferencesBO.EmptyColor = "Gri       ";
                        }
                        if(i == 1)
                        {
                            PreferencesBO.Normal = Color.Gray;
                            PreferencesBO.NormalColor = "Gri       ";
                        }
                        if(i == 2)
                        {
                            PreferencesBO.Low = Color.Gray;
                            PreferencesBO.LowColor = "Gri       ";
                        }
                        break;
                    case "Yeşil":
                        if(i == 0)
                        {
                            PreferencesBO.Empty = Color.Green;
                            PreferencesBO.EmptyColor = "Yeşil     ";
                        }
                        if(i == 1)
                        {
                            PreferencesBO.Normal = Color.Green;
                            PreferencesBO.NormalColor = "Yeşil     ";
                        }
                        if(i == 2)
                        {
                            PreferencesBO.Low = Color.Green;
                            PreferencesBO.LowColor = "Yeşil     ";
                        }
                        break;
                    case "Turuncu":
                        if(i == 0)
                        {
                            PreferencesBO.Empty = Color.Orange;
                            PreferencesBO.EmptyColor = "Turuncu   ";
                        }
                        if(i == 1)
                        {
                            PreferencesBO.Normal = Color.Orange;
                            PreferencesBO.NormalColor = "Turuncu   ";
                        }
                        if(i == 2)
                        {
                            PreferencesBO.Low = Color.Orange;
                            PreferencesBO.LowColor = "Turuncu   ";
                        }
                        break;
                    case "Pembe":
                        if(i == 0)
                        {
                            PreferencesBO.Empty = Color.Pink;
                            PreferencesBO.EmptyColor = "Pembe     ";
                        }
                        if(i == 1)
                        {
                            PreferencesBO.Normal = Color.Pink;
                            PreferencesBO.NormalColor = "Pembe     ";
                        }
                        if(i == 2)
                        {
                            PreferencesBO.Low = Color.Pink;
                            PreferencesBO.LowColor = "Pembe     ";
                        }
                        break;
                    case "Kırmızı":
                        if(i == 0)
                        {
                            PreferencesBO.Empty = Color.Red;
                            PreferencesBO.EmptyColor = "Kırmızı   ";
                        }
                        if(i == 1)
                        {
                            PreferencesBO.Normal = Color.Red;
                            PreferencesBO.NormalColor = "Kırmızı   ";
                        }
                        if(i == 2)
                        {
                            PreferencesBO.Low = Color.Red;
                            PreferencesBO.LowColor = "Kırmızı   ";
                        }
                        break;
                    case "Beyaz":
                        if (i == 0)
                        {
                            PreferencesBO.Empty = Color.White;
                            PreferencesBO.EmptyColor = "Beyaz     ";
                        }
                        if (i == 1)
                        {
                            PreferencesBO.Normal = Color.White;
                            PreferencesBO.NormalColor = "Beyaz     ";
                        }
                        if (i == 2)
                        {
                            PreferencesBO.Low = Color.White;
                            PreferencesBO.LowColor = "Beyaz     ";
                        }
                        break;
                    case "Sarı":
                        if (i == 0)
                        {
                            PreferencesBO.Empty = Color.Yellow;
                            PreferencesBO.EmptyColor = "Sarı      ";
                        }
                        if (i == 1)
                        {
                            PreferencesBO.Normal = Color.Yellow;
                            PreferencesBO.NormalColor = "Sarı      ";
                        }
                        if (i == 2)
                        {
                            PreferencesBO.Low = Color.Yellow;
                            PreferencesBO.LowColor = "Sarı      ";
                        }
                        break;
                }
            }
        }

        public void SetLimitBL()
        {
            PreferencesDA objPreferencesDA = new PreferencesDA();
            PreferencesBO.Limit = objPreferencesDA.SetLimitDA();
        }

        public void ChangeColorBL() 
        {
            PreferencesDA objPreferencesDA = new PreferencesDA();
            objPreferencesDA.ChangeColorDA();
        }

        public void ChangeLimitBL() 
        {
            PreferencesDA objPreferencesDA = new PreferencesDA();
            objPreferencesDA.ChangeLimitDA();
        }
    }
}
