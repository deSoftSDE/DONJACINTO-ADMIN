using dsASPCAutoCAdmin.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dsASPCAutoCAdmin.ViewModels
{
    
    public class MenuViewModel
    {
        public List<ElementoMenu> menu;
        public MenuViewModel()
        {
            menu = new List<ElementoMenu>
            {
                new ElementoMenu { Key = "All", Value = "" },
                new ElementoMenu { Key = "California", Value = "California" },
                new ElementoMenu { Key = "Illinois", Value = "Illinois" },
                new ElementoMenu { Key = "Georgia", Value = "Georgia" },
                new ElementoMenu { Key = "Tomelloso", Value = "Tomelloso" },
                new ElementoMenu { Key = "Minnesota", Value = "Minnesota" }
            };
        }
    }
}
