﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleMvcUserManagement
{
  public class MyJsonResult
  {

    private MyJsonResult()
    {

    }

    public string message { get; set; }
    public bool isSuccess { get; set; }

    public object data { get; set; }

    internal static MyJsonResult CreateSuccess(string message)
    {
      return new MyJsonResult()
      {
        message = message,
        isSuccess = true
      };
    }

    internal static MyJsonResult CreateError(string message)
    {
      return new MyJsonResult()
      {
        message = message,
        isSuccess = false
      };
    }
  }
}