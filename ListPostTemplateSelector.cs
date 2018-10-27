using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using LemmaApp.Models;
namespace LemmaApp.Models
{
    public class ListPostTemplateSelector : DataTemplateSelector
    {
        public int idFamilly = 1;
        public DataTemplate FromTemplate { get; set; }
        public DataTemplate ToTemplate { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((Publication)item).var.Equals(idFamilly) ? FromTemplate : ToTemplate;
        }
    }
}
