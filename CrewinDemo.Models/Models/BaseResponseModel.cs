using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrewinDemo.Models.Models;

public class BaseResponseModel
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public object Data { get; set; }

    public BaseResponseModel()
    {
        
    }

    public BaseResponseModel(bool success, string message)
    {
        Success = success;
        Message = message;
    }

    public BaseResponseModel(bool succes, object data)
    {
        Success = succes;
        Data = data;
    }

    public BaseResponseModel(bool success, string message, object data)
    {
        Success = success;
        Message = message;
        Data = data;
    }
}
