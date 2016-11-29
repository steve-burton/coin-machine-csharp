using System;
using System.Collections.Generic;

namespace ChangeCount.Objects
{
  public class CoinMachine
  {
    private int _quarters;
    private int _dimes;
    private int _nickels;
    private int _pennies;
    private int _inputTotal;

    public CoinMachine(int input)
    {
      _inputTotal = input;
    }

    public void CountCoins()
    {
      while (_inputTotal > 24)
      {
        _quarters = _quarters + 1;
        _inputTotal = _inputTotal - 25;
      }
      while (_inputTotal > 9)
      {
        _dimes = _dimes + 1;
        _inputTotal = _inputTotal - 10;
      }
      if (_inputTotal > 4)
      {
        _nickels = 1;
        _inputTotal = _inputTotal - 5;
      }
      _pennies = _inputTotal;
    }

    public int GetPennies()
    {
      return _pennies;
    }

    public int GetNickels()
    {
      return _nickels;
    }
    public int GetDimes()
    {
      return _dimes;
    }
    public int GetQuarters()
    {
      return _quarters;
    }
  }
}
