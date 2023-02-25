using ISRCalculator.Core.Entities;

namespace ISRCalculator.Core.Managers.Interfaces;

public interface IISRManagers
{
    ISR GetISR(User user);
}
