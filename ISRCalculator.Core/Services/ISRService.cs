using ISRCalculator.Core.Entities;
using ISRCalculator.Core.Enums;
using ISRCalculator.Core.Services.Interfaces;
namespace ISRCalculator.Core.Services;

public class ISRService : IISRService
{
    
    public ISR ProcessISR (User user){
        var isr = new ISR();

        if(user.Salary >= 0.01f && user.Salary < 7735.00f){
          var ba = user.Salary - 0.01f;
          var re = ba * (1.92f/100);
          isr.index = re + 0.00f;
            isr.ISRType = ISRType.Limite1;
        }
        else if(user.Salary >= 7735.01f && user.Salary < 65651.07f){
          var ba = user.Salary - 7735.01f;
          var re = ba * (6.40f/100);
          isr.index = re + 148.51f;
            isr.ISRType = ISRType.Limite2;
        }
        else if(user.Salary >= 65651.08f && user.Salary < 115375.90f){
          var ba = user.Salary - 65651.08f;
          var re = ba * (10.88f/100);
          isr.index = re + 3855.14f;
            isr.ISRType = ISRType.Limite3;
        }
        else if(user.Salary >= 115375.91f && user.Salary < 134119.41f){
          var ba = user.Salary - 115375.91f;
          var re = ba * (16.00f/100);
          isr.index = re + 9265.20f;
            isr.ISRType = ISRType.Limite4;
        }
        else if(user.Salary >= 134119.42f && user.Salary < 160577.65f){
          var ba = user.Salary - 134119.42f;
          var re = ba * (17.92f/100);
          isr.index = re + 12264.16f;
            isr.ISRType = ISRType.Limite5;
        }
        else if(user.Salary >= 160577.66f && user.Salary < 323862.00f){
          var ba = user.Salary - 160577.66f;
          var re = ba * (21.36f/100);
          isr.index = re + 17005.47f;
            isr.ISRType = ISRType.Limite6;
        }
        else if(user.Salary >= 323862.01f && user.Salary < 510451.00f){
          var ba = user.Salary - 323862.01f;
          var re = ba * (23.52f/100);
          isr.index = re + 51883.01f;
            isr.ISRType = ISRType.Limite7;
        }
        else if(user.Salary >= 510451.01f && user.Salary < 974535.03f){
          var ba = user.Salary - 510451.01f;
          var re = ba * (30.00f/100);
          isr.index = re + 95768.74f;
            isr.ISRType = ISRType.Limite8;
        }
        else if(user.Salary >= 974535.04f && user.Salary < 1299380.04f){
          var ba = user.Salary - 974535.04f;
          var re = ba * (32.00f/100);
          isr.index = re + 234993.95f;
            isr.ISRType = ISRType.Limite9;
        }
        else if(user.Salary >= 1299380.05f && user.Salary < 3898140.12f){
          var ba = user.Salary - 1299380.05f;
          var re = ba * (34.00f/100);
          isr.index = re + 338944.34f;
            isr.ISRType = ISRType.Limite10;
        }
        else if(user.Salary > 3898140.13f){
          var ba = user.Salary - 3898140.13f;
          var re = ba * (35.00f/100);
          isr.index = re + 1222522.76f;
            isr.ISRType = ISRType.Limite11;
        }
        return isr;
}
}
