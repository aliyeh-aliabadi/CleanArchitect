using CleanArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Interfaces
{
    //Our IProductService needs to talk to or domain or backend in order to get our core model or core entity
    // and then map it back to our course view model and then presend it to the MVC project
    public interface IProductService
    {
        IEnumerable<ProductViewModel> GetProducts();  

    }
}
