using Xunit;
using System;
using System.Collections.Generic;
using ChangeCount.Objects;

namespace ChangeCount
{
  public class CoinMachineTest
  {
    [Fact]
    public void CountCoins_countPennies_true()
    {
      //Arrange
      int expectedPennies = 3;
      CoinMachine machine = new CoinMachine(3);
      //Act
      machine.CountCoins();
      int result = machine.GetPennies();
      //Assert
      Assert.Equal(result, expectedPennies);
    }

    [Fact]
    public void CountCoins_countNickels_true()
    {
      //Arrange
      int expectedNickles = 1;
      CoinMachine machine = new CoinMachine(5);
      //Act
      machine.CountCoins();
      int result = machine.GetNickels();
      //Assert
      Assert.Equal(result, expectedNickles);
    }

    [Fact]
    public void CountCoins_countDimes_true()
    {
      //Arrange
      int expectedDimes = 1;
      CoinMachine machine = new CoinMachine(12);
      //Act
      machine.CountCoins();
      int result = machine.GetDimes();
      //Assert
      Assert.Equal(result, expectedDimes);
    }

    [Fact]
    public void CountCoins_countQuarters_true()
    {
      //Arrange
      int expectedQuarters = 3;
      int expectedDimes = 1;
      int expectedNickels = 1;
      int expectedPennies = 1;
      CoinMachine machine = new CoinMachine(91);
      //Act
      machine.CountCoins();
      int resultQ = machine.GetQuarters();
      int resultD = machine.GetDimes();
      int resultN = machine.GetNickels();
      int resultP = machine.GetPennies();
      //Assert
      Assert.Equal(resultQ, expectedQuarters);
      Assert.Equal(resultD, expectedDimes);
      Assert.Equal(resultN, expectedNickels);
      Assert.Equal(resultP, expectedPennies);
    }
  }
}
