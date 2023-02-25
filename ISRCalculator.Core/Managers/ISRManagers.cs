using ISRCalculator.Core.Managers.Interfaces;
using ISRCalculator.Core.Entities;
using ISRCalculator.Core.Services.Interfaces;

namespace ISRCalculator.Core.Managers;

public class ISRManagers : IISRManagers 
{
    private readonly IISRService _service;
    public ISRManagers (IISRService service){
        _service = service;
    }

    public ISR GetISR(User user){
        return _service.ProcessISR(user);
    }
}
