using Nancy;
using System;
using System.Collections.Generic;
using ChangeCount.Objects;

namespace ChangeCount
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get ["/"] = _ =>{
        return View["index.cshtml"];
      };
      Post ["/results"] = _ =>{
        CoinMachine newMachine = new CoinMachine(Int32.Parse(Request.Form["number"]));
        newMachine.CountCoins();
        return View["index.cshtml", newMachine];
      };
    }
  }
}
