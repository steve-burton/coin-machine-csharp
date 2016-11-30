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
    private int _total;
    private bool _canMakeChange = true;
    private bool _bankNotEmpty = true;

    static private int _bankQ = 4;
    static private int _bankD = 5;
    static private int _bankN = 8;
    static private int _bankP = 32;

    static private int _bankTotal = 222;

    public CoinMachine(int input)
    {
      _inputTotal = input;
      _total = input;
    }

    public void CountCoins()
    {
      //temporary banks to see if we have enough coins to make correct change
      int tBankQ = _bankQ;
      int tBankD = _bankD;
      int tBankN = _bankN;
      int tBankP = _bankP;

      while (_inputTotal > 24 && tBankQ > 0)
      {
        _quarters = _quarters + 1;
        tBankQ = tBankQ - 1;
        _inputTotal = _inputTotal - 25;
      }
      while (_inputTotal > 9 && tBankD > 0)
      {
        _dimes = _dimes + 1;
        tBankD = tBankD - 1;
        _inputTotal = _inputTotal - 10;
      }
      while (_inputTotal > 4 && tBankN > 0)
      {
        _nickels = _nickels + 1;
        tBankN = tBankN - 1;
        _inputTotal = _inputTotal - 5;
      }
      while (_inputTotal > 0 && tBankP > 0)
      {
        _pennies = _pennies + 1;
        tBankP = tBankP - 1;
        _inputTotal = _inputTotal - 1;
      }

      //if correct change can be made, subtract values from static banks
      if (_pennies + _nickels * 5 + _dimes * 10 + _quarters * 25 == _total)
      {
        _bankTotal = _bankTotal - _quarters * 25;
        _bankTotal = _bankTotal - _dimes * 10;
        _bankTotal = _bankTotal - _nickels * 5;
        _bankTotal = _bankTotal - _pennies;
        _bankQ = _bankQ - _quarters;
        _bankD = _bankD - _dimes;
        _bankN = _bankN - _nickels;
        _bankP = _bankP - _pennies;
      }
      else if (_bankTotal == 0)
      {
        _bankNotEmpty = false;
      }
      else
      {
        _canMakeChange = false;
      }
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
    public int GetTotal()
    {
      return _total;
    }
    public bool CanMakeChange()
    {
      return _canMakeChange;
    }
    public bool BankNotEmpty()
    {
      return _bankNotEmpty;
    }
  }
}
