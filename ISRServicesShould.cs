using ISRCalculator.Core.Entities;
using ISRCalculator.Core.Enums;
using ISRCalculator.Core.Services;

namespace ISRCalculator.Tests;

public class ISRServicesShould
{
    [Fact]
    public void ProcessISR_WhenMorethan0_01_andLess7735_00ReturnsTypeLimite1(){

        //arrange
        var expectedType = ISRType.Limite1;
        var user = new User {Salary = 148.51f};
        var sut = new ISRService();
        //act
        var result = sut.ProcessISR(user);
        //assert
        Assert.Equal(expectedType, result.ISRType);
    }
    
    [Fact]
    public void ProcessISR_WhenMorethan7735_01_andLess65651_07ReturnsTypeLimite2(){

        //arrange
        var expectedType = ISRType.Limite2;
        var user = new User {Salary = 8500.52f};
        var sut = new ISRService();
        //act
        var result = sut.ProcessISR(user);
        //assert
        Assert.Equal(expectedType, result.ISRType);
    }
    
    [Fact]
    public void ProcessISR_WhenMorethan65651_08_andLess115375_90ReturnsTypeLimite3(){

        //arrange
        var expectedType = ISRType.Limite3;
        var user = new User {Salary = 70500.25f};
        var sut = new ISRService();
        //act
        var result = sut.ProcessISR(user);
        //assert
        Assert.Equal(expectedType, result.ISRType);
    }
    
    [Fact]
    public void ProcessISR_WhenMorethan115375_91_andLess134119_41ReturnsTypeLimite4(){

        //arrange
        var expectedType = ISRType.Limite4;
        var user = new User {Salary = 120987.10f};
        var sut = new ISRService();
        //act
        var result = sut.ProcessISR(user);
        //assert
        Assert.Equal(expectedType, result.ISRType);
    }
    
    [Fact]
    public void ProcessISR_WhenMorethan134119_42_andLess160577_65ReturnsTypeLimite5(){

        //arrange
        var expectedType = ISRType.Limite5;
        var user = new User {Salary = 150200.66f};
        var sut = new ISRService();
        //act
        var result = sut.ProcessISR(user);
        //assert
        Assert.Equal(expectedType, result.ISRType);
    }
    
    [Fact]
    public void ProcessISR_WhenMorethan160577_66_andLess323862_00ReturnsTypeLimite6(){

        //arrange
        var expectedType = ISRType.Limite6;
        var user = new User {Salary = 269800.55f};
        var sut = new ISRService();
        //act
        var result = sut.ProcessISR(user);
        //assert
        Assert.Equal(expectedType, result.ISRType);
    }
    
    [Fact]
    public void ProcessISR_WhenMorethan323862_01_andLess510451_00ReturnsTypeLimite7(){

        //arrange
        var expectedType = ISRType.Limite7;
        var user = new User {Salary = 333555.44f};
        var sut = new ISRService();
        //act
        var result = sut.ProcessISR(user);
        //assert
        Assert.Equal(expectedType, result.ISRType);
    }
    
    [Fact]
    public void ProcessISR_WhenMorethan510451_01_andLess974535_03ReturnsTypeLimite8(){

        //arrange
        var expectedType = ISRType.Limite8;
        var user = new User {Salary = 520341.11f};
        var sut = new ISRService();
        //act
        var result = sut.ProcessISR(user);
        //assert
        Assert.Equal(expectedType, result.ISRType);
    }
    
    [Fact]
    public void ProcessISR_WhenMorethan974535_04_andLess1299380_04ReturnsTypeLimite9(){

        //arrange
        var expectedType = ISRType.Limite9;
        var user = new User {Salary = 980233.05f};
        var sut = new ISRService();
        //act
        var result = sut.ProcessISR(user);
        //assert
        Assert.Equal(expectedType, result.ISRType);
    }
    
    [Fact]
    public void ProcessISR_WhenMorethan1299380_05_andLess3898140_12ReturnsTypeLimite10(){

        //arrange
        var expectedType = ISRType.Limite10;
        var user = new User {Salary = 1300650.02f};
        var sut = new ISRService();
        //act
        var result = sut.ProcessISR(user);
        //assert
        Assert.Equal(expectedType, result.ISRType);
    }
    
    [Fact]
    public void ProcessISR_WhenMorethan3898140_13ReturnsTypeLimite11(){

        //arrange
        var expectedType = ISRType.Limite11;
        var user = new User {Salary = 4530987.12f};
        var sut = new ISRService();
        //act
        var result = sut.ProcessISR(user);
        //assert
        Assert.Equal(expectedType, result.ISRType);
    }
}
