using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SmartMovingMobileApp.Models
{
    public class Section
    {
        public string Name { get; set; }//Nome do setor
        public double AmountOfVisits { get; set; } //Quantidade de visitas no setor
        public string SectionIconPath { get; set; } //Ícone do setor, vem da API
    }
}
