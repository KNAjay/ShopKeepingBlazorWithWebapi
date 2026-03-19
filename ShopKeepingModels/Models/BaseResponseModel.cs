using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopKeepingModels.Models
{
    public class BaseResponseModel
    {
        public Boolean Success { get; set; }
        public string ErrorMessage { get; set; }
        public object Data { get; set; }
    }
}
