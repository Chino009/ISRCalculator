using ISRCalculator.Core.Entities;

namespace ISRCalculator.Core.Services.Interfaces;

public interface IISRService{
    ISR ProcessISR(User user);
}
