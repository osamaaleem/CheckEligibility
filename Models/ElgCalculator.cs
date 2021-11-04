using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace WE_Asgn_2.Models
{
    public class ElgCalculator
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public string Qualification { get; set; }
        public int ObtainedMarks { get; set; }
        public int TotalMarks { get; set; }
        public string Province { get; set; }
        public List<SelectListItem> ProvinceList()
        {
            List<SelectListItem> provinceList = new List<SelectListItem>();
            provinceList.Add(new SelectListItem { Text = "Punjab", Value = "Punjab" });
            provinceList.Add(new SelectListItem { Text = "Sindh", Value = "Sindh" });
            provinceList.Add(new SelectListItem { Text = "KPK", Value = "KPK" });
            provinceList.Add(new SelectListItem { Text = "Baluchistan", Value = "Baluchistan" });
            return provinceList;
        }
        private int Percentage()
        {
            int percentage;
            percentage = (int)Math.Round((double)(ObtainedMarks * 100) / TotalMarks);
            return percentage;
        }
        public string IsEligible()
        {
            string province = Province.ToLower();
            switch (Qualification.ToUpper())
            {
                case "FSC":
                    if (province == "punjab" && Percentage() >= 70)
                    {
                        return "Yes";
                    }
                    else if (province != "punjab" && Percentage() >= 60)
                    {
                        return "Yes";
                    }
                    else
                    {
                        return "No";
                    }
                case "BCS":
                    if (province == "punjab" && Percentage() >= 60)
                    {
                        return "Yes";
                    }
                    else if (province != "punjab" && Percentage() >= 50)
                    {
                        return "Yes";
                    }
                    else
                    {
                        return "No";
                    }
                default:
                    return "Wrong Entry";
            }
        }
    }
}